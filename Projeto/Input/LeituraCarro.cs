using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Projeto.Input
{
    public class LeituraCarro
    {
        public int LerCodigo()
        {
            try
            {
                Console.Write("Digite o Código do Carro......: ");
                int codigo = Convert.ToInt32(Console.ReadLine());

                if (codigo > 0)
                {
                    return codigo;
                }
                else
                {
                    throw new Exception("Erro no Código!!!");    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\tErro " + e.Message);
                return LerCodigo();
            }
        }

        public string LerTipo()
        {
            try
            {
                Console.Write("Digite o Tipo do Carro........: ");
                string tipo = Console.ReadLine();

                return tipo;
            }
            catch (Exception e)
            {
                Console.WriteLine("\tErro " + e.Message);
                return LerTipo();
            }
        }

        public string LerCor() 
        {
            try
            {
                Console.Write("Digite a Cor do Carro.....: ");
                string cor = Console.ReadLine();

                return cor;
            }
            catch (Exception e)
            {
                Console.WriteLine("\tErro " + e.Message);
                return LerCor();
            }
        }

        public string LerPlaca()
        {
            try
            {
                Console.Write("Digite a Placa do Carro......: ");
                string placa = Console.ReadLine();

                Regex reg = new Regex(@"^[a-zA-Z]{3}\-\d{4}$");

                if (reg.IsMatch(placa))
                {
                    return placa;
                }
                else
                {
                    throw new Exception("Número da Placa está incorreta!!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\tErro " + e.Message);
                return LerPlaca();
            }
        }

        public int LerNumPortas()
        {
            try
            {
                Console.Write("Digite o Número de Portas......: ");
                int numPortas = Convert.ToInt32(Console.ReadLine());

                if (numPortas < 5)
                {
                    return numPortas;
                }
                else
                {
                    throw new Exception("Número de Portas Inválida!!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\t Erro " + e.Message);

                return LerNumPortas();
            }
        }

        public decimal LerPreco()
        {
            try
            {
                Console.Write("Digite o Preço do Carro......: R$ ");
                decimal preco = Convert.ToDecimal(Console.ReadLine());

                return preco;
            }
            catch (Exception e)
            {
                Console.WriteLine("\tErro " + e.Message);
                return LerPreco();
            }
        }
    }
}
