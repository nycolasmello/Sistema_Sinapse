using MySql.Data.MySqlClient;
using Sistema_Sinapse.Class;
using Sistema_Sinapse.View.Opcoes_Contratos.Opcoes;
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

namespace Sistema_Sinapse.View.Opcoes_Contratos.Valores
{
    public partial class formConsultarValores : Form
    {
        public formConsultarValores()
        {
            InitializeComponent();
        }

        private void formConsultarValores_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            ValoresDAL valoresDAL = new ValoresDAL(new MySqlConnection(connectionString));

            try
            {

                string listOpcoes = "select val_periodo, val_valor,opc_descricao from tb_valoresaula,tb_opcoes where opc_id = val_id_opcao";
                var returnDataTable = valoresDAL.dataTable(listOpcoes);
                dgvValores.DataSource = returnDataTable;
                dgvValores.Columns["val_periodo"].HeaderText = "Período";
                dgvValores.Columns["val_valor"].HeaderText = "Valor";
                dgvValores.Columns["opc_descricao"].HeaderText = "Opção";
                dgvValores.Columns[3].DefaultCellStyle.Format = "c2";
                dgvValores.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);

            }
        }

        private void dgvValores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            ValoresDAL valoresDAL = new ValoresDAL(new MySqlConnection(connectionString));
            OpcoesAulaDAL opcoesDAL= new OpcoesAulaDAL(new MySqlConnection(connectionString));
            if (dgvValores.Columns[e.ColumnIndex] == dgvValores.Columns["editar"])
            {
                string periodo = dgvValores.Rows[e.RowIndex].Cells["val_periodo"].Value.ToString();
                string nomeOpcao = dgvValores.Rows[e.RowIndex].Cells["opc_descricao"].Value.ToString();
                int idOpcao = opcoesDAL.obterIDPeloNome(nomeOpcao);
                formEditarValores formEditar = new formEditarValores(periodo, this, idOpcao);
                formEditar.Show();
            }
            if (dgvValores.Columns[e.ColumnIndex] == dgvValores.Columns["excluir"])
            {
                string periodo = dgvValores.Rows[e.RowIndex].Cells["val_periodo"].Value.ToString();
                string nomeOpcao = dgvValores.Rows[e.RowIndex].Cells["opc_descricao"].Value.ToString();
                int idOpcao = opcoesDAL.obterIDPeloNome(nomeOpcao);

                if (MessageBox.Show("Deseja deletar", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    valoresDAL.DeletarOpcao(periodo, idOpcao);

                }
                formConsultarValores_Load(sender, e);

            }

        }

        private void dgvValores_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            dgvValores.Rows[e.RowIndex].Cells["editar"].ToolTipText = "Clique aqui para editar";
            dgvValores.Rows[e.RowIndex].Cells["excluir"].ToolTipText = "Clique aqui para excluir";
        }
    }
}
