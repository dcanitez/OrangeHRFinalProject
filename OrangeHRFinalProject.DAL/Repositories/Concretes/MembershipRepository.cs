using OrangeHRFinalProject.DAL.Context;
using OrangeHRFinalProject.DAL.Repositories.Common;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;

namespace OrangeHRFinalProject.DAL.Repositories.Concretes
{
    public class MembershipRepository : RepositoryBase<Membership>, IMembershipRepository
    {
        public MembershipRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
