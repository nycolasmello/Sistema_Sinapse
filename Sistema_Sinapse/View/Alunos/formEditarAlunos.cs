using MySql.Data.MySqlClient;
using Sistema_Sinapse.Class;
using Sistema_Sinapse.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Sinapse.View.Alunos
{
    public partial class formEditarAlunos : Form
    {
        public formEditarAlunos(string nomeAluno)
        {
            InitializeComponent();
            lblNomeAluno.Text = nomeAluno;
        }

        private void formEditarAlunos_Load(object sender, EventArgs e)
        {
            dataNascimento.Format = DateTimePickerFormat.Custom;
            dataNascimento.CustomFormat = "dd/MM/yyyy";
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            AlunosDAL alunosDAL = new AlunosDAL(new MySqlConnection(connectionString));
            TurmasDAL turmasDAL = new TurmasDAL(new MySqlConnection(connectionString));

            try
            {
               lblNomeAluno.Visible= false;
                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tb_alunos where alu_nome = '" + lblNomeAluno.Text + "'";
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                txtNomeAluno.Text = reader.GetString(1);
                DateTime dataNasc = reader.GetDateTime(2);
                dataNascimento.Value = dataNasc;
                txtCpfAluno.Text = reader.GetString(3);

                //Função para obter NOME da turma
                int idTurma = reader.GetInt32(4);
                string query = "select tur_id, tur_nome from tb_turmas";
                var returnDataSet = turmasDAL.dataSet(query);
                this.cmbTurma.DisplayMember= "tur_nome";
                this.cmbTurma.ValueMember = "tur_id";
                this.cmbTurma.DataSource = returnDataSet.Tables["tb_turmas"];
                this.cmbTurma.SelectedIndex = idTurma-1;


                txtNomeResponsavel.Text = reader.GetString(5);
                txtTelefoneResponsavel.Text = reader.GetString(6);
                txtCpfResponsavel.Text = reader.GetString(7);

                decimal mensalidade = reader.GetDecimal(8);
                txtValorMensalidade.Text = Convert.ToString(mensalidade);
                cmbStatusAluno.Text = reader.GetString(9);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);

            }

        }

        private void btnRegistrarAluno_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            AlunosDAL alunosDAL = new AlunosDAL(new MySqlConnection(connectionString));
            TurmasDAL turmasDAL = new TurmasDAL(new MySqlConnection(connectionString));
            string aluno = lblNomeAluno.Text;
            int idAluno = alunosDAL.ObterIdAluno(aluno);
            int idTurma = turmasDAL.obterIdPeloNome(cmbTurma.Text);
            DateTime Data = dataNascimento.Value;
            decimal mensalidade = Convert.ToDecimal(txtValorMensalidade.Text);
            try
            {
                Alunos1 alunos1 = new Alunos1(
                    txtNomeAluno.Text,
                    Data,
                    txtCpfAluno.Text,
                    idTurma,
                    txtNomeResponsavel.Text,
                    txtTelefoneResponsavel.Text,
                    txtCpfResponsavel.Text,
                    mensalidade,
                    cmbStatusAluno.Text
                    );
                alunosDAL.AlterarAluno(alunos1,idAluno);
                MessageBox.Show("Aluno Alterado");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void txtValorMensalidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegistrarAluno_Click(sender, e);
            }
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = '.';

                //Verifica se já existe alguma vírgula na string
                if (txtValorMensalidade.Text.Contains("."))
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
