using OrangeHRFinalProject.DAL.Context;
using OrangeHRFinalProject.DAL.Repositories.Common;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;

namespace OrangeHRFinalProject.DAL.Repositories.Concretes
{
    public class LiabilityCategoryRepository : RepositoryBase<LiabilityCategory>, ILiabilityCategoryRepository
    {
        public LiabilityCategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }



}
