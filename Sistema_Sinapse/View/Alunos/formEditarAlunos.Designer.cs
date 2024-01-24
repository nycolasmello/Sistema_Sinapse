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
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.btnRegistrarAluno = new System.Windows.Forms.Button();
            this.cmbStatusAluno = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorMensalidade = new System.Windows.Forms.TextBox();
            this.txtCpfResponsavel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.SuspendLayout();
            // 
            // dataNascimento
            // 
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(24, 86);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(147, 20);
            this.dataNascimento.TabIndex = 38;
            // 
            // btnRegistrarAluno
            // 
            this.btnRegistrarAluno.Location = new System.Drawing.Point(138, 281);
            this.btnRegistrarAluno.Name = "btnRegistrarAluno";
            this.btnRegistrarAluno.Size = new System.Drawing.Size(134, 29);
            this.btnRegistrarAluno.TabIndex = 37;
            this.btnRegistrarAluno.Text = "Salvar";
            this.btnRegistrarAluno.UseVisualStyleBackColor = true;
            this.btnRegistrarAluno.Click += new System.EventHandler(this.btnRegistrarAluno_Click);
            // 
            // cmbStatusAluno
            // 
            this.cmbStatusAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusAluno.FormattingEnabled = true;
            this.cmbStatusAluno.Items.AddRange(new object[] {
            "ATIVO",
            "NÃO ATIVO"});
            this.cmbStatusAluno.Location = new System.Drawing.Point(21, 243);
            this.cmbStatusAluno.Name = "cmbStatusAluno";
            this.cmbStatusAluno.Size = new System.Drawing.Size(147, 21);
            this.cmbStatusAluno.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Status do Aluno";
            // 
            // txtValorMensalidade
            // 
            this.txtValorMensalidade.Location = new System.Drawing.Point(207, 187);
            this.txtValorMensalidade.Name = "txtValorMensalidade";
            this.txtValorMensalidade.Size = new System.Drawing.Size(147, 20);
            this.txtValorMensalidade.TabIndex = 34;
            this.txtValorMensalidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorMensalidade_KeyPress);
            // 
            // txtCpfResponsavel
            // 
            this.txtCpfResponsavel.Location = new System.Drawing.Point(206, 136);
            this.txtCpfResponsavel.Name = "txtCpfResponsavel";
            this.txtCpfResponsavel.Size = new System.Drawing.Size(147, 20);
            this.txtCpfResponsavel.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(204, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Valor Mensalidade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "CPF Responsável";
            // 
            // txtTelefoneResponsavel
            // 
            this.txtTelefoneResponsavel.Location = new System.Drawing.Point(206, 86);
            this.txtTelefoneResponsavel.Name = "txtTelefoneResponsavel";
            this.txtTelefoneResponsavel.Size = new System.Drawing.Size(147, 20);
            this.txtTelefoneResponsavel.TabIndex = 30;
            // 
            // txtNomeResponsavel
            // 
            this.txtNomeResponsavel.Location = new System.Drawing.Point(206, 37);
            this.txtNomeResponsavel.Name = "txtNomeResponsavel";
            this.txtNomeResponsavel.Size = new System.Drawing.Size(147, 20);
            this.txtNomeResponsavel.TabIndex = 29;
            // 
            // cmbTurma
            // 
            this.cmbTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(21, 186);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(147, 21);
            this.cmbTurma.TabIndex = 28;
            // 
            // txtCpfAluno
            // 
            this.txtCpfAluno.Location = new System.Drawing.Point(24, 136);
            this.txtCpfAluno.Name = "txtCpfAluno";
            this.txtCpfAluno.Size = new System.Drawing.Size(147, 20);
            this.txtCpfAluno.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Telefone Responsável";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Nome do Responsável";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Turma";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "CPF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Data de nascimento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome do Aluno";
            // 
            // txtNomeAluno
            // 
            this.txtNomeAluno.Location = new System.Drawing.Point(24, 37);
            this.txtNomeAluno.Name = "txtNomeAluno";
            this.txtNomeAluno.Size = new System.Drawing.Size(147, 20);
            this.txtNomeAluno.TabIndex = 20;
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(204, 227);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(72, 13);
            this.lblNomeAluno.TabIndex = 39;
            this.lblNomeAluno.Text = "lblNomeAluno";
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // formEditarAlunos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 330);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.dataNascimento);
            this.Controls.Add(this.btnRegistrarAluno);
            this.Controls.Add(this.cmbStatusAluno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtValorMensalidade);
            this.Controls.Add(this.txtCpfResponsavel);
            this.Controls.Add(this.label8);
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
            this.Load += new System.EventHandler(this.formEditarAlunos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dataNascimento;
        private System.Windows.Forms.Button btnRegistrarAluno;
        private System.Windows.Forms.ComboBox cmbStatusAluno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorMensalidade;
        private System.Windows.Forms.TextBox txtCpfResponsavel;
        private System.Windows.Forms.Label label8;
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
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
    }
}