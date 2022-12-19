using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.InputModels
{
    public class NewProjectInputModel
    {
        public string Titulo { get; set; }
        public string Description { get; set; }
        public int IdCliente { get; set; }
        public int IdFreelance { get; set; }
        public decimal TotalCost { get; set; }
    }
}
