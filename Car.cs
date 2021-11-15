using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dealershipCar
{
    public class Car
    {
        private string modelo;
        private string cor;
        private string marca;
        private double kmsRodados;
        private bool status = false;
        private Maintenance manutencao;
        private Client cliente;
        private int id;

        public Car(string modelo, string cor, string marca, double kmsRodados, bool status, int id)
        {
          this.modelo = modelo;
          this.cor = cor;
          this.marca = marca;
          this.kmsRodados = kmsRodados;
          this.Status = status;
          this.Id = id;
        }

        public string getModelo() { 
            
          return this.modelo;
        }

        public void setModelo(string m) {
          
          this.modelo = m;
        }
        public string getCor() {
          
          return this.cor;
        }

        public void setCor(string c) {

            this.cor = c;
        }

        public string getMarca() { 
            
          return this.marca;
        }

        public void setMarca(string marca) {

            this.marca = marca;
        }

        public double getKmsRodados() { 
         
          return this.kmsRodados;
        }

        public void setKmsRodados(double km){
          
          this.kmsRodados = km;
        }

        public bool Status { 

          get { return status; } 
          set { status = value; }  
        }

        public Maintenance Manutencao {
         
          get { return manutencao; } 
          set { manutencao = value; } 
        }

        public Client Cliente { 
          
          get { return cliente; } 
          set { cliente = value; } 
        }
        public int Id { 
          
          get { return id; } 
          set { id = value; }
        }

        public override string ToString() {
         
          return modelo + " " +  marca  +  " " + cor + " " +  kmsRodados + " " + status + $"{(status == false ? " Em estoque " : "Vendido para: ")}" + string.Join(",", cliente) + string.Join(",", manutencao);
        }
    }
}