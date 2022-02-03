﻿using AutoMapper;
using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.BLL.ServiceOperations.Interfaces;
using OrangeHRFinalProject.DAL.Repositories.Interfaces;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.DepartmentViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Concretes
{
    public class DepartmentService : ServiceBase<Department, IDepartmentRepository, DepartmentDetailsVM, DepartmentCreateVM, DepartmentUpdateVM>,IDepartmentService
    {
        private readonly IDepartmentRepository service;
        private readonly IMapper mapper;

        public DepartmentService(IDepartmentRepository service, IMapper mapper) : base(service, mapper)
        {
            this.service = service;
            this.mapper = mapper;
        }
    }
}
