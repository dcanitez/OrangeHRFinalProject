using OrangeHRFinalProject.BLL.ServiceOperations.Common;
using OrangeHRFinalProject.Entities.Concretes;
using OrangeHRFinalProject.ViewModels.Commons.LiabilityCategoryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRFinalProject.BLL.ServiceOperations.Interfaces
{
    public interface ILiabilityCategoryService:IServiceOperations<LiabilityCategory,LiabilityCategoryDetailsVM,LiabilityCategoryCreateVM,LiabilityCategoryUpdateVM>
    {
    }
}
