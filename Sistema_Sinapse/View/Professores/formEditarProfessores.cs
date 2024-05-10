using MySql.Data.MySqlClient;
using Sistema_Sinapse.Class;
using Sistema_Sinapse.Model;
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

namespace Sistema_Sinapse.View.Professores
{
    public partial class formEditarProfessores : Form
    {
        private formConsultarProfessores formConsultar1;
        public formEditarProfessores(string nomeProfessor, formConsultarProfessores formConsultar)
        {
            InitializeComponent();
            lblNomeProfessor.Text = nomeProfessor;
            this.formConsultar1 = formConsultar;
        }

        private void btnRegistrarProf_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            ProfessoresDAL professoresDAL = new ProfessoresDAL(new MySqlConnection(connectionString));
            int idProfessor = professoresDAL.obterIdPeloNome(lblNomeProfessor.Text);

            DateTime Data = dataNascimento.Value;
            decimal Salario = Convert.ToDecimal(txtSalario.Text);

            try
            {
                Professores1 professores = new Professores1(
                    txtNome.Text,
                    Data,
                    txtCpf.Text,
                    txtTelefone.Text,
                    Salario
                    );
                professoresDAL.AlterarProfessor(professores, idProfessor);
                MessageBox.Show("Dados alterados com sucesso!");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void formEditarProfessores_Load(object sender, EventArgs e)
        {
            dataNascimento.Format = DateTimePickerFormat.Custom;
            dataNascimento.CustomFormat = "dd/MM/yyyy";
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;   

            try
            {
                lblNomeProfessor.Visible = false;
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tb_professores where prof_nome = '" + lblNomeProfessor.Text + "'";
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                txtNome.Text = reader.GetString(1);
                DateTime dataNasc = reader.GetDateTime(2);
                dataNascimento.Value = dataNasc;
                txtCpf.Text = reader.GetString(3);
                txtTelefone.Text = reader.GetString(4);
                decimal mensalidade = reader.GetDecimal(5);
                txtSalario.Text = Convert.ToString(mensalidade);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);

            }
        }

        private void formEditarProfessores_FormClosed(object sender, FormClosedEventArgs e)
        {
            formConsultar1.AtualizarDataGrid();
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegistrarProf_Click(sender, e);
            }
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = '.';

                //Verifica se já existe alguma vírgula na string
                if (txtSalario.Text.Contains("."))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
