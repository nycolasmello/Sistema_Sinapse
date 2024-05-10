using Sistema_Sinapse.View;
using Sistema_Sinapse.View.Alunos;
using Sistema_Sinapse.View.Opcoes_Contratos;
using Sistema_Sinapse.View.Opcoes_Contratos.Opcoes;
using Sistema_Sinapse.View.Opcoes_Contratos.Valores;
using Sistema_Sinapse.View.Professores;
using Sistema_Sinapse.View.Turmas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Sinapse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formCadastrarAluno formCadastrarA = new formCadastrarAluno();
            formCadastrarA.Show();
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formCadastrarProfessor cadastrarProfessor = new formCadastrarProfessor();
            cadastrarProfessor.Show();
        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            formCadastrarTurma cadastrarTurma = new formCadastrarTurma();
            cadastrarTurma.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formConsultarAlunos consultarAlunos = new formConsultarAlunos();
            consultarAlunos.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formConsultarProfessores formConsultar = new formConsultarProfessores();
            formConsultar.Show();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formConsultarTurmas formConsultar = new formConsultarTurmas();
            formConsultar.Show();
        }

        private void registrarOpçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRegistrarOpcoes formRegistrar = new formRegistrarOpcoes();
            formRegistrar.Show();
        }

        private void consultarOpçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formConsultarOpcoes formConsultar = new formConsultarOpcoes();
            formConsultar.Show();
        }

        private void registrarValoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formRegistrarValores formRegistrar = new formRegistrarValores();
            formRegistrar.Show();
        }

        private void consultarValoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formConsultarValores formConsultar = new formConsultarValores();
            formConsultar.Show();
        }
    }
}
