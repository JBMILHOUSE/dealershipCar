using System;
using System.Collections.Generic;

namespace dealershipCar
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Welcome to dealership car");

          List<Car> cars = PreencherCars();
          //int id = 0;
          bool sair = false;

          while(!sair)
          {
            int opcao = Menu();
            if (opcao == 0)
            {
              Console.Clear();
              Console.WriteLine("Opcão inválida");
            }
            else {

              Console.Clear();
              switch(opcao){
                case 1:
                  cars.Add(InsertCar(cars.Count));
                  break;
                case 2:
                  ResearchByMBC(cars);
                  break;
                case 3:
                  ResearchByKM(cars);
                  break;
                case 4:
                  Console.WriteLine("Funcionalidade");
                  break;
                case 5:
                  Console.WriteLine("Funcionalidade");
                  break;
                case 6:
                  Console.WriteLine("Funcionalidade");
                  break;
                case 7:
                  sair = true;
                  break;
              }
            }
          }   

        }

        static List<Car> PreencherCars() {

          List<Car> listCar = new List<Car>();

          listCar.Add(new Car("Argo", "preto", "Fiat", 1000, false, 1));
          listCar.Add(new Car("Compass", "azul", "Jeep", 1200, false, 2));
          listCar.Add(new Car("Onix", "preto", "Chevrolet", 1300, false, 3));
          listCar.Add(new Car("Pulse", "vermelho", "Fiat", 0, true, 4));

          return listCar;
        }

        static int Menu() {

          Console.WriteLine("Hi, Selecione aqui: ");
          Console.WriteLine("1 - Inserir novo carro");
          Console.WriteLine("2 - Pesquisar por  modelo ou cor ou marca ");
          Console.WriteLine("3 - Pesquisa por km rodados ");
          Console.WriteLine("4 - Filtrar por status ");
          Console.WriteLine("5 - Adicionar uma manutenção");
          Console.WriteLine("6 - Vender um carro");
          Console.WriteLine("7 - Sair");
        
          int menuResposta = Int32.Parse(Console.ReadLine());

          if (menuResposta > 7 || menuResposta < 1)
          {
            return 0;
          }

          return menuResposta;
        }

        static void listCars(List<Car> cars) {

          cars.ForEach(delegate (Car car){

            Console.WriteLine(car);
          });
        }

        static void ResearchByMBC(List<Car> cars) {
          
          Console.WriteLine("1 - Pesquisar por modelo");
          Console.WriteLine("2 - Pesquisar por marca");
          Console.WriteLine("3 - Pesquisar por cor");

          int respostaPesquisa = Int32.Parse(Console.ReadLine());
          string pesquisa = Console.ReadLine();

          if(respostaPesquisa.Equals(1)) {

            Console.WriteLine("Digite o modelo do carro");
            listCars(cars.FindAll(car => car.getModelo().Equals(pesquisa)));
          }

          if (respostaPesquisa.Equals(2)) 
          {
            Console.WriteLine("Digite o marca do carro");
            listCars(cars.FindAll(car => car.getMarca().Equals(pesquisa)));
          }

          if (respostaPesquisa.Equals(3))
          {
            Console.WriteLine("Entre com a cor do carro");
            listCars(cars.FindAll(car => car.getCor().Equals(pesquisa)));
          }
        }

        static void ResearchByKM(List<Car> cars){

          Console.WriteLine("Entre com o valor da quilômetragem");
          double respostaKM = double.Parse(Console.ReadLine());
          
          if (respostaKM.Equals(1000) || respostaKM.Equals(0))
          {
            listCars(cars.FindAll(car => car.getKmsRodados().Equals(respostaKM)));
          }

          if (respostaKM.Equals(2000))
          {
            listCars(cars.FindAll(car => car.getKmsRodados().Equals(respostaKM)));
          }
        }

        static Car InsertCar(int id) {
          
          Console.WriteLine("Digite o nome do modelo do carro");
          string modelCar = Console.ReadLine();

          Console.WriteLine("Digite o nome da marca do modelo do carro");
          string markCar = Console.ReadLine();

          Console.WriteLine("Digite a cor do carro");
          string colorCar = Console.ReadLine();

          Console.WriteLine("Digite a quilometragem do carro");
          double km = double.Parse(Console.ReadLine());

          Car newCar = new Car(modelCar, colorCar, markCar, km, false, id);
          return newCar;
        }

        static void filterStatus(List<Car> cars){
          
          Console.WriteLine("1 - Filtrar por estoque");
          Console.WriteLine("2 - Filter por vendido");

          int respostaFilterStatus = Int32.Parse(Console.ReadLine());

          switch(respostaFilterStatus) {
            case 1:
              Console.WriteLine("funcionalidade");
              break;
            case 2:
              Console.WriteLine("funcionalidade");
              break;
          }
        }

    }
}
