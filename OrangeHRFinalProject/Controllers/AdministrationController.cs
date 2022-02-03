using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.ViewModels.Combined.AdministrationViewModels;
using OrangeHRFinalProject.ViewModels.Commons.CountryViewModels;
using OrangeHRFinalProject.ViewModels.Commons.DepartmentViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace OrangeHRFinalProject.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly IUserServiceOperations userService;
        private readonly ICompanyService companyService;
        private readonly IHolidayService holidayService;
        private readonly IDepartmentService departmentService;
        private readonly ICountryService countryService;
        private readonly IWebHostEnvironment hostingEnvironment;

        public AdministrationController(IUserServiceOperations userService, ICompanyService companyService, IHolidayService holidayService, IDepartmentService departmentService, ICountryService countryService,IWebHostEnvironment hostingEnvironment)
        {
            this.userService = userService;
            this.companyService = companyService;
            this.holidayService = holidayService;
            this.departmentService = departmentService;
            this.countryService = countryService;
            this.hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var companyMembership = await companyService.GetAllActiveCompanies();
            var holidayList = await holidayService.GetAllByOrder();

            HolidayCompanyListVM model = new HolidayCompanyListVM
            {
                CompanyList = companyMembership,
                HolidayList = holidayList
            };
            return View(model);
        }

        public async Task<IActionResult> GetNumberData()
        {
            var managers = await userService.UserRoleListByRoleName(CoreDefinitions.RoleManager);
            var personels = await userService.UserRoleListByRoleName(CoreDefinitions.RoleEmployee);
            var companies = await companyService.GetAllActiveCompanies();
            AdminMainVM vm = new AdminMainVM
            {
                NumberOfManagers = managers.Count,
                NumberOfPersonels = personels.Count,
                NumberOfCompanies = companies.Count
            };

            return Json(vm);
        }

        public IActionResult DefinitionIndex()
        {
            return View();
        }

        #region Department Operations
        [HttpGet]
        public async Task<IActionResult> DepartmentList()
        {
            var result = await departmentService.GetAll();
            return View(result);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDepartment(DepartmentCreateVM model)
        {
            if (ModelState.IsValid)
            {
                var department = await departmentService.FindByName(model.Description);
                if (department is not null)
                    ModelState.AddModelError(string.Empty, "Belirtilen departman daha önce tanımlanmıştır.\nLütfen listeyi kontrol ediniz.");
                var result = await departmentService.Add(model);
                if (result is not null)
                {
                    ViewBag.message = "Departman başarıyla oluşturuldu";
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Bir hata oluştu");
                }
            }
            return View();
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateDepartment(int id, DepartmentUpdateVM model)
        {
            if (ModelState.IsValid)
            {
                var department = await departmentService.FindByName(model.Description);
                if (department is null)
                    ModelState.AddModelError(string.Empty, "Belirtilen departman bulunamadı");
                var result = await departmentService.Update(model, id);
                if (result)
                {
                    ViewBag.message = "Departman başarıyla güncellendi";
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Bir hata oluştu");
                }
            }
            return View();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            var department = await departmentService.GetById(id);
            if (department is null)
                ModelState.AddModelError(string.Empty, "Belirtilen departman bulunamadı");
            if (department.NumberOfEmployees > 0)
                ModelState.AddModelError(string.Empty, "Bu departmanda çalışan personeller mevcuttur.\nİlgili personelleri silerek işleminize devam edebilirsiniz.");
            var result = await departmentService.Remove(id);
            if (!result)
                ViewBag.message = "Departman silinemedi";
            return View();
        }

        #endregion

        #region Country-City-District Operations        

        [HttpPost]
        public IActionResult UploadCountryCityDistrictExcelFile(IFormFile excelFile)
        {
            if (excelFile == null || excelFile.Length == 0)
            {
                ModelState.AddModelError(string.Empty, "Lütfen dosya seçimi yapınız.");
                return View();
            }
            else
            {
                if(excelFile.FileName.EndsWith("xls")|| excelFile.FileName.EndsWith("xlsx"))
                {
                    string uniqueFileName = GetUniqueFileName(excelFile.FileName);
                    string uploads = Path.Combine(hostingEnvironment.WebRootPath, "uploads\\admin\\excelfiles");
                    string filePath= Path.Combine(uploads, uniqueFileName);

                    if (System.IO.File.Exists(filePath))
                    {
                        ModelState.AddModelError(string.Empty, "Dosya zaten mevcuttur.");
                        return View();
                    }
                    excelFile.CopyTo(new FileStream(filePath, FileMode.Create));                   

                }
                else
                    ModelState.AddModelError(string.Empty, "Lütfen uygun formatta dosya seçimi yapınız.");
            }               

            return RedirectToAction(nameof(DefinitionIndex),"Administration");
        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_"
                      + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }

        

        //            Excel.Application application = new Excel.Application();
        //            Excel.Workbook workbook = application.Workbooks.Open(path);
        //            Excel.Worksheet worksheet = workbook.ActiveSheet;
        //            Excel.Range range = worksheet.UsedRange;

        //            List<ListModel> localList = new List<ListModel>();

        //            for (int i = 2; i <= range.Rows.Count; i++)
        //            {
        //                ListModel lm = new ListModel();

        //                lm.Id = Convert.ToInt32(((Excel.Range)range.Cells[i, 1]).Text);
        //                lm.Name = ((Excel.Range)range.Cells[i, 2]).Text;
        //                lm.SurName = ((Excel.Range)range.Cells[i, 3]).Text;
        //                lm.Email = ((Excel.Range)range.Cells[i, 4]).Text;

        //                localList.Add(lm);
        //            }

        //            application.Quit();

        //            ViewBag.ListDetay = localList;

        //            return View("listele");
        //        }
        //        else
        //        {
        //            ViewBag.Error = "Dosya tipiniz yanlış, lütfen '.xls' yada '.xlsx' uzantılı dosya yükleyiniz.";

        //            return View();
        //        }
        //    }
        //}

        #endregion




    }
}
