using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface IServiceOperations<T,TEntityDetailsVM, TEntityCreateVM, TEntityUpdateVM> where T:EntityBase
    {
        Task<IList<TEntityDetailsVM>> GetAll();
        Task<TEntityDetailsVM> GetById(int id);
        Task<T> Add(TEntityCreateVM model);
        Task<bool> Update(TEntityUpdateVM model, int id);
        Task<bool> Remove(int id);
    }
}
