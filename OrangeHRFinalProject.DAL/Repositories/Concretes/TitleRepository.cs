using OrangeHRFinalProject.DAL.Context;
using OrangeHRFinalProject.DAL.Repositories.Common;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;

namespace OrangeHRFinalProject.DAL.Repositories.Concretes
{
    public class TitleRepository : RepositoryBase<Title>, ITitleRepository
    {
        public TitleRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
