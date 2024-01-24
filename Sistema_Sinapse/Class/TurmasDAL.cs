using MySql.Data.MySqlClient;
using Sistema_Sinapse.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Sinapse.Class
{
    public class TurmasDAL
    {
        private MySqlConnection _mySqlConnection;

        public TurmasDAL(MySqlConnection mySqlConnection)
        {
            _mySqlConnection = mySqlConnection;
        }

        public void registrarTurma(Turmas turmas)
        {
            _mySqlConnection.Open();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText = "insert into tb_turmas (tur_nome,tur_id_professor,tur_horarioInicial,tur_horarioFinal,tur_diaSemana) values (@Nome,@idProfessor,@horarioInicial,@horarioFinal,@diaSemana)";
            cmd.Parameters.Add("@Nome", MySqlDbType.VarChar, 150).Value = turmas.Nome;
            cmd.Parameters.Add("@idProfessor", MySqlDbType.Int32, 10).Value = turmas.IdProf;
            cmd.Parameters.Add("@horarioInicial", MySqlDbType.DateTime, 100).Value = turmas.HoraInicial;
            cmd.Parameters.Add("@horarioFinal", MySqlDbType.DateTime, 100).Value = turmas.HoraFinal;
            cmd.Parameters.Add("@diaSemana", MySqlDbType.VarChar, 200).Value = turmas.DiaSemana;
            cmd.ExecuteNonQuery();
            _mySqlConnection.Close();
        }

        public int obterIdPeloNome(string nome)
        {
            _mySqlConnection.Open();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText = "select tur_id from tb_turmas where tur_nome = '" + nome + "'";
            var returnScalar = cmd.ExecuteScalar();
            _mySqlConnection.Close();
            int idProf = Convert.ToInt32(returnScalar);
            return idProf;
        }
        public string obterNomePeloID(int id)
        {
            _mySqlConnection.Open();
            MySqlCommand cmd = _mySqlConnection.CreateCommand();
            cmd.CommandText = "select tur_nome from tb_turmas where tur_id = '" + id + "'";
            var returnScalar = cmd.ExecuteScalar();
            _mySqlConnection.Close();
            string nomeTurma = Convert.ToString(returnScalar);
            return nomeTurma;
        }
        public DataSet dataSet(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                    _mySqlConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, _mySqlConnection);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    adaptador.Fill(ds, "tb_turmas"); // Preenche a tabela
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro ao obter dados: " + ex.Message);
            }    
            finally
            {
                _mySqlConnection.Close(); // Fecha conexão
            }
            return ds;
        }
    }
}
