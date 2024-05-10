using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Sinapse.Model
{
    public class Turmas1
    {
        public string Nome { get; set; }
        public int IdProf { get; set; }
        public string HoraInicial { get; set; }
        public string HoraFinal { get; set; }      
        public string DiaSemana { get; set; }

        public Turmas1(string nome, int idProf, string dataInicial, string dataFinal, string diaSemana)
        {
            Nome = nome;
            IdProf= idProf;
            HoraInicial = dataInicial;
            HoraFinal = dataFinal;
            DiaSemana = diaSemana;

        }
    }
}
