using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Sinapse.Model
{
    public class Valores1
    {
        public string periodo { get; set; }
        public decimal valor { get; set; }
        public int idOpcao { get; set; }

        public Valores1(string ValorNome, decimal Valor, int IdOpcao)
        {
            periodo = ValorNome;
            valor = Valor;
            idOpcao= IdOpcao;
        }
    }

}
