using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dealershipCar
{
    public class Client
    {
        private string name;
        private string cpf;

        public Client(string name, string cpf)
        {
            this.name = name;
            this.cpf = cpf;
        }

        public string Name { 
            
          get { return name; }
          set { name = value; }
        }
        public string Cpf { 
         
          get { return cpf; }
          set { cpf = value; } 
        }

        public override string ToString() {

          return name + " " + cpf;
        }
    }
}