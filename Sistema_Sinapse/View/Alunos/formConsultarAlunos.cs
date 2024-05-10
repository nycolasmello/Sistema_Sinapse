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


                string listAlunos = "SELECT alu.alu_nome AS Nome_Aluno,alu.alu_responsavel AS Responsavel_Aluno,tur.tur_nome AS Nome_Turma,op.opc_descricao AS Descricao_Opcao,op.opc_duracao AS Duracao_Opcao,val.val_periodo AS Periodo_Valor,val.val_valor AS Valor_Aula, alu.alu_DataRegistro AS Data_Registro FROM tb_alunos alu INNER JOIN tb_turmas tur ON alu.id_alu_turma = tur.tur_id INNER JOIN tb_opcoes op ON alu.id_alu_opcao = op.opc_id INNER JOIN tb_valoresaula val ON alu.id_alu_opcao = val.val_id_opcao";
                var returnDataTable = alunosDAL.dataTable(listAlunos);
                dgvAlunos.DataSource = returnDataTable;
                dgvAlunos.Columns["Nome_Aluno"].HeaderText = "Aluno";
                dgvAlunos.Columns["Responsavel_Aluno"].HeaderText = "Responsavel";
                dgvAlunos.Columns["Nome_Turma"].HeaderText = "Turma";
                dgvAlunos.Columns["Descricao_Opcao"].HeaderText = "Descricao";
                dgvAlunos.Columns["Duracao_Opcao"].HeaderText = "Duracao";
                dgvAlunos.Columns["Periodo_Valor"].HeaderText = "Metodo de pagamento";
                dgvAlunos.Columns["Valor_Aula"].HeaderText = "Valor";
                dgvAlunos.Columns["Data_Registro"].HeaderText = "Data de Registro";
                dgvAlunos.Columns[9].DefaultCellStyle.Format = "c2";
                dgvAlunos.Columns[9].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
                var dataColumn = dgvAlunos.Columns["Data_Registro"];
                dataColumn.DefaultCellStyle.Format = "dd/MM/yyyy";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);

            }
        }
        public void ReloadForm()
        {
            this.OnLoad(EventArgs.Empty);
        }

        private void dgvAlunos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvAlunos.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
            dgvAlunos.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir";
            dgvAlunos.Rows[e.RowIndex].Cells["historico"].ToolTipText = "Clique aqui para visualizar o histórico de pagamento";
        }
        public void AtualizarDataGridView()
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


                string listAlunos = "SELECT alu.alu_nome AS Nome_Aluno,alu.alu_responsavel AS Responsavel_Aluno,tur.tur_nome AS Nome_Turma,op.opc_descricao AS Descricao_Opcao,op.opc_duracao AS Duracao_Opcao,val.val_periodo AS Periodo_Valor,val.val_valor AS Valor_Aula,alu.alu_DataRegistro AS Data_Registro FROM tb_alunos alu INNER JOIN tb_turmas tur ON alu.id_alu_turma = tur.tur_id INNER JOIN tb_opcoes op ON alu.id_alu_opcao = op.opc_id INNER JOIN tb_valoresaula val ON alu.id_alu_opcao = val.val_id_opcao";
                var returnDataTable = alunosDAL.dataTable(listAlunos);
                dgvAlunos.DataSource = returnDataTable;
                dgvAlunos.Columns["Nome_Aluno"].HeaderText = "Aluno";
                dgvAlunos.Columns["Responsavel_Aluno"].HeaderText = "Responsavel";
                dgvAlunos.Columns["Nome_Turma"].HeaderText = "Turma";
                dgvAlunos.Columns["Descricao_Opcao"].HeaderText = "Descricao";
                dgvAlunos.Columns["Duracao_Opcao"].HeaderText = "Duracao";
                dgvAlunos.Columns["Periodo_Valor"].HeaderText = "Metodo de pagamento";
                dgvAlunos.Columns["Valor_Aula"].HeaderText = "Valor";
                dgvAlunos.Columns["Data_Registro"].HeaderText = "Data de Registro";
                dgvAlunos.Columns[9].DefaultCellStyle.Format = "c2";
                dgvAlunos.Columns[9].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);

            }
        }

        private void dgvAlunos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            AlunosDAL alunosDAL = new AlunosDAL(new MySqlConnection(connectionString));
            if (dgvAlunos.Columns[e.ColumnIndex] == dgvAlunos.Columns["editar"])
            {
                string nomeAluno = dgvAlunos.Rows[e.RowIndex].Cells["Nome_Aluno"].Value.ToString();
                
                formEditarAlunos editarAlunos = new formEditarAlunos(nomeAluno,this);
                editarAlunos.Show();
                
            }
            if (dgvAlunos.Columns[e.ColumnIndex] == dgvAlunos.Columns["excluir"])
            {
                string nomeAluno = dgvAlunos.Rows[e.RowIndex].Cells["Nome_Aluno"].Value.ToString();
                if (MessageBox.Show("Deseja deletar o Aluno", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    alunosDAL.DeletarAluno(nomeAluno);                                    

                }
                formConsultarAlunos_Load(sender, e);

            }
            if (dgvAlunos.Columns[e.ColumnIndex] == dgvAlunos.Columns["historico"])
            {
                string nomeAluno = dgvAlunos.Rows[e.RowIndex].Cells["Nome_Aluno"].Value.ToString();
                -

            }
        }
    }
}
