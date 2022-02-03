using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.MembershipViewModels;


namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IMembershipService : IServiceOperations<Membership, MembershipDetailsVM, MembershipCreateVM, MembershipUpdateVM>
    {

    }
}
