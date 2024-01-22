namespace Sistema_Sinapse.View
{
    partial class formCadastrarTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastrarTurma));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataIncial = new System.Windows.Forms.DateTimePicker();
            this.dataFinal = new System.Windows.Forms.DateTimePicker();
            this.registrarTurma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeTurma = new System.Windows.Forms.TextBox();
            this.cmbProfessores = new System.Windows.Forms.ComboBox();
            this.listaSemana = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horário Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Horário Final";
            // 
            // dataIncial
            // 
            this.dataIncial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dataIncial.Location = new System.Drawing.Point(15, 135);
            this.dataIncial.Name = "dataIncial";
            this.dataIncial.Size = new System.Drawing.Size(165, 20);
            this.dataIncial.TabIndex = 6;
            // 
            // dataFinal
            // 
            this.dataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dataFinal.Location = new System.Drawing.Point(15, 188);
            this.dataFinal.Name = "dataFinal";
            this.dataFinal.Size = new System.Drawing.Size(165, 20);
            this.dataFinal.TabIndex = 7;
            // 
            // registrarTurma
            // 
            this.registrarTurma.Location = new System.Drawing.Point(47, 311);
            this.registrarTurma.Name = "registrarTurma";
            this.registrarTurma.Size = new System.Drawing.Size(107, 23);
            this.registrarTurma.TabIndex = 8;
            this.registrarTurma.Text = "Registrar Turma";
            this.registrarTurma.UseVisualStyleBackColor = true;
            this.registrarTurma.Click += new System.EventHandler(this.registrarTurma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome da Turma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Professor Responsável";
            // 
            // txtNomeTurma
            // 
            this.txtNomeTurma.Location = new System.Drawing.Point(15, 25);
            this.txtNomeTurma.Name = "txtNomeTurma";
            this.txtNomeTurma.Size = new System.Drawing.Size(165, 20);
            this.txtNomeTurma.TabIndex = 11;
            // 
            // cmbProfessores
            // 
            this.cmbProfessores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfessores.FormattingEnabled = true;
            this.cmbProfessores.Location = new System.Drawing.Point(15, 80);
            this.cmbProfessores.Name = "cmbProfessores";
            this.cmbProfessores.Size = new System.Drawing.Size(165, 21);
            this.cmbProfessores.TabIndex = 12;
            // 
            // listaSemana
            // 
            this.listaSemana.FormattingEnabled = true;
            this.listaSemana.Items.AddRange(new object[] {
            "Segunda Feira",
            "Terça Feira",
            "Quarta Feira",
            "Quinta Feira",
            "Sexta Feira"});
            this.listaSemana.Location = new System.Drawing.Point(15, 219);
            this.listaSemana.Name = "listaSemana";
            this.listaSemana.Size = new System.Drawing.Size(165, 79);
            this.listaSemana.TabIndex = 13;
            this.listaSemana.Click += new System.EventHandler(this.listaSemana_Click);
            this.listaSemana.DoubleClick += new System.EventHandler(this.listaSemana_DoubleClick);
            // 
            // formCadastrarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(206, 346);
            this.Controls.Add(this.listaSemana);
            this.Controls.Add(this.cmbProfessores);
            this.Controls.Add(this.txtNomeTurma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrarTurma);
            this.Controls.Add(this.dataFinal);
            this.Controls.Add(this.dataIncial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formCadastrarTurma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Turma";
            this.Load += new System.EventHandler(this.formCadastrarTurma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dataIncial;
        private System.Windows.Forms.DateTimePicker dataFinal;
        private System.Windows.Forms.Button registrarTurma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeTurma;
        private System.Windows.Forms.ComboBox cmbProfessores;
        private System.Windows.Forms.CheckedListBox listaSemana;
    }
}