using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Projeto.Model;

namespace Projeto.Persistence
{
    //Classe para Ler Arquivos:

    public class Arquivo
    {
        public void GravarExcel(Carro c)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\Glaucia\\Documents\\Visual Studio 2012\\Projects\\Exemplos Curso - Coti Informatica 2014\\Aula_02b\\temp\\venda.csv", true);
                sw.WriteLine(c.IdCodigo + ";" + c.Tipo + ";" + c.Placa + ";" + c.NumPortas + ";" + c.Cor + ";" + c.Preco);
                sw.Close();

                Console.WriteLine("Dados Gravados com Sucesso!!!!");
            }
            catch (Exception e)
            {
                Console.WriteLine("\tErro " + e.Message);
            }
        }
    }
}
