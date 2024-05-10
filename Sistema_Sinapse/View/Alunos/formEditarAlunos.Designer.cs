namespace Sistema_Sinapse.View.Alunos
{
    partial class formEditarAlunos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEditarAlunos));
            this.label12 = new System.Windows.Forms.Label();
            this.cmbOpcoes = new System.Windows.Forms.ComboBox();
            this.txtRgResponsavel = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRgAluno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarAluno = new System.Windows.Forms.Button();
            this.cmbStatusAluno = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCpfResponsavel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefoneResponsavel = new System.Windows.Forms.TextBox();
            this.txtNomeResponsavel = new System.Windows.Forms.TextBox();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.txtCpfAluno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeAluno = new System.Windows.Forms.TextBox();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.dataRegistro = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 323);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 13);
            this.label12.TabIndex = 63;
            this.label12.Text = "Opcao Desejada";
            // 
            // cmbOpcoes
            // 
            this.cmbOpcoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcoes.FormattingEnabled = true;
            this.cmbOpcoes.Location = new System.Drawing.Point(14, 339);
            this.cmbOpcoes.Name = "cmbOpcoes";
            this.cmbOpcoes.Size = new System.Drawing.Size(327, 21);
            this.cmbOpcoes.TabIndex = 62;
            // 
            // txtRgResponsavel
            // 
            this.txtRgResponsavel.Location = new System.Drawing.Point(194, 189);
            this.txtRgResponsavel.Name = "txtRgResponsavel";
            this.txtRgResponsavel.Size = new System.Drawing.Size(147, 20);
            this.txtRgResponsavel.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "RG Responsável";
            // 
            // txtRgAluno
            // 
            this.txtRgAluno.Location = new System.Drawing.Point(12, 189);
            this.txtRgAluno.Name = "txtRgAluno";
            this.txtRgAluno.Size = new System.Drawing.Size(147, 20);
            this.txtRgAluno.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 13);
            this.label10.TabIndex = 58;
            this.label10.Text = "RG";
            // 
            // dataNascimento
            // 
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(12, 88);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(147, 20);
            this.dataNascimento.TabIndex = 57;
            // 
            // btnRegistrarAluno
            // 
            this.btnRegistrarAluno.Location = new System.Drawing.Point(122, 378);
            this.btnRegistrarAluno.Name = "btnRegistrarAluno";
            this.btnRegistrarAluno.Size = new System.Drawing.Size(134, 29);
            this.btnRegistrarAluno.TabIndex = 56;
            this.btnRegistrarAluno.Text = "Realizar cadastro";
            this.btnRegistrarAluno.UseVisualStyleBackColor = true;
            this.btnRegistrarAluno.Click += new System.EventHandler(this.btnRegistrarAluno_Click_1);
            // 
            // cmbStatusAluno
            // 
            this.cmbStatusAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusAluno.FormattingEnabled = true;
            this.cmbStatusAluno.Items.AddRange(new object[] {
            "ATIVO",
            "NÃO ATIVO"});
            this.cmbStatusAluno.Location = new System.Drawing.Point(192, 240);
            this.cmbStatusAluno.Name = "cmbStatusAluno";
            this.cmbStatusAluno.Size = new System.Drawing.Size(147, 21);
            this.cmbStatusAluno.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(192, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Status do Aluno";
            // 
            // txtCpfResponsavel
            // 
            this.txtCpfResponsavel.Location = new System.Drawing.Point(194, 138);
            this.txtCpfResponsavel.Name = "txtCpfResponsavel";
            this.txtCpfResponsavel.Size = new System.Drawing.Size(147, 20);
            this.txtCpfResponsavel.TabIndex = 53;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 122);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "CPF Responsável";
            // 
            // txtTelefoneResponsavel
            // 
            this.txtTelefoneResponsavel.Location = new System.Drawing.Point(194, 88);
            this.txtTelefoneResponsavel.Name = "txtTelefoneResponsavel";
            this.txtTelefoneResponsavel.Size = new System.Drawing.Size(147, 20);
            this.txtTelefoneResponsavel.TabIndex = 51;
            // 
            // txtNomeResponsavel
            // 
            this.txtNomeResponsavel.Location = new System.Drawing.Point(194, 39);
            this.txtNomeResponsavel.Name = "txtNomeResponsavel";
            this.txtNomeResponsavel.Size = new System.Drawing.Size(147, 20);
            this.txtNomeResponsavel.TabIndex = 50;
            // 
            // cmbTurma
            // 
            this.cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(9, 240);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(147, 21);
            this.cmbTurma.TabIndex = 49;
            // 
            // txtCpfAluno
            // 
            this.txtCpfAluno.Location = new System.Drawing.Point(12, 138);
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.Size = new System.Drawing.Size(147, 20);
            this.txtCpfAluno.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Telefone Responsável";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Nome do Responsável";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Turma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Data de nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Nome do Aluno";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(12, 39);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(147, 20);
            this.txtNomeAluno.TabIndex = 41;
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(281, 397);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(72, 13);
            this.lblNomeAluno.TabIndex = 64;
            this.lblNomeAluno.Text = "lblNomeAluno";
            // 
            // dataRegistro
            // 
            this.dataRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataRegistro.Location = new System.Drawing.Point(12, 291);
            this.dataRegistro.Name = "dataRegistro";
            this.dataRegistro.Size = new System.Drawing.Size(147, 20);
            this.dataRegistro.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Data de registro";
            // 
            // formEditarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 419);
            this.Controls.Add(this.dataRegistro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbOpcoes);
            this.Controls.Add(this.txtRgResponsavel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRgAluno);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.btnRegistrarAluno);
            this.Controls.Add(this.cmbStatusAluno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCpfResponsavel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefoneResponsavel);
            this.Controls.Add(this.txtNomeResponsavel);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.txtCpfAluno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeAluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formEditarAlunos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Aluno";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formEditarAlunos_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formEditarAlunos_FormClosed);
            this.Load += new System.EventHandler(this.formEditarAlunos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbOpcoes;
        private System.Windows.Forms.TextBox txtRgResponsavel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRgAluno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.Button btnRegistrarAluno;
        private System.Windows.Forms.ComboBox cmbStatusAluno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCpfResponsavel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefoneResponsavel;
        private System.Windows.Forms.TextBox txtNomeResponsavel;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.TextBox txtCpfAluno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeAluno;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.DateTimePicker dataRegistro;
        private System.Windows.Forms.Label label8;
    }
}