using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Sinapse.Model
{
    public class OpcoesAula1
    {
        public string Descricao { get; set; }
        public string Duracao { get; set; }
        public OpcoesAula1(string descricao, string duracao) {
            Descricao = descricao;
            Duracao = duracao;
        }
    }
}
