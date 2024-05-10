using MySql.Data.MySqlClient;
using Sistema_Sinapse.Class;
using Sistema_Sinapse.View.Alunos;
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

namespace Sistema_Sinapse.View.Professores
{
    public partial class formConsultarProfessores : Form
    {
        public formConsultarProfessores()
        {
            InitializeComponent();
        }

        private void formConsultarProfessores_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            ProfessoresDAL professoresDAL = new ProfessoresDAL(new MySqlConnection(connectionString));

            try
            {
                string listAlunosCMB = "select prof_nome from tb_professores";
                var returnDataSet = professoresDAL.dataSet(listAlunosCMB);
                this.cmbNomeProfessor.DisplayMember = "prof_nome";
                this.cmbNomeProfessor.ValueMember = "prof_id";
                this.cmbNomeProfessor.DataSource = returnDataSet.Tables["tb_professores"];


                string listProfessores = "select prof_nome, prof_datanasc,prof_cpf,prof_telefone,prof_salario from tb_professores";
                var returnDataTable = professoresDAL.dataTable(listProfessores);
                dgvProfessores.DataSource = returnDataTable;
                dgvProfessores.Columns["prof_nome"].HeaderText = "Aluno";
                dgvProfessores.Columns["prof_datanasc"].HeaderText = "Data Nascimento";
                dgvProfessores.Columns["prof_cpf"].HeaderText = "CPF";
                dgvProfessores.Columns["prof_telefone"].HeaderText = "Telefone";
                dgvProfessores.Columns["prof_salario"].HeaderText = "Salário";
                dgvProfessores.Columns[4].DefaultCellStyle.Format = "c2";
                dgvProfessores.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);

            }
        }
        public void AtualizarDataGrid()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            ProfessoresDAL professoresDAL = new ProfessoresDAL(new MySqlConnection(connectionString));

            try
            {
                string listAlunosCMB = "select prof_nome from tb_professores";
                var returnDataSet = professoresDAL.dataSet(listAlunosCMB);
                this.cmbNomeProfessor.DisplayMember = "prof_nome";
                this.cmbNomeProfessor.ValueMember = "prof_id";
                this.cmbNomeProfessor.DataSource = returnDataSet.Tables["tb_professores"];


                string listProfessores = "select prof_nome, prof_datanasc,prof_cpf,prof_telefone,prof_salario from tb_professores";
                var returnDataTable = professoresDAL.dataTable(listProfessores);
                dgvProfessores.DataSource = returnDataTable;
                dgvProfessores.Columns["prof_nome"].HeaderText = "Aluno";
                dgvProfessores.Columns["prof_datanasc"].HeaderText = "Data Nascimento";
                dgvProfessores.Columns["prof_cpf"].HeaderText = "CPF";
                dgvProfessores.Columns["prof_telefone"].HeaderText = "Telefone";
                dgvProfessores.Columns["prof_salario"].HeaderText = "Salário";
                dgvProfessores.Columns[4].DefaultCellStyle.Format = "c2";
                dgvProfessores.Columns[4].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);

            }
        }

        private void dgvProfessores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvProfessores.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
            dgvProfessores.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir";
        }

        private void dgvProfessores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            ProfessoresDAL professoresDAL = new ProfessoresDAL(new MySqlConnection(connectionString));
            if (dgvProfessores.Columns[e.ColumnIndex] == dgvProfessores.Columns["editar"])
            {
                string nomeProfessor = dgvProfessores.Rows[e.RowIndex].Cells["prof_nome"].Value.ToString();

                formEditarProfessores formEditar = new formEditarProfessores(nomeProfessor, this);
                formEditar.Show();

                //formEdita editarAlunos = new formEditarAlunos(nomeProfessor, this);
                //editarAlunos.Show();

            }
            if (dgvProfessores.Columns[e.ColumnIndex] == dgvProfessores.Columns["excluir"])
            {
                string nomeProfessor = dgvProfessores.Rows[e.RowIndex].Cells["prof_nome"].Value.ToString();
                if (MessageBox.Show("Deseja deletar o Professor", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    professoresDAL.DeletarProfessor(nomeProfessor);

                }
                formConsultarProfessores_Load(sender, e);

            }
        }
    }
}
