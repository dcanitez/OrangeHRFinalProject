using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Common;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Common
{
    public class ServiceBase<T,TRepository,TEntityDetailsVM, TEntityCreateVM, TEntityUpdateVM> : IServiceOperations<T,TEntityDetailsVM, TEntityCreateVM, TEntityUpdateVM> where TRepository: IRepositoryBase<T> where T:EntityBase
    {
        private readonly TRepository service;
        private readonly IMapper mapper;
        public ServiceBase(TRepository service,IMapper mapper)
        {
            this.service = service;
            this.mapper = mapper; 
        }
        public async Task<T> Add(TEntityCreateVM model)
        {
            T entity = mapper.Map<T>(model);
            var result = await service.AddAsync(entity);
            return result;
        }

        public async Task<IList<TEntityDetailsVM>> GetAll()
        {
            var entities = await service.GetAllAsync();
            return mapper.Map<IList<TEntityDetailsVM>>(entities);
        }

        public async Task<TEntityDetailsVM> GetById(int id)
        {
            return mapper.Map<TEntityDetailsVM>(await service.GetByIdAsync(id));
        }

        public async Task<bool> Remove(int id)
        {
            var entity = await service.GetByIdAsync(id);
            return await service.RemoveAsync(entity) > 0;
        }

        public async Task<bool> Update(TEntityUpdateVM model, int id)
        {
            var updated = await service.GetByIdAsync(id);
            if (updated is not null)
            {
                updated = mapper.Map<T>(model);
                return await service.UpdateAsync(updated) > 0;
            }

            else
                return false;
        }
    }
}
