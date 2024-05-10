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
        public string Rg { get; set; }
        public int idAluTurma { get; set; }
        public string Responsavel { get; set; }
        public string TelefoneResponsavel { get; set; }
        public string CpfResponsavel { get; set; }
        public string RgResponsavel { get; set; }
        public string StatusAluno { get; set; }
        public DateTime DataRegistro { get; set; }
        public int idAluOpcao { get; set; }

        public Alunos1(string nome, DateTime dataNasc, string cpf,string rg , int IdAluTurma, string responsavel, string telefoneResponsavel, string cpfResponsavel,string rgResponsavel, string statusAluno,DateTime dataRegistro,int idaluOpcao) { 
            Nome = nome;
            DataNasc = dataNasc;
            Cpf = cpf;
            Rg= rg;
            idAluTurma= IdAluTurma;
            Responsavel = responsavel;
            TelefoneResponsavel= telefoneResponsavel;
            CpfResponsavel= cpfResponsavel;
            RgResponsavel= rgResponsavel;
            StatusAluno= statusAluno;
            DataRegistro = dataRegistro;
            idAluOpcao= idaluOpcao;
        
        }
    }
}
