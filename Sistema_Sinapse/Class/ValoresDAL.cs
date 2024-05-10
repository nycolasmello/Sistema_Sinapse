using MySql.Data.MySqlClient;
using Sistema_Sinapse.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Sinapse.Class
{
    public class ValoresDAL
    {
        private MySqlConnection _mySqlConnection;

        public ValoresDAL(MySqlConnection mySqlConnection)
        {
            _mySqlConnection = mySqlConnection;
        }

        public void RegistrarValor(Valores1 valores)
        {
            _mySqlConnection.Open();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText = "insert into tb_valoresaula (val_periodo,val_valor,val_id_opcao) values (@Periodo,@Valor,@idOpcao)";
            cmd.Parameters.Add("@Periodo", MySqlDbType.VarChar, 150).Value = valores.periodo;
            cmd.Parameters.Add("@Valor", MySqlDbType.Decimal, 20).Value = valores.valor;
            cmd.Parameters.Add("@idOpcao", MySqlDbType.Int32, 10).Value = valores.idOpcao;
            cmd.ExecuteNonQuery();
            _mySqlConnection.Close();
        }
        public void AlterarValor(Valores1 valores, string periodo,int idOpcao)
        {
            _mySqlConnection.Open();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText = "update tb_valoresaula set val_periodo=@Periodo,val_valor=@Valor,val_id_opcao=@idOpcao where val_nome='" + periodo+"', and val_id_opcao='" + idOpcao + "'";
            cmd.Parameters.Add("@Periodo", MySqlDbType.VarChar, 150).Value = valores.periodo;
            cmd.Parameters.Add("@Valor", MySqlDbType.Decimal, 9).Value = valores.valor;
            cmd.Parameters.Add("@idOpcao", MySqlDbType.Int32, 10).Value = valores.idOpcao;
            cmd.ExecuteNonQuery();
            _mySqlConnection.Close();
        }
        public void DeletarOpcao(string periodo,int idOpcao) 
        {
            _mySqlConnection.Open();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText = "delete from tb_valoresaula where val_periodo='"+ periodo + "' and val_id_opcao = '"+idOpcao+"'";
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
                    adaptador.Fill(ds, "tb_valoresaula"); // Preenche a tabela
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
