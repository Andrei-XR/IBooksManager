namespace UIForms.Views.Livros
{
    partial class FrmEditar
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
            this.CbIdioma = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CbEditora = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CbAutor = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.NudAno = new System.Windows.Forms.NumericUpDown();
            this.NudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.NudPaginas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.NudPreco = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtGenero = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NudAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPreco)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(207, 322);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(108, 31);
            this.BtnCancelar.TabIndex = 45;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(93, 322);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(108, 31);
            this.BtnSalvar.TabIndex = 44;
            this.BtnSalvar.Text = "SALVAR";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // CbIdioma
            // 
            this.CbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbIdioma.FormattingEnabled = true;
            this.CbIdioma.Location = new System.Drawing.Point(94, 152);
            this.CbIdioma.Name = "CbIdioma";
            this.CbIdioma.Size = new System.Drawing.Size(260, 24);
            this.CbIdioma.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 40;
            this.label9.Text = "Idioma:";
            // 
            // CbEditora
            // 
            this.CbEditora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbEditora.FormattingEnabled = true;
            this.CbEditora.Location = new System.Drawing.Point(94, 122);
            this.CbEditora.Name = "CbEditora";
            this.CbEditora.Size = new System.Drawing.Size(260, 24);
            this.CbEditora.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Editora:";
            // 
            // CbAutor
            // 
            this.CbAutor.DisplayMember = "label";
            this.CbAutor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbAutor.FormattingEnabled = true;
            this.CbAutor.Location = new System.Drawing.Point(94, 92);
            this.CbAutor.Name = "CbAutor";
            this.CbAutor.Size = new System.Drawing.Size(260, 24);
            this.CbAutor.TabIndex = 41;
            this.CbAutor.ValueMember = "value";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 38;
            this.label7.Text = "Autor:";
            // 
            // NudAno
            // 
            this.NudAno.Location = new System.Drawing.Point(94, 267);
            this.NudAno.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudAno.Name = "NudAno";
            this.NudAno.Size = new System.Drawing.Size(97, 22);
            this.NudAno.TabIndex = 37;
            // 
            // NudQuantidade
            // 
            this.NudQuantidade.Location = new System.Drawing.Point(94, 239);
            this.NudQuantidade.Name = "NudQuantidade";
            this.NudQuantidade.Size = new System.Drawing.Size(97, 22);
            this.NudQuantidade.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Ano:";
            // 
            // NudPaginas
            // 
            this.NudPaginas.Location = new System.Drawing.Point(94, 211);
            this.NudPaginas.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NudPaginas.Name = "NudPaginas";
            this.NudPaginas.Size = new System.Drawing.Size(97, 22);
            this.NudPaginas.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Quantia:";
            // 
            // NudPreco
            // 
            this.NudPreco.DecimalPlaces = 2;
            this.NudPreco.Location = new System.Drawing.Point(94, 183);
            this.NudPreco.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NudPreco.Name = "NudPreco";
            this.NudPreco.Size = new System.Drawing.Size(97, 22);
            this.NudPreco.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Paginas:";
            // 
            // TxtGenero
            // 
            this.TxtGenero.Location = new System.Drawing.Point(94, 64);
            this.TxtGenero.Name = "TxtGenero";
            this.TxtGenero.Size = new System.Drawing.Size(260, 22);
            this.TxtGenero.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 28;
            this.label3.Text = "Preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Genero:";
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(94, 36);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(260, 22);
            this.TxtTitulo.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Titulo:";
            // 
            // FrmEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 368);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.CbIdioma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CbEditora);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CbAutor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NudAno);
            this.Controls.Add(this.NudQuantidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NudPaginas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NudPreco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtGenero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditar";
            this.Text = "Editar";
            ((System.ComponentModel.ISupportInitialize)(this.NudAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPreco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.ComboBox CbIdioma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CbEditora;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CbAutor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NudAno;
        private System.Windows.Forms.NumericUpDown NudQuantidade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NudPaginas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NudPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtGenero;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label label1;
    }
}