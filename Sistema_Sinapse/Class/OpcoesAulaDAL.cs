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
    public class OpcoesAulaDAL
    {
        private MySqlConnection _mySqlConnection;

        public OpcoesAulaDAL(MySqlConnection mySqlConnection)
        {
            _mySqlConnection = mySqlConnection;
        }
        
        public void registrarOpcao(OpcoesAula1 opcoes)
        {
            _mySqlConnection.Open();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText = "insert into tb_opcoes(opc_descricao,opc_duracao) values (@Descricao,@Duracao)";
            cmd.Parameters.Add("@Descricao", MySqlDbType.VarChar, 500).Value = opcoes.Descricao;
            cmd.Parameters.Add("@Duracao", MySqlDbType.VarChar, 50).Value = opcoes.Duracao;
            cmd.ExecuteNonQuery();
            _mySqlConnection.Close();

        }
        public int obterIDPeloNome(string nome)
        {
            _mySqlConnection.Open();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText = "select opc_id from tb_opcoes where opc_descricao = '" + nome + "'";
            var returnScalar  = cmd.ExecuteScalar();
            _mySqlConnection.Close();
            int id = Convert.ToInt32(returnScalar);
            return id;
            
        }
        public void DeletarOpcao(string nome)
        {
            _mySqlConnection.Open();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText = "delete from tb_opcoes where opc_descricao = '" + nome + "'";
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
                    adaptador.Fill(ds, "tb_opcoes"); // Preenche a tabela
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

        public void AlterarOpcoes(OpcoesAula1 opcoes, int idOpcao)
        {
            _mySqlConnection.Open();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText = "update tb_opcoes set opc_descricao=@Descricao,opc_duracao=@Duracao where opc_id='" + idOpcao + "'";
            cmd.Parameters.Add("@Descricao", MySqlDbType.VarChar, 150).Value = opcoes.Descricao;
            cmd.Parameters.Add("@Duracao", MySqlDbType.VarChar, 50).Value = opcoes.Duracao;         
            cmd.ExecuteNonQuery();
            _mySqlConnection.Close();

        }

    }
}
