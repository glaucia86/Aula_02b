using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Model;
using Projeto.Persistence;
using Projeto.Input;


namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
            LeituraCarro lc = new LeituraCarro();

            car.IdCodigo    = lc.LerCodigo();
            car.Tipo        = lc.LerTipo();
            car.Placa       = lc.LerPlaca();
            car.NumPortas   = lc.LerNumPortas();
            car.Cor         = lc.LerCor();
            car.Preco       = lc.LerPreco();

            Console.WriteLine("\n\n------------- Dados do Carro --------------- ");
            Console.WriteLine("Código..................: " + car.IdCodigo);
            Console.WriteLine("Tipo....................: " + car.Tipo);
            Console.WriteLine("Placa...................: " + car.Placa);
            Console.WriteLine("Número de Portas........: " + car.NumPortas);
            Console.WriteLine("Cor.....................: " + car.Cor);
            Console.WriteLine("Preço...................: R$ " + car.Preco );

            Arquivo a = new Arquivo();
            a.GravarExcel(car);

            Console.ReadKey();
            
        }
    }
}
