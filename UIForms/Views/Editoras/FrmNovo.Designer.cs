namespace UIForms.Views.Editoras
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(196, 78);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(89, 30);
            this.BtnCancelar.TabIndex = 5;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(71, 78);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(89, 30);
            this.BtnSalvar.TabIndex = 6;
            this.BtnSalvar.Text = "SALVAR";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(71, 32);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(214, 22);
            this.TxtNome.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // FrmNovo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 124);
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

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label label1;
    }
}