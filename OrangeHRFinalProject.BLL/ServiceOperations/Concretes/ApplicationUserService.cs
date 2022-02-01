using AutoMapper;
using Microsoft.AspNetCore.Identity;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.Entities.Authentication;
using OrangeHRFinalProject.ViewModels.AccountViewModels.LoginVM;
using OrangeHRFinalProject.ViewModels.AccountViewModels.RegisterVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class ApplicationUserService:IUserServiceOperations
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly IEmployeeService employeeService;
        private readonly IMapper mapper;

        public ApplicationUserService(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager,IEmployeeService employeeService,IMapper mapper)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.employeeService = employeeService;
            this.mapper = mapper;
        }

        public async Task<IdentityResult> Create(UserRegisterVM model)
        {
            ApplicationUser user = mapper.Map<ApplicationUser>(model);
            var result = await userManager.CreateAsync(user, model.Employee.Password);
            return result;
        }
        public async Task<string> CreateToken(UserRegisterVM model)
        {
            var user = await FindUserByEmail(model.Employee.CorporateEMail);
            if (user != null)
            {
                var token = await userManager.GenerateEmailConfirmationTokenAsync(user);
                return token;
            }
            else
                return null;
        }
        public async Task<ApplicationUser> FindUserByEmail(string email)
        {
            return await userManager.FindByEmailAsync(email);
        }
        public async Task<SignInResult> EmployeeLogin(EmployeeLoginVM model)
        {
            SignInResult result = null;
            var user = await userManager.FindByEmailAsync(model.CorporeateEMail);
            var employee = await employeeService.GetByEmail(model.CorporeateEMail);
            if (user is not null && employee.IsActive && await userManager.IsInRoleAsync(user,CoreDefinitions.RoleEmployee))
            {
                result = await signInManager.PasswordSignInAsync(model.CorporeateEMail, model.Password, false, false);
            }            
            return result;
        }
        public async Task<SignInResult> ManagerLogin(ManagerLoginVM model)
        {
            var user = userManager.Users.SingleOrDefault(m => m.FieldName == model.FieldName);            
            if (user!=null && await userManager.IsInRoleAsync(user,CoreDefinitions.RoleManager))
            {
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);
                return result;
            }
            else
                throw new InvalidOperationException("Belirtilen kullanıcı bulunamadı");
        }
        public async Task<SignInResult> AdminLogin(AdminLoginVM model)
        {
            SignInResult result = null;
            var user = await userManager.FindByEmailAsync(model.Email);            
            if (user is not null && await userManager.IsInRoleAsync(user, CoreDefinitions.RoleAdmin))
            {
                result = await signInManager.PasswordSignInAsync(model.Email, model.Password, false, false);
            }
            return result;
        }              
        public async Task<IdentityResult> ConfirmEmail(ApplicationUser user, string token)
        {
            return await userManager.ConfirmEmailAsync(user, token);
        }
        public async Task<IdentityResult> AssignRole(int userId, string roleName)
        {
            var user = await userManager.FindByIdAsync(userId.ToString());
            if (!await userManager.IsInRoleAsync(user, roleName))
            {
                IdentityResult result = await userManager.AddToRoleAsync(user, roleName);
                return result;
            }
            return null;
        }
        public async Task SignOut()
        {
            await signInManager.SignOutAsync();
        }
        public List<ApplicationUser> ListAll()
        {
            var userList = userManager.Users.ToList();
            return userList;
        }
        public async Task<ApplicationUser> FindUserById(int userId)
        {
            return await userManager.FindByIdAsync(userId.ToString());
        }
        public async Task<bool> IsEmailConfirmed(ApplicationUser user)
        {
            return await userManager.IsEmailConfirmedAsync(user);
        }
        public async Task<IdentityResult> ResetPassword(ApplicationUser user, string token, string password)
        {
            if (user != null)
            {
                var result = await userManager.ResetPasswordAsync(user, token, password);
                return result;
            }
            else
                throw new Exception("Şifre yenileme başarısız");
        }
        public async Task<string> CreatePasswordResetToken(ApplicationUser user)
        {
            return await userManager.GeneratePasswordResetTokenAsync(user);
        }

    }
}
