using OrangeHRFinalProject.DAL.Context;
using OrangeHRFinalProject.DAL.Repositories.Common;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;

namespace OrangeHRFinalProject.DAL.Repositories.Concretes
{
    public class DistrictRepository : RepositoryBase<District>, IDistrictRepository
    {
        public DistrictRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
