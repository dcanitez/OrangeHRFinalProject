using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.ReceiptViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class ReceiptService : ServiceBase<Receipt, IReceiptRepository, ReceiptDetailsVM, ReceiptCreateVM, ReceiptUpdateVM>, IReceiptService
    {
        private readonly IReceiptRepository service;
        private readonly IMapper mapper;

        public ReceiptService(IReceiptRepository service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
    }
}
