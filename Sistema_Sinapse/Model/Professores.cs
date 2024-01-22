using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Sinapse.Model
{
    public class Professores
    {
        public string Nome { get; set; }
        public DateTime DataNasc { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public decimal Salario { get; set; }
        public Professores(string nome, DateTime dataNasc, string cpf, string telefone, decimal salario)
        {
            Nome = nome;
            DataNasc = dataNasc;
            Cpf = cpf;
            Telefone = telefone;
            Salario = salario;
        }


    }
}
