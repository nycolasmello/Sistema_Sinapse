using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Sinapse.Model
{
    public class Turmas
    {
        public string Nome { get; set; }
        public int IdProf { get; set; }
        public DateTime HoraInicial { get; set; }
        public DateTime HoraFinal { get; set; }
        
        public string DiaSemana { get; set; }

        public Turmas(string nome, int idProf, DateTime dataInicial, DateTime dataFinal, string diaSemana)
        {
            Nome = nome;
            IdProf= idProf;
            HoraInicial = dataInicial;
            HoraFinal = dataFinal;
            DiaSemana = diaSemana;

        }
    }
}
