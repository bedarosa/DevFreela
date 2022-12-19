using DevFreela.Application.InputModels;
using DevFreela.Application.ViewModels;
using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Service.Interfaces
{
    public interface IUserService
    {
        public UserViewModel GetById(int id);
        public UserViewModel Create(CreateUserInputModel inputModel);
        public void Login();

    }
}
