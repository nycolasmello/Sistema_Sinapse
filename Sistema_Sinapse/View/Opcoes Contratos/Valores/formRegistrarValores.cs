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

namespace Sistema_Sinapse.View.Opcoes_Contratos.Valores
{
    public partial class formRegistrarValores : Form
    {
        public formRegistrarValores()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            ValoresDAL valoresDAL = new ValoresDAL(new MySqlConnection(connectionString));
            OpcoesAulaDAL opcoesDAL = new OpcoesAulaDAL(new MySqlConnection(connectionString));
            try
            {
                int idOpcao = opcoesDAL.obterIDPeloNome(cmbOpcao.Text);
                decimal valor =  Convert.ToDecimal(txtValor.Text);
                Valores1 opcoesAula1opcoesAula1 = new Valores1(
                    txtPeriodo.Text,
                    valor,
                    idOpcao
                    );
                valoresDAL.RegistrarValor(opcoesAula1opcoesAula1);
                MessageBox.Show("Registrado");
                txtPeriodo.Text = "";
                txtValor.Text = "";
                txtPeriodo.Select();
                txtPeriodo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void formRegistrarValores_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            OpcoesAulaDAL opcoesDAL = new OpcoesAulaDAL(new MySqlConnection(connectionString));
            string query = "select opc_descricao from tb_opcoes";
            var returDataSet = opcoesDAL.dataSet(query);
            this.cmbOpcao.DisplayMember = "opc_descricao";
            this.cmbOpcao.ValueMember = "opc_id";
            this.cmbOpcao.DataSource = returDataSet.Tables["tb_opcoes"];

        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnRegistrar_Click(sender, e);
            }
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = '.';

                //Verifica se já existe alguma vírgula na string
                if (txtValor.Text.Contains("."))
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
