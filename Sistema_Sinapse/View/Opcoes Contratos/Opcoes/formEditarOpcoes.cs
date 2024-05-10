using MySql.Data.MySqlClient;
using Sistema_Sinapse.Class;
using Sistema_Sinapse.Model;
using Sistema_Sinapse.View.Professores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Sinapse.View.Opcoes_Contratos.Opcoes
{
    public partial class formEditarOpcoes : Form
    {
        private formConsultarOpcoes formConsultar1;
        public formEditarOpcoes(string nomeAula, formConsultarOpcoes formEditar)
        {
           
            InitializeComponent();
            lblNomeAula.Text = nomeAula;
            formConsultar1= formEditar;
        }

        private void formEditarOpcoes_Load(object sender, EventArgs e)
        {
            lblNomeAula.Visible = false;
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            OpcoesAulaDAL opcoesDAL = new OpcoesAulaDAL(new MySqlConnection(connectionString));

            try
            {
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tb_opcoes where opc_descricao = '" + lblNomeAula.Text + "'";
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                txtDescricaoAula.Text = reader.GetString(1);
                txtDuracao.Text = reader.GetString(2);
                conn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);

            }

        }

        private void formEditarOpcoes_FormClosed(object sender, FormClosedEventArgs e)
        {
            formConsultar1.AtualizarDataGrid();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            OpcoesAulaDAL opcoesDAL = new OpcoesAulaDAL(new MySqlConnection(connectionString));
            int idOpcao = opcoesDAL.obterIDPeloNome(lblNomeAula.Text);
            OpcoesAula1 opcoes = new OpcoesAula1(
                txtDescricaoAula.Text,
                txtDuracao.Text
                );
            opcoesDAL.AlterarOpcoes(opcoes, idOpcao);
            MessageBox.Show("Alterado com sucesso");
        }

        private void txtDuracao_KeyPress(object sender, KeyPressEventArgs e)
        {
            int limiteCaracteres = 5;
            // Verifica se o comprimento atual excede o limite
            if (txtDuracao.Text.Length >= limiteCaracteres && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Impede a entrada de caracteres adicionais
            }
            // Verifica se o caractere é numérico ou :
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true; // Ignora o caractere se não for um número ou :

            }
            // Adiciona a barra automaticamente na posição correta
            if (char.IsDigit(e.KeyChar) && (txtDuracao.SelectionStart == 2))
            {
                txtDuracao.Text += ":";
                txtDuracao.SelectionStart = txtDuracao.Text.Length; // Move o cursor para o final
            }
        }
    }
}
