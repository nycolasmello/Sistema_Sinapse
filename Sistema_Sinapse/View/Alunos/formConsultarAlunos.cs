using MySql.Data.MySqlClient;
using Sistema_Sinapse.Class;
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
    public partial class formConsultarAlunos : Form
    {
        public formConsultarAlunos()
        {
            InitializeComponent();
        }

        private void formConsultarAlunos_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            AlunosDAL alunosDAL = new AlunosDAL(new MySqlConnection(connectionString));

            try
            {
                string listAlunosCMB = "select alu_nome from tb_alunos";
                var returnDataSet = alunosDAL.dataSet(listAlunosCMB);
                this.cmbNomeAluno.DisplayMember = "alu_nome";
                this.cmbNomeAluno.ValueMember = "alu_id";
                this.cmbNomeAluno.DataSource = returnDataSet.Tables["tb_alunos"];


                string listAlunos = "select alu_nome,alu_datanasc,alu_cpf,tur_nome,alu_responsavel,alu_telefoneResp,alu_valorMensalidade,alu_statusAluno from tb_alunos,tb_turmas WHERE tur_id = id_alu_turma";
                var returnDataTable = alunosDAL.dataTable(listAlunos);
                dgvAlunos.DataSource = returnDataTable;
                dgvAlunos.Columns["alu_nome"].HeaderText = "Aluno";
                dgvAlunos.Columns["alu_datanasc"].HeaderText = "Data Nascimento";
                dgvAlunos.Columns["alu_cpf"].HeaderText = "CPF Aluno";
                dgvAlunos.Columns["tur_nome"].HeaderText = "Turma";
                dgvAlunos.Columns["alu_responsavel"].HeaderText = "Responsavel";
                dgvAlunos.Columns["alu_telefoneResp"].HeaderText = "Telefone do Responsável";
                dgvAlunos.Columns["alu_valorMensalidade"].HeaderText = "Mensalidade";
                dgvAlunos.Columns["alu_statusAluno"].HeaderText = "Status Aluno";
                dgvAlunos.Columns[6].DefaultCellStyle.Format = "c2";
                dgvAlunos.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);

            }
        }

        private void dgvAlunos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvAlunos.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
            dgvAlunos.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir";
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            AlunosDAL alunosDAL = new AlunosDAL(new MySqlConnection(connectionString));
            if (dgvAlunos.Columns[e.ColumnIndex] == dgvAlunos.Columns["editar"])
            {
                string nomeAluno = dgvAlunos.Rows[e.RowIndex].Cells["alu_nome"].Value.ToString();
                formEditarAlunos editarAlunos = new formEditarAlunos(nomeAluno);
                editarAlunos.Show();
            }
            if (dgvAlunos.Columns[e.ColumnIndex] == dgvAlunos.Columns["excluir"])
            {
                string nomeAluno = dgvAlunos.Rows[e.RowIndex].Cells["alu_nome"].Value.ToString();
                if (MessageBox.Show("Deseja deletar o Aluno", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    alunosDAL.DeletarAluno(nomeAluno);                                    

                }
                formConsultarAlunos_Load(sender, e);

            }
        }
    }
}
