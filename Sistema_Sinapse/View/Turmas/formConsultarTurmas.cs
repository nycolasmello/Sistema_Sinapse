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

namespace Sistema_Sinapse.View.Turmas
{
    public partial class formConsultarTurmas : Form
    {
        public formConsultarTurmas()
        {
            InitializeComponent();
        }

        private void formConsultarTurmas_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["conexaoBD"].ConnectionString;
            TurmasDAL turmasDAL = new TurmasDAL(new MySqlConnection(connectionString));

            try
            {
                string listNomeTurmas = "select tur_nome from tb_turmas";
                var returnDataSet = turmasDAL.dataSet(listNomeTurmas);
                this.cmbNomeTurma.DisplayMember = "tur_nome";
                this.cmbNomeTurma.ValueMember = "tur_id";
                this.cmbNomeTurma.DataSource = returnDataSet.Tables["tb_turmas"];


                string listTurmas = "select tur_nome,prof_nome,tur_horarioInicial,tur_horarioFinal,tur_diaSemana from tb_turmas,tb_professores where tur_id_professor=prof_id";
                var returnDataTable = turmasDAL.dataTable(listTurmas);
                dgvTurmas.DataSource = returnDataTable;
                dgvTurmas.Columns["tur_nome"].HeaderText = "Turma";
                dgvTurmas.Columns["prof_nome"].HeaderText = "Professor Responsável";
                dgvTurmas.Columns["tur_horarioInicial"].HeaderText = "Horário Inicial";
                dgvTurmas.Columns["tur_horarioFinal"].HeaderText = "Horário Final";
                dgvTurmas.Columns["tur_diaSemana"].HeaderText = "Dia da semana";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex);

            }
        }
    }
}
