using Sistema_Sinapse.View;
using Sistema_Sinapse.View.Alunos;
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
    }
}
