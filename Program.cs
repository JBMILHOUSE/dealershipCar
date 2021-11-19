using System;
using System.Collections.Generic;

namespace dealershipCar
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Bem vindes a concessionária Interlagos!");
          List<Car> cars = PreencherCars();
          int id = 0;
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
                  cars.Add(InsertCar(++id));
                  break;
                case 2:
                  ResearchByMBC(cars);
                  break;
                case 3:
                  ResearchByKM(cars);
                  break;
                case 4:
                  filterStatus(cars);
                  break;
                case 5:
                  addMaintenance(cars);
                  break;
                case 6:
                  soldCar(cars);
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

          listCar.Add(new Car("Argo", "preto", "Fiat", 1000, false, 1, 2019));
          listCar.Add(new Car("Compass", "azul", "Jeep", 1200, true, 2, 2020));
          listCar.Add(new Car("Onix", "preto", "Chevrolet", 1300, true, 3, 2015));
          listCar.Add(new Car("Pulse", "vermelho", "Fiat", 0, false, 4, 2022));

          return listCar;
        }

        static int Menu() {

          Console.WriteLine("Hi, Selecione aqui: ");
          Console.WriteLine("1 - Inserir novo carro");
          Console.WriteLine("2 - Pesquisar por modelo ou cor ou marca ou ano");
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
          Console.WriteLine("4 - Pesquisar por ano");

          int respostaPesquisa = Int32.Parse(Console.ReadLine());
         
          switch(respostaPesquisa) {
            case 1: 
              Console.WriteLine("Digite o modelo do carro");
              string model = Console.ReadLine();
              listCars(cars.FindAll(car => car.getModelo().Equals(model)));
              break;
            case 2:
              Console.WriteLine("Digite o marca do carro");
              string mark = Console.ReadLine();
              listCars(cars.FindAll(car => car.getMarca().Equals(mark)));
              break;
            case 3:
              Console.WriteLine("Entre com a cor do carro");
              string color = Console.ReadLine();
              listCars(cars.FindAll(car => car.getCor().Equals(color)));
              break;
            case 4: 
              Console.WriteLine("Entre com o ano do carro");
              string year = Console.ReadLine();
              listCars(cars.FindAll(car => car.Ano.Equals(Int32.Parse(year))));
              break;
            default:
              Console.WriteLine("Opção inválida, tente novamente \n");
              break;
          }
        }

        static void ResearchByKM(List<Car> cars){

          Console.WriteLine("Entre com o valor da quilômetragem");
          double respostaKM = double.Parse(Console.ReadLine());
          
          Car kmCar = cars.Find(car => car.getKmsRodados().Equals(respostaKM));

          if(kmCar != null) {
            listCars(cars.FindAll(car => car.getKmsRodados() <= respostaKM));
            Console.WriteLine();

          } else {
            Console.WriteLine("Nenhum carro encontrado \n");
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

          Console.WriteLine("Digite o ano do carro");
          int ano = Int32.Parse(Console.ReadLine());

          Car newCar = new Car(modelCar, colorCar, markCar, km, false, id, ano);

          Console.WriteLine("Carro inserido com sucesso!");
          return newCar;
        }

        static void filterStatus(List<Car> cars){
          
          Console.WriteLine("1 - Filtrar por estoque");
          Console.WriteLine("2 - Filtrar por vendido");

          int respostaFilterStatus = Int32.Parse(Console.ReadLine());
        
          switch(respostaFilterStatus) {
            case 1:
               Car inStock = cars.Find(car => car.Status == false);

               if (inStock != null)
               {
                  listCars(cars.FindAll(car => car.Status == false));
               } 
               else {
                 Console.WriteLine("nenhum carro em estoque");
               }
              break;
            case 2:
                Car inSold = cars.Find(car => car.Status == true);

                if (inSold != null)
                {
                  listCars(cars.FindAll(car => car.Status == true));
                } 
                else {
                 Console.WriteLine("nenhum carro foi vendido");
                }
              break;
          }
        }

        static void addMaintenance(List<Car> cars){

          Car inStatusMaintenance = cars.Find(car => car.Status == false);

          listCars(cars);
        
          if (inStatusMaintenance != null) 
          {
            Console.WriteLine("Entre com id do carro, o qual deseja realizar a manutenção");
            int idCar = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da oficina");
            string mechanicalWorkshop = Console.ReadLine();

            Console.WriteLine("Digite a data manutenção");
            string data = Console.ReadLine();

            List<string> pecasTrocadas = new List<string>();
            bool sair = false;
            string peca;

            do
            {
              if (pecasTrocadas.Count == 0)
              {
                Console.WriteLine("Digite o nome da peça trocada");
                peca = Console.ReadLine();
                pecasTrocadas.Add(peca);   
              }

              Console.WriteLine("Digite 1 para adicionar outra peça");
              Console.WriteLine("Digite 2 para finalizar");

              int respostaMaintenance = Int32.Parse(Console.ReadLine());

              if (respostaMaintenance.Equals(1))
              {
                Console.WriteLine("Digite o nome da peça tocada");
                peca = Console.ReadLine();
                pecasTrocadas.Add(peca);
              } else {
                Console.WriteLine("Manutenção adicionada");
                sair = true;
              }

             Car inMaintenanceCar = cars.Find(car => car.Id == idCar);
             Maintenance newMaintenance = new Maintenance(mechanicalWorkshop, data, pecasTrocadas);
             inMaintenanceCar.Manutencao = newMaintenance;

            } while (!sair);
          }

        }

        static void soldCar(List<Car> cars) {

         Car inStock = cars.Find(car => car.Status == false);
         if (inStock != null)
         {
             Console.WriteLine("Digite o id do carro que deseja vender");
             int idCarSold = Int32.Parse(Console.ReadLine());

             Car selectedCar = cars.Find(car => car.Id == idCarSold);

             if (selectedCar != null)
             {
               Console.WriteLine("Digite o nome do comprador");
               string nameBuyer = Console.ReadLine();

               Console.WriteLine("Digite o cpf do comprador");
               string cpfBuyer = Console.ReadLine();

               Client buyer = new Client(nameBuyer, cpfBuyer);

               selectedCar.Status = true;
               selectedCar.Cliente = buyer;
               Console.WriteLine("Vendido com sucesso");
             }
         }
        }
    }
}
