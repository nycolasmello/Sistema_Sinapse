using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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

namespace Sistema_Sinapse.View
{
    public partial class formCadastrarProfessor : Form
    {
        public formCadastrarProfessor()
        {
            InitializeComponent();
        }

        private void btnRegistrarProf_Click(object sender, EventArgs e)
        {
            var Salario = Convert.ToDecimal(txtSalario.Text);
            var Data = dataNascimento.Value;
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            ProfessoresDAL professoresDAL = new ProfessoresDAL(new MySqlConnection(connectionString));
            try
            {
                Professores professores = new Professores(
                    txtNome.Text,
                    Data,
                    txtCpf.Text,
                    txtTelefone.Text,
                    Salario
                    );
                professoresDAL.Inserir(professores);
                MessageBox.Show("Professor Registrado");
                txtNome.Text = "";
                dataNascimento.Text = "";
                txtCpf.Text = "";
                txtTelefone.Text = "";
                txtSalario.Text = "";
                txtTelefone.Select();
                txtNome.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void formCadastrarProfessor_Load(object sender, EventArgs e)
        {

        }
    }
}
