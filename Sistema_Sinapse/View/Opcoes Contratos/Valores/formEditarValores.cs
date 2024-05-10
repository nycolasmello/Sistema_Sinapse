using MySql.Data.MySqlClient;
using Sistema_Sinapse.Class;
using Sistema_Sinapse.Model;
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
    public partial class formEditarValores : Form
    {
        private formConsultarValores formConsultar1;
        private int valIdOpcao;
        public formEditarValores(string nome, formConsultarValores formConsultar, int idOpcao)
        {
            InitializeComponent();
            formConsultar1= formConsultar;
            lblPeriodo.Text = nome;
            valIdOpcao = idOpcao;
        }

        private void formEditarValores_Load(object sender, EventArgs e)
        {
            lblPeriodo.Visible = false;
            lblidPeriodo.Visible = false;
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            ValoresDAL valoresDAL = new ValoresDAL(new MySqlConnection(connectionString));
            OpcoesAulaDAL opcoesDAL = new OpcoesAulaDAL(new MySqlConnection(connectionString));
            txtPeriodo.Text = lblPeriodo.Text;


            try
            {

                string listOpcoes = "select val_periodo, val_valor,opc_descricao from tb_valoresaula,tb_opcoes where opc_id = val_id_opcao";
                var returnDataTable = valoresDAL.dataTable(listOpcoes);
                dgvValores.DataSource = returnDataTable;
                dgvValores.Columns["val_periodo"].HeaderText = "Período";
                dgvValores.Columns["val_valor"].HeaderText = "Valor";
                dgvValores.Columns["opc_descricao"].HeaderText = "Opção";
                dgvValores.Columns[1].DefaultCellStyle.Format = "c2";
                dgvValores.Columns[1].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("pt-BR");

                MySqlConnection conn = new MySqlConnection(connectionString);
                conn.Open();
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tb_valoresaula where val_periodo = '" + lblPeriodo.Text + "' and val_id_opcao = '"+ valIdOpcao + "'";
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                txtPeriodo.Text = reader.GetString(1);
                decimal valor = reader.GetDecimal(2);
                txtValor.Text = Convert.ToString(valor);

                //ComboBox Opcoes
                string query = "select opc_descricao from tb_opcoes";
                var returDataSet = opcoesDAL.dataSet(query);
                this.cmbOpcao.DisplayMember = "opc_descricao";
                this.cmbOpcao.ValueMember = "opc_id";
                this.cmbOpcao.DataSource = returDataSet.Tables["tb_opcoes"];
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);

            }

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            OpcoesAulaDAL opcoesDAL = new OpcoesAulaDAL(new MySqlConnection(connectionString));
            ValoresDAL valoresDAL = new ValoresDAL(new MySqlConnection(connectionString));
            //periodo/valor/idopcao
            
            int idOpcao = opcoesDAL.obterIDPeloNome(cmbOpcao.Text);            
            decimal valor = Convert.ToDecimal(txtValor.Text);

            try
            {
                Valores1 valores1 = new Valores1(
                    txtPeriodo.Text,
                    valor,
                    idOpcao
                    );
                valoresDAL.AlterarValor(valores1,txtPeriodo.Text,idOpcao);
                MessageBox.Show("Dados alterados com sucesso!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
