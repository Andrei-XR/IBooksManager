namespace UIForms.Views
{
    partial class FrmIBooksManager
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
            this.SContainer = new System.Windows.Forms.SplitContainer();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnIdiomas = new System.Windows.Forms.Button();
            this.BtnEditoras = new System.Windows.Forms.Button();
            this.BtnCategorias = new System.Windows.Forms.Button();
            this.BtnAutores = new System.Windows.Forms.Button();
            this.BtnLivros = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.SContainer)).BeginInit();
            this.SContainer.Panel1.SuspendLayout();
            this.SContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "IBooks Manager";
            // 
            // SContainer
            // 
            this.SContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SContainer.IsSplitterFixed = true;
            this.SContainer.Location = new System.Drawing.Point(0, 49);
            this.SContainer.Name = "SContainer";
            // 
            // SContainer.Panel1
            // 
            this.SContainer.Panel1.Controls.Add(this.BtnSair);
            this.SContainer.Panel1.Controls.Add(this.BtnIdiomas);
            this.SContainer.Panel1.Controls.Add(this.BtnEditoras);
            this.SContainer.Panel1.Controls.Add(this.BtnCategorias);
            this.SContainer.Panel1.Controls.Add(this.BtnAutores);
            this.SContainer.Panel1.Controls.Add(this.BtnLivros);
            this.SContainer.Size = new System.Drawing.Size(929, 464);
            this.SContainer.SplitterDistance = 218;
            this.SContainer.SplitterWidth = 2;
            this.SContainer.TabIndex = 2;
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(25, 337);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(165, 38);
            this.BtnSair.TabIndex = 5;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnIdiomas
            // 
            this.BtnIdiomas.Location = new System.Drawing.Point(25, 226);
            this.BtnIdiomas.Name = "BtnIdiomas";
            this.BtnIdiomas.Size = new System.Drawing.Size(165, 38);
            this.BtnIdiomas.TabIndex = 3;
            this.BtnIdiomas.Text = "IDIOMAS";
            this.BtnIdiomas.UseVisualStyleBackColor = true;
            this.BtnIdiomas.Click += new System.EventHandler(this.BtnIdiomas_Click);
            // 
            // BtnEditoras
            // 
            this.BtnEditoras.Location = new System.Drawing.Point(25, 170);
            this.BtnEditoras.Name = "BtnEditoras";
            this.BtnEditoras.Size = new System.Drawing.Size(165, 38);
            this.BtnEditoras.TabIndex = 2;
            this.BtnEditoras.Text = "EDITORAS";
            this.BtnEditoras.UseVisualStyleBackColor = true;
            this.BtnEditoras.Click += new System.EventHandler(this.BtnEditoras_Click);
            // 
            // BtnCategorias
            // 
            this.BtnCategorias.Location = new System.Drawing.Point(25, 113);
            this.BtnCategorias.Name = "BtnCategorias";
            this.BtnCategorias.Size = new System.Drawing.Size(165, 38);
            this.BtnCategorias.TabIndex = 1;
            this.BtnCategorias.Text = "CATEGORIAS";
            this.BtnCategorias.UseVisualStyleBackColor = true;
            this.BtnCategorias.Click += new System.EventHandler(this.BtnCategorias_Click);
            // 
            // BtnAutores
            // 
            this.BtnAutores.Location = new System.Drawing.Point(25, 59);
            this.BtnAutores.Name = "BtnAutores";
            this.BtnAutores.Size = new System.Drawing.Size(165, 38);
            this.BtnAutores.TabIndex = 0;
            this.BtnAutores.Text = "AUTORES";
            this.BtnAutores.UseVisualStyleBackColor = true;
            this.BtnAutores.Click += new System.EventHandler(this.BtnAutores_Click);
            // 
            // BtnLivros
            // 
            this.BtnLivros.Location = new System.Drawing.Point(25, 282);
            this.BtnLivros.Name = "BtnLivros";
            this.BtnLivros.Size = new System.Drawing.Size(165, 38);
            this.BtnLivros.TabIndex = 4;
            this.BtnLivros.Text = "LIVROS";
            this.BtnLivros.UseVisualStyleBackColor = true;
            this.BtnLivros.Click += new System.EventHandler(this.BtnLivros_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 50);
            this.panel1.TabIndex = 3;
            // 
            // FrmIBooksManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 513);
            this.Controls.Add(this.SContainer);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FrmIBooksManager";
            this.Text = "IBooks Manager";
            this.SContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SContainer)).EndInit();
            this.SContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer SContainer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnIdiomas;
        private System.Windows.Forms.Button BtnEditoras;
        private System.Windows.Forms.Button BtnAutores;
        private System.Windows.Forms.Button BtnLivros;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnCategorias;
    }
}