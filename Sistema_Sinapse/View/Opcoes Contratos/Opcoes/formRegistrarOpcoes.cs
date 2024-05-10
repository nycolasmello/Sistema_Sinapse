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

namespace Sistema_Sinapse.View.Opcoes_Contratos
{
    public partial class formRegistrarOpcoes : Form
    {
        public formRegistrarOpcoes()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int limiteCaracteres = 5;
            // Verifica se o comprimento atual excede o limite
            if (textBox2.Text.Length >= limiteCaracteres && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Impede a entrada de caracteres adicionais
            }
            // Verifica se o caractere é numérico ou :
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':')
            {
                e.Handled = true; // Ignora o caractere se não for um número ou :
            }

            // Adiciona a barra automaticamente na posição correta
            if (char.IsDigit(e.KeyChar) && (textBox2.SelectionStart == 2))
            {
                textBox2.Text += ":";
                textBox2.SelectionStart = textBox2.Text.Length; // Move o cursor para o final
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            OpcoesAulaDAL opcoesDAL = new OpcoesAulaDAL(new MySqlConnection(connectionString));
            try
            {
                OpcoesAula1 opcoesAula1opcoesAula1 = new  OpcoesAula1(
                    txtDescricaoAula.Text,
                    textBox2.Text
                    );
                opcoesDAL.registrarOpcao(opcoesAula1opcoesAula1);
                MessageBox.Show("Registrado");
                txtDescricaoAula.Text = "";
                textBox2.Text = "";
                txtDescricaoAula.Select();
                txtDescricaoAula.Focus();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
