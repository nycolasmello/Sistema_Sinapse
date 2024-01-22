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


                string listAlunos = "select alu_nome,alu_datanasc,alu_cpf,id_alu_turma,alu_responsavel,alu_telefoneResp,alu_valorMensalidade,alu_statusAluno from tb_alunos";
                var returnDataTable = alunosDAL.dataTable(listAlunos);
                dgvAlunos.DataSource= returnDataTable;
                dgvAlunos.Columns["alu_nome"].HeaderText = "Aluno";
                dgvAlunos.Columns["alu_datanasc"].HeaderText = "Data Nascimento";
                dgvAlunos.Columns["alu_cpf"].HeaderText = "CPF Aluno";
                dgvAlunos.Columns["id_alu_turma"].HeaderText = "Turma";
                dgvAlunos.Columns["alu_responsavel"].HeaderText = "Responsavel";
                dgvAlunos.Columns["alu_telefoneResp"].HeaderText = "Telefone do Responsável";
                dgvAlunos.Columns["alu_valorMensalidade"].HeaderText = "Mensalidade";
                dgvAlunos.Columns["alu_statusAluno"].HeaderText = "Status Aluno";
                dgvAlunos.Columns[6].DefaultCellStyle.Format = "c2";
                dgvAlunos.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro:" + ex);

            }
        }
    }
}
