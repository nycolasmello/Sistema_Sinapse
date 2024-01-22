using MySql.Data.MySqlClient;
using Sistema_Sinapse.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Sinapse.Class
{
    public class AlunosDAL
    {
        private MySqlConnection _mySqlConnection;

        public AlunosDAL(MySqlConnection mySqlConnection)
        {
            _mySqlConnection = mySqlConnection;
        }

        public void InserirAluno (Alunos1 alunos1)
        {
            _mySqlConnection.Open ();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText = "insert into tb_alunos (alu_nome,alu_datanasc,alu_cpf,id_alu_turma,alu_responsavel,alu_telefoneResp, alu_cpfResp,alu_ValorMensalidade,alu_statusAluno) values (@Nome,@DataNasc,@Cpf,@idAluTurma,@Responsavel,@TelefoneResp,@CpfResp,@ValorMensalidade,@StatusAluno)";
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 150).Value = alunos1.Nome;
            cmd.Parameters.Add("@DataNasc", MySqlDbType.DateTime, 10).Value = alunos1.DataNasc;
            cmd.Parameters.Add("@Cpf", MySqlDbType.VarChar, 150).Value = alunos1.Cpf;
            cmd.Parameters.Add("@idAluTurma", MySqlDbType.Int32, 10).Value = alunos1.idAluTurma;
            cmd.Parameters.Add("@Responsavel", MySqlDbType.VarChar, 150).Value = alunos1.Responsavel;
            cmd.Parameters.Add("@TelefoneResp", MySqlDbType.VarChar, 150).Value = alunos1.TelefoneResponsavel;
            cmd.Parameters.Add("@CpfResp", MySqlDbType.VarChar, 150).Value = alunos1.CpfResponsavel;
            cmd.Parameters.Add("@ValorMensalidade", MySqlDbType.Decimal, 10).Value = alunos1.ValorMensalidade;
            cmd.Parameters.Add("@StatusAluno", MySqlDbType.VarChar, 20).Value = alunos1.StatusAluno;
            cmd.ExecuteNonQuery();
            _mySqlConnection.Close();
        }
        public DataSet dataSet(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                try
                {
                    _mySqlConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, _mySqlConnection);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    adaptador.Fill(ds, "tb_alunos"); // Preenche a tabela
                }
                catch { }
            }
            finally
            {
                _mySqlConnection.Close(); // Fecha conexão
            }
            return ds;
        }
        public DataTable dataTable(string query)
        {
            // aqui vai o "SELECT * FROM CLIENTES""
            DataTable data = new DataTable("tabela"); // Cria table com os dados vindos do BD

            try
            {
                try
                {
                    _mySqlConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, _mySqlConnection);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    adaptador.Fill(data); // Preenche a tabela
                }
                catch { }
            }
            finally
            {
                _mySqlConnection.Close(); // Fecha conexão
            }
            return data; // Retorna um datatable com todos dados      
        }
    }
}
