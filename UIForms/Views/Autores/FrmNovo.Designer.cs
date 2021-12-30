namespace UIForms.Views.Autores
{
    partial class FrmNovo
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(62, 44);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(214, 22);
            this.TxtNome.TabIndex = 1;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(62, 90);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(89, 30);
            this.BtnSalvar.TabIndex = 2;
            this.BtnSalvar.Text = "SALVAR";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(187, 90);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(89, 30);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FrmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 132);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmNovo";
            this.Text = "Novo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}