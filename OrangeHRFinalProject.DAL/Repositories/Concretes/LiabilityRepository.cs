using OrangeHRFinalProject.DAL.Context;
using OrangeHRFinalProject.DAL.Repositories.Common;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;

namespace OrangeHRFinalProject.DAL.Repositories.Concretes
{
    public class LiabilityRepository : RepositoryBase<Liability>, ILiabilityRepository
    {
        public LiabilityRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }



}
