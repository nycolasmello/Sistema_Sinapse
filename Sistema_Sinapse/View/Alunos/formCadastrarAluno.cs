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

namespace Sistema_Sinapse.View
{
    public partial class formCadastrarAluno : Form
    {
        public formCadastrarAluno()
        {
            InitializeComponent();
        }

        private void formCadastrarAluno_Load(object sender, EventArgs e)
        {
            dataNascimento.Format = DateTimePickerFormat.Custom;
            dataNascimento.CustomFormat = "dd/MM/yyyy";
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            TurmasDAL turmaDAL = new TurmasDAL(new MySqlConnection(connectionString));

            string listTurmas = "select tur_nome from tb_turmas";
            var returnDataSet = turmaDAL.dataSet(listTurmas);
            this.cmbTurma.DisplayMember = "tur_nome";
            this.cmbTurma.ValueMember = "tur_id";
            this.cmbTurma.DataSource = returnDataSet.Tables["tb_turmas"];

        }

        private void btnRegistrarAluno_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            AlunosDAL alunosDAL = new AlunosDAL(new MySqlConnection(connectionString));
            TurmasDAL turmaDAL = new TurmasDAL(new MySqlConnection(connectionString));
            var Data = dataNascimento.Value;
            int idTurma = turmaDAL.obterIdPeloNome(cmbTurma.Text);
            decimal valorMensal = Convert.ToDecimal(txtValorMensalidade.Text);

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
                    valorMensal,
                    cmbStatusAluno.Text
                    );
                alunosDAL.InserirAluno(alunos1);
                MessageBox.Show("Aluno Registrado");
                txtNomeAluno.Text = "";
                dataNascimento.Text = "";
                txtNomeResponsavel.Text = "";
                txtCpfAluno.Text = "";
                txtCpfResponsavel.Text = "";
                txtValorMensalidade.Text = "";
                txtNomeAluno.Select();
                txtNomeAluno.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
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
