using MySql.Data.MySqlClient;
using Sistema_Sinapse.Class;
using Sistema_Sinapse.View.Professores;
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

namespace Sistema_Sinapse.View.Opcoes_Contratos.Opcoes
{
    public partial class formConsultarOpcoes : Form
    {
        public formConsultarOpcoes()
        {
            InitializeComponent();
        }

        private void formConsultarOpcoes_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            OpcoesAulaDAL opcoesDAL = new OpcoesAulaDAL(new MySqlConnection(connectionString));

            try
            {

                string listOpcoes = "select opc_descricao, opc_duracao from tb_opcoes";
                var returnDataTable = opcoesDAL.dataTable(listOpcoes);
                dgvOpcoes.DataSource = returnDataTable;
                dgvOpcoes.Columns["opc_descricao"].HeaderText = "Descricao";
                dgvOpcoes.Columns["opc_duracao"].HeaderText = "Duração";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);

            }
        }
        public void AtualizarDataGrid()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            OpcoesAulaDAL opcoesDAL = new OpcoesAulaDAL(new MySqlConnection(connectionString));

            try
            {

                string listOpcoes = "select opc_descricao, opc_duracao from tb_opcoes";
                var returnDataTable = opcoesDAL.dataTable(listOpcoes);
                dgvOpcoes.DataSource = returnDataTable;
                dgvOpcoes.Columns["opc_descricao"].HeaderText = "Descricao";
                dgvOpcoes.Columns["opc_duracao"].HeaderText = "Duração";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);

            }
        }

        private void dgvOpcoes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            OpcoesAulaDAL opcoesDAL = new OpcoesAulaDAL(new MySqlConnection(connectionString));
            if (dgvOpcoes.Columns[e.ColumnIndex] == dgvOpcoes.Columns["editar"])
            {
                string nomeOpcao = dgvOpcoes.Rows[e.RowIndex].Cells["opc_descricao"].Value.ToString();
                formEditarOpcoes formConsultar = new formEditarOpcoes(nomeOpcao,this);
                formConsultar.Show();
            }
            if (dgvOpcoes.Columns[e.ColumnIndex] == dgvOpcoes.Columns["excluir"])
            {
                string nomeOpcao = dgvOpcoes.Rows[e.RowIndex].Cells["opc_descricao"].Value.ToString();
                if (MessageBox.Show("Deseja deletar o Professor", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        opcoesDAL.DeletarOpcao(nomeOpcao);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                   

                }
                formConsultarOpcoes_Load(sender, e);

            }
        }

        private void dgvOpcoes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvOpcoes.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
            dgvOpcoes.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir";
        }
    }
}
