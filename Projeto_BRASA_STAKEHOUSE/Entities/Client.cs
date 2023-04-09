using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_BRASA_STAKEHOUSE.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Cpf { get; set; }
        public int YearsOld { get; set; }

        public Client()
        {
        }

        public Client(string name, string cpf, int yearsOld)
        {
            Name = name;
            Cpf = cpf;
            YearsOld = yearsOld;
        }
    }
}
