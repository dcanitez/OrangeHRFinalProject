using Microsoft.AspNetCore.Identity;
using OrangeHRFinalProject.Entities.Authentication;
using OrangeHRFinalProject.ViewModels.Combined.AccountViewModels.LoginVM;
using OrangeHRFinalProject.ViewModels.Combined.AccountViewModels.RegisterVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IUserServiceOperations
    {
        Task<IdentityResult> Create(UserRegisterVM model);
        Task<ApplicationUser> FindUserByEmail(string email);
        Task<string> CreateToken(UserRegisterVM model);
        Task<SignInResult> EmployeeLogin(EmployeeLoginVM model);
        Task<SignInResult> ManagerLogin(ManagerLoginVM model);
        Task<SignInResult> AdminLogin(AdminLoginVM model);
        List<ApplicationUser> ListAll();
        Task<ApplicationUser> FindUserById(int userId);
        Task<IdentityResult> ConfirmEmail(ApplicationUser user, string token);
        Task<bool> IsEmailConfirmed(ApplicationUser user);
        Task<string> CreatePasswordResetToken(ApplicationUser user);
        Task<IdentityResult> ResetPassword(ApplicationUser user, string token, string password);
        Task<IdentityResult> AssignRole(int userId, string roleName);
        Task<List<ApplicationUser>> UserRoleListByRoleName(string roleName);
        Task SignOut();
    }
}
