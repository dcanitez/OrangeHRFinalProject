using OrangeHRFinalProject.DAL.Context;
using OrangeHRFinalProject.DAL.Repositories.Common;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.DAL.Repositories.Concretes
{
    public class BreakRepository : RepositoryBase<Break>, IBreakRepository
    {
        public BreakRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }



}
