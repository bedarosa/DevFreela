using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevFreela.Application.ViewModels;

namespace DevFreela.Application.Service.Interfaces
{
    public interface ISkillService
    {
        List<SkillViewModel> GetAll();
    }
}
