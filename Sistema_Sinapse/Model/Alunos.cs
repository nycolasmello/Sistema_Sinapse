using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Sinapse.Model
{
    public class Alunos1
    {
        public string Nome { get; set; }
        public  DateTime DataNasc { get; set; }
        public string Cpf { get; set; }
        public int idAluTurma { get; set; }
        public string Responsavel { get; set; }
        public string TelefoneResponsavel { get; set; }
        public string CpfResponsavel { get; set; }
        public decimal ValorMensalidade { get; set; }
        public string StatusAluno { get; set; }

        public Alunos1(string nome, DateTime dataNasc, string cpf, int IdAluTurma, string responsavel, string telefoneResponsavel, string cpfResponsavel, decimal valorMensalidade, string statusAluno) { 
            Nome = nome;
            DataNasc = dataNasc;
            Cpf = cpf;
            idAluTurma= IdAluTurma;
            Responsavel = responsavel;
            TelefoneResponsavel= telefoneResponsavel;
            CpfResponsavel= cpfResponsavel;
            ValorMensalidade= valorMensalidade;
            StatusAluno= statusAluno;
        
        }
    }
}
