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

namespace Sistema_Sinapse.View
{
    public partial class formCadastrarTurma : Form
    {
        public formCadastrarTurma()
        {
            InitializeComponent();
        }

        private void formCadastrarTurma_Load(object sender, EventArgs e)
        {

            dataIncial.Format = DateTimePickerFormat.Custom;
            dataIncial.CustomFormat = "dd/MM/yyyy";

            dataFinal.Format = DateTimePickerFormat.Custom;
            dataFinal.CustomFormat = "dd/MM/yyyy";

            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
           ProfessoresDAL professoresDAL = new ProfessoresDAL(new MySqlConnection(connectionString));

            string listProfessores = "select prof_nome from tb_professores";
            var returnDataSet = professoresDAL.dataSet(listProfessores);
            this.cmbProfessores.DisplayMember = "prof_nome";
            this.cmbProfessores.ValueMember = "prof_id";
            this.cmbProfessores.DataSource = returnDataSet.Tables["tb_professores"];
        }

        private void listaSemana_Click(object sender, EventArgs e)
        {
            
        }

        private void listaSemana_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void registrarTurma_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            ProfessoresDAL professoresDAL = new ProfessoresDAL(new MySqlConnection(connectionString));
            TurmasDAL turmasDAL = new TurmasDAL(new MySqlConnection(connectionString));

            List<string> valoresMarcados = new List<string>();

            // Percorre os itens da CheckedListBox
            for (int i = 0; i < listaSemana.Items.Count; i++)
            {
                // Verifica se o item está marcado
                if (listaSemana.GetItemChecked(i))
                {
                    // Adiciona o valor do item à lista de valores marcados
                    valoresMarcados.Add(listaSemana.Items[i].ToString());
                }
            }

            // Exibe os valores marcados (você pode fazer o que quiser com eles)
            var diaSemana = string.Join(",", valoresMarcados);
            int idProfessor = professoresDAL.obterIdPeloNome(cmbProfessores.Text);
            var DataInicial = dataIncial.Value;
            var DataFinal = dataFinal.Value;
            try
            {
                Turmas turmas = new Turmas(
                    txtNomeTurma.Text,
                    idProfessor,
                    DataInicial,
                    DataFinal,
                    diaSemana
                    );
                turmasDAL.registrarTurma(turmas);
                MessageBox.Show("Turma Registrada");
                txtNomeTurma.Text = "";
                cmbProfessores.Text = "";
                txtNomeTurma.Select();
                txtNomeTurma.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
    }
}
