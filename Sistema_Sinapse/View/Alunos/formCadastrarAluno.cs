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
            OpcoesAulaDAL opcoesDAL = new OpcoesAulaDAL(new MySqlConnection(connectionString));

            //Lista as Turmas cadastradas (Turma: SEG-TER-QUA) etc...
            string listTurmas = "select tur_nome from tb_turmas";
            var returnDataSet = turmaDAL.dataSet(listTurmas);
            this.cmbTurma.DisplayMember = "tur_nome";
            this.cmbTurma.ValueMember = "tur_id";
            this.cmbTurma.DataSource = returnDataSet.Tables["tb_turmas"];


            //Lista as Opcoes (2 vezes na semana) (1 vez na semana)
            string listOpcoes = "select opc_descricao from tb_opcoes";
            var returDataSet1 = opcoesDAL.dataSet(listOpcoes);
            this.cmbOpcoes.DisplayMember = "opc_descricao";
            this.cmbOpcoes.ValueMember = "opc_id";
            this.cmbOpcoes.DataSource = returDataSet1.Tables["tb_opcoes"];


        }

        private void btnRegistrarAluno_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            AlunosDAL alunosDAL = new AlunosDAL(new MySqlConnection(connectionString));
            TurmasDAL turmaDAL = new TurmasDAL(new MySqlConnection(connectionString));
            OpcoesAulaDAL opcoesDAL = new OpcoesAulaDAL(new MySqlConnection(connectionString));
            var Data = dataNascimento.Value;
            DateTime dataReg = DateTime.Now;
            int idTurma = turmaDAL.obterIdPeloNome(cmbTurma.Text);
            int idOpcao = opcoesDAL.obterIDPeloNome(cmbOpcoes.Text);

            try
            {
                
                Alunos1 alunos1 = new Alunos1(
                    txtNomeAluno.Text,
                    Data,
                    txtCpfAluno.Text,
                    txtRgAluno.Text,
                    idTurma,
                    txtNomeResponsavel.Text,
                    txtTelefoneResponsavel.Text,
                    txtCpfResponsavel.Text,
                    txtRgResponsavel.Text,
                    cmbStatusAluno.Text,
                    dataReg,
                    idOpcao
                    );
                alunosDAL.InserirAluno(alunos1);
                MessageBox.Show("Aluno Registrado");
                txtNomeAluno.Text = "";
                dataNascimento.Text = "";
                txtNomeResponsavel.Text = "";
                txtCpfAluno.Text = "";
                txtCpfResponsavel.Text = "";
                txtNomeAluno.Select();
                txtNomeAluno.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

  
    }
}
