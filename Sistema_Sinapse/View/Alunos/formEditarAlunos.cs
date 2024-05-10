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
        private formConsultarAlunos formConsultar1;
        public formEditarAlunos(string nomeAluno, formConsultarAlunos formConsultar)
        {
            InitializeComponent();
            lblNomeAluno.Text = nomeAluno;
            this.formConsultar1 = formConsultar;

        }

        private void formEditarAlunos_Load(object sender, EventArgs e)
        {
            dataNascimento.Format = DateTimePickerFormat.Custom;
            dataNascimento.CustomFormat = "dd/MM/yyyy";
            dataRegistro.Format = DateTimePickerFormat.Custom;
            dataRegistro.CustomFormat = "dd/MM/yyyy";

            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            AlunosDAL alunosDAL = new AlunosDAL(new MySqlConnection(connectionString));
            TurmasDAL turmasDAL = new TurmasDAL(new MySqlConnection(connectionString));
            OpcoesAulaDAL opcoesDAL = new OpcoesAulaDAL(new MySqlConnection(connectionString));

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
                txtRgAluno.Text= reader.GetString(4);
                

                //Função para obter NOME da turma
                int idTurma = reader.GetInt32(5);
                string query = "select tur_id, tur_nome from tb_turmas";
                var returnDataSet = turmasDAL.dataSet(query);
                this.cmbTurma.DisplayMember= "tur_nome";
                this.cmbTurma.ValueMember = "tur_id";
                this.cmbTurma.DataSource = returnDataSet.Tables["tb_turmas"];

                txtNomeResponsavel.Text = reader.GetString(6);
                txtTelefoneResponsavel.Text = reader.GetString(7);
                txtCpfResponsavel.Text = reader.GetString(8);
                txtRgResponsavel.Text = reader.GetString(9);
                cmbStatusAluno.Text = reader.GetString(10);
                DateTime Data_Registro = reader.GetDateTime(11);
                dataRegistro.Value = Data_Registro;
                int idOpcao = reader.GetInt32(12);
                string query1 = "select opc_descricao from tb_opcoes";
                var returnDataSet1 = opcoesDAL.dataSet(query1);
                this.cmbOpcoes.DisplayMember = "opc_descricao";
                this.cmbOpcoes.ValueMember = "opc_id";
                this.cmbOpcoes.DataSource = returnDataSet1.Tables["tb_opcoes"];
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);

            }

        }   

        private void formEditarAlunos_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void formEditarAlunos_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void btnRegistrarAluno_Click_1(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            AlunosDAL alunosDAL = new AlunosDAL(new MySqlConnection(connectionString));
            TurmasDAL turmasDAL = new TurmasDAL(new MySqlConnection(connectionString));
            OpcoesAulaDAL opcoesDAL = new OpcoesAulaDAL(new MySqlConnection(connectionString));
            string aluno = lblNomeAluno.Text;
            int idAluno = alunosDAL.ObterIdAluno(aluno);
            int idTurma = turmasDAL.obterIdPeloNome(cmbTurma.Text);
            int idOpcao = opcoesDAL.obterIDPeloNome(cmbOpcoes.Text);

            DateTime Data = dataNascimento.Value;
            //DateTime dataRegistro = alunosDAL.SelecionarDataRegistroPeloNome(aluno);
            DateTime Data_Registro = dataRegistro.Value;
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
                    Data_Registro,
                    idOpcao
                    );
                alunosDAL.AlterarAluno(alunos1, idAluno);
                MessageBox.Show("Aluno Alterado");
                formConsultar1.AtualizarDataGridView();// Atualiza o DG do Consultar Alunos

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
