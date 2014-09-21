using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Model
{
    public class Carro
    {
        public int IdCodigo { get; set; }
        public string Tipo { get; set; }
        public string Cor { get; set; }
        public string Placa { get; set; }
        public int NumPortas { get; set; }
        public decimal Preco { get; set; }
    }
}
