using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dealershipCar
{
    public class Maintenance
    {
        private string nameOficina;
        private string data;
        private List<string> listPecasTrocadas;

        public Maintenance(string nameOficina, string data, List<string> listPecasTrocadas)
        {
            this.nameOficina = nameOficina;
            this.data = data;
            this.listPecasTrocadas = listPecasTrocadas;
        }

        public string NameOficina { 
          
          get { return nameOficina; } 
          set { nameOficina = value; } 
        
        }
        public string Data {
          
          get { return data; } 
          set { data = value; } 
        }

        public List<string> ListPecasTrocadas { 
         
          get { return listPecasTrocadas; } 
          set { listPecasTrocadas = value; }
        }

        public override string ToString()
        {
            return  nameOficina + " " + Data + " " +  string.Join(", ", listPecasTrocadas);
        }
    }
}