using Microsoft.AspNetCore.Mvc;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Combined.AccountViewModels.LoginVM;
using OrangeHRFinalProject.ViewModels.Combined.AccountViewModels.PasswordVM;
using OrangeHRFinalProject.ViewModels.Combined.AccountViewModels.RegisterVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserServiceOperations userService;
        private readonly ICompanyService companyService;
        private readonly IEmployeeService employeeService;

        public AccountController(IUserServiceOperations userService, ICompanyService companyService, IEmployeeService employeeService)
        {
            this.userService = userService;
            this.companyService = companyService;
            this.employeeService = employeeService;
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterVM model)
        {
            #region DENEME DATA!
            //model.Employee.FirstName = "Dilay";
            //model.Employee.LastName = "Canıtez";
            //model.Employee.CorporatePhoneNumber = "05523642020";
            //model.Employee.CorporateEMail = "dilay@mail.com";
            //model.Employee.IsDataProtectionRead = true;
            //model.Employee.Password = "123456789";
            //model.Company.CompanyName = "ats ltd şti";
            //model.Company.NumberofEmployee = 1;
            //model.Company.Sector = "hizmet"; 
            #endregion

            if (ModelState.IsValid)
            {
                try
                {
                    var employee = await employeeService.Add(model.Employee);
                    if (employee is not null)
                    {
                        var company = await companyService.Add(model.Company);
                        if (company is not null)
                        {
                            var result = await userService.Create(model);
                            if (result.Succeeded)
                            {
                                var user = await userService.FindUserByEmail(model.Employee.CorporateEMail);
                                var token = await userService.CreateToken(model);
                                string fullName = $"{model.Employee.FirstName} {model.Employee.LastName}";
                                string confirmationLink = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, token = token }, Request.Scheme);
                                SendMailService.SendMail(confirmationLink, fullName);
                                ViewBag.SuccessfulRegistration = "Kayıt başarılı bir şekilde yapılmıştır.";
                                ViewBag.SuccessMessage = "Giriş yapmak için, Email Gelen kutunuzdaki mail doğrulama" +
                                                            "linkine tıklayınız.";
                            }
                            else
                            {
                                foreach (var error in result.Errors)
                                {
                                    ModelState.AddModelError(string.Empty, error.Description);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult EmployeeLogin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> EmployeeLogin(EmployeeLoginVM model)
        {
            if (ModelState.IsValid)
            {
                var result = await userService.EmployeeLogin(model);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Index), "Personel");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Giriş yapılamadı");
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult ManagerLogin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ManagerLogin(ManagerLoginVM model)
        {
            if (ModelState.IsValid)
            {
                var result = await userService.ManagerLogin(model);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Index), "Manager");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Giriş yapılamadı");
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AdminLogin(AdminLoginVM model)
        {
            if (ModelState.IsValid)
            {
                var result = await userService.AdminLogin(model);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Index), "Administration");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Giriş yapılamadı");
                }
            }
            return View(model);
        }
        [HttpGet("{userId}")]
        public async Task<IActionResult> ConfirmEmail(int userId, string token)
        {
            if (userId == 0 || token == null)
            {
                return RedirectToAction("Index", "Home");
            }
            var user = await userService.FindUserById(userId);
            if (user == null)
            {
                ViewBag.ErrorMessage = "Kullanıcı Bulunamadı";
                return View("NotFound");
            }
            var result = await userService.ConfirmEmail(user, token);
            if (result.Succeeded)
            {                                
                var roleAssign = await userService.AssignRole(user.Id, CoreDefinitions.RoleManager);
                if (roleAssign.Succeeded || roleAssign is null)
                {
                    //Email onayınız başarıyla tamamlanmıştır.
                    //Kaydınız tamamlandığında mail ile tarafınıza bilgilendirme yapılacaktır.
                    return View("ConfirmEmail");
                }
                else
                    ModelState.AddModelError(string.Empty, "Mail onayınız gerçekleştirilemedi.");
                return View("Error");
            }
            else
            {
                return View("Error");
            }
        }
        [HttpGet]
        public IActionResult ForgotPassword()
        {
            //şifremi unuttum linkine basıldığında Email adresini alacağımız bir view açılmalı.
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await userService.FindUserByEmail(model.Email);
                string fullName = $"{user.FirstName} {user.LastName}";
                if (user != null && await userService.IsEmailConfirmed(user))
                {
                    var token = await userService.CreatePasswordResetToken(user);
                    string passwordResetLink = Url.Action("ResetPassword", "Account", new { email = model.Email, token = token }, Request.Scheme);
                    SendMailService.SendMail(passwordResetLink, fullName);
                    return View("ForgetPasswordConfirmation");
                }
                return View("ForgetPasswordConfirmation");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult ResetPassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var user = await userService.FindUserByEmail(model.CorporeateEMail);
                    if (user != null)
                    {
                        var result = await userService.ResetPassword(user, model.Token, model.Password);
                        if (result.Succeeded)
                        {
                            return View("ResetPasswordConfirmation");
                        }
                        foreach (var error in result.Errors)
                        {
                            ModelState.AddModelError(string.Empty, error.Description);
                        }
                        return View(model);
                    }
                    return View("ResetPasswordConfirmation");
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, ex.Message);
                    return View(model);
                }
            }

            return View(model);
        }

    }
}
