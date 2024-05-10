namespace Sistema_Sinapse.View.Opcoes_Contratos.Opcoes
{
    partial class formEditarOpcoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formEditarOpcoes));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtDuracao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricaoAula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNomeAula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(105, 122);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Salvar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtDuracao
            // 
            this.txtDuracao.Location = new System.Drawing.Point(60, 87);
            this.txtDuracao.Name = "txtDuracao";
            this.txtDuracao.Size = new System.Drawing.Size(173, 20);
            this.txtDuracao.TabIndex = 8;
            this.txtDuracao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuracao_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Duração";
            // 
            // txtDescricaoAula
            // 
            this.txtDescricaoAula.Location = new System.Drawing.Point(60, 33);
            this.txtDescricaoAula.Name = "txtDescricaoAula";
            this.txtDescricaoAula.Size = new System.Drawing.Size(173, 20);
            this.txtDescricaoAula.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Descrição da Aula";
            // 
            // lblNomeAula
            // 
            this.lblNomeAula.AutoSize = true;
            this.lblNomeAula.Location = new System.Drawing.Point(206, 114);
            this.lblNomeAula.Name = "lblNomeAula";
            this.lblNomeAula.Size = new System.Drawing.Size(66, 13);
            this.lblNomeAula.TabIndex = 10;
            this.lblNomeAula.Text = "lblNomeAula";
            // 
            // formEditarOpcoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 163);
            this.Controls.Add(this.lblNomeAula);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtDuracao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricaoAula);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formEditarOpcoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Opcoes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formEditarOpcoes_FormClosed);
            this.Load += new System.EventHandler(this.formEditarOpcoes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtDuracao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricaoAula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNomeAula;
    }
}