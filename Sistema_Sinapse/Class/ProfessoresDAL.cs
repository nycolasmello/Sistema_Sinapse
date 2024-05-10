using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Sistema_Sinapse.Model;

namespace Sistema_Sinapse.Class
{
    public class ProfessoresDAL
    {
        private MySqlConnection _mySqlConnection;

        public ProfessoresDAL(MySqlConnection mySqlConnection) {
            _mySqlConnection = mySqlConnection;
        }
        public void Inserir(Professores1 professores)
        {
            _mySqlConnection.Open();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText = "insert into tb_professores (prof_nome,prof_datanasc,prof_cpf, prof_telefone, prof_salario) values (@Nome,@Data,@Cpf,@Telefone,@Salario)";
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 100).Value = professores.Nome;
            cmd.Parameters.Add("@Data", MySqlDbType.Date, 150).Value = professores.DataNasc;
            cmd.Parameters.Add("@Cpf", MySqlDbType.VarChar, 25).Value = professores.Cpf;
            cmd.Parameters.Add("@Telefone", MySqlDbType.VarChar, 25).Value = professores.Telefone;
            cmd.Parameters.Add("@Salario", MySqlDbType.Decimal, 9).Value = professores.Salario;


            cmd.ExecuteNonQuery();
            _mySqlConnection.Close();
        }
        public int obterIdPeloNome (string nome)
        {
            _mySqlConnection.Open();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText= "select prof_id from tb_professores where prof_nome = '" + nome + "'";
            var returnScalar = cmd.ExecuteScalar();
            _mySqlConnection.Close();
            int idProf = Convert.ToInt32(returnScalar);
            return idProf;
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
                    adaptador.Fill(ds, "tb_professores"); 
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
        public void DeletarProfessor(string nomeProfessor)
        {
            _mySqlConnection.Open();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText = "delete from tb_professores where prof_nome = '" + nomeProfessor + "'";
            cmd.ExecuteNonQuery();
            _mySqlConnection.Close();
        }
        public void AlterarProfessor(Professores1 professores, int idProfessor)
        {
            _mySqlConnection.Open();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText = "update tb_professores set prof_nome=@Nome, prof_datanasc=@Data, prof_cpf=@Cpf,prof_telefone=@Telefone,prof_salario=@Salario where prof_id='" + idProfessor + "'";
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 150).Value = professores.Nome;
            cmd.Parameters.Add("@Data", MySqlDbType.DateTime, 10).Value = professores.DataNasc;
            cmd.Parameters.Add("@Cpf", MySqlDbType.VarChar, 150).Value = professores.Cpf;
            cmd.Parameters.Add("@Telefone", MySqlDbType.VarChar, 150).Value = professores.Telefone;
            cmd.Parameters.Add("@Salario", MySqlDbType.Decimal, 150).Value = professores.Salario;
            cmd.ExecuteNonQuery();
            _mySqlConnection.Close();

        }
    }
}
