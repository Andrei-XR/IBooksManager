namespace UIForms.Views.Livros
{
    partial class FrmLivros
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
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.BtnDetalhes = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.DgLivros = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Idioma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Paginas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(456, 43);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(109, 29);
            this.BtnSair.TabIndex = 4;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(349, 43);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(101, 29);
            this.BtnRemover.TabIndex = 5;
            this.BtnRemover.Text = "REMOVER";
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // BtnDetalhes
            // 
            this.BtnDetalhes.Location = new System.Drawing.Point(242, 43);
            this.BtnDetalhes.Name = "BtnDetalhes";
            this.BtnDetalhes.Size = new System.Drawing.Size(101, 29);
            this.BtnDetalhes.TabIndex = 6;
            this.BtnDetalhes.Text = "DETALHES";
            this.BtnDetalhes.UseVisualStyleBackColor = true;
            this.BtnDetalhes.Click += new System.EventHandler(this.BtnDetalhes_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(135, 43);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(101, 29);
            this.BtnEditar.TabIndex = 7;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(28, 43);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(101, 29);
            this.BtnNovo.TabIndex = 8;
            this.BtnNovo.Text = "NOVO";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // DgLivros
            // 
            this.DgLivros.AllowUserToAddRows = false;
            this.DgLivros.AllowUserToDeleteRows = false;
            this.DgLivros.AllowUserToResizeColumns = false;
            this.DgLivros.AllowUserToResizeRows = false;
            this.DgLivros.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Titulo,
            this.Idioma,
            this.Preco,
            this.Paginas,
            this.Ano});
            this.DgLivros.Location = new System.Drawing.Point(28, 97);
            this.DgLivros.MultiSelect = false;
            this.DgLivros.Name = "DgLivros";
            this.DgLivros.ReadOnly = true;
            this.DgLivros.RowHeadersVisible = false;
            this.DgLivros.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgLivros.Size = new System.Drawing.Size(541, 216);
            this.DgLivros.TabIndex = 3;
            this.DgLivros.DataSourceChanged += new System.EventHandler(this.DgLivros_DataSourceChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Titulo
            // 
            this.Titulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Titulo.DataPropertyName = "Titulo";
            this.Titulo.HeaderText = "TITULO";
            this.Titulo.Name = "Titulo";
            this.Titulo.ReadOnly = true;
            // 
            // Idioma
            // 
            this.Idioma.DataPropertyName = "Idioma";
            this.Idioma.HeaderText = "IDIOMA";
            this.Idioma.Name = "Idioma";
            this.Idioma.ReadOnly = true;
            // 
            // Preco
            // 
            this.Preco.DataPropertyName = "Preco";
            this.Preco.HeaderText = "PREÇO";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // Paginas
            // 
            this.Paginas.DataPropertyName = "Paginas";
            this.Paginas.HeaderText = "PAGINAS";
            this.Paginas.Name = "Paginas";
            this.Paginas.ReadOnly = true;
            // 
            // Ano
            // 
            this.Ano.DataPropertyName = "Ano";
            this.Ano.HeaderText = "ANO";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            // 
            // FrmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 329);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.BtnDetalhes);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.DgLivros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmLivros";
            this.Text = "Livros";
            ((System.ComponentModel.ISupportInitialize)(this.DgLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Button BtnDetalhes;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.DataGridView DgLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idioma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Paginas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
    }
}