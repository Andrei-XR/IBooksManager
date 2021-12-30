namespace UIForms.Views.Idiomas
{
    partial class FrmIdiomas
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
            this.DgIdiomas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgIdiomas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(456, 29);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(109, 29);
            this.BtnSair.TabIndex = 22;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(349, 29);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(101, 29);
            this.BtnRemover.TabIndex = 23;
            this.BtnRemover.Text = "REMOVER";
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // BtnDetalhes
            // 
            this.BtnDetalhes.Location = new System.Drawing.Point(242, 29);
            this.BtnDetalhes.Name = "BtnDetalhes";
            this.BtnDetalhes.Size = new System.Drawing.Size(101, 29);
            this.BtnDetalhes.TabIndex = 24;
            this.BtnDetalhes.Text = "DETALHES";
            this.BtnDetalhes.UseVisualStyleBackColor = true;
            this.BtnDetalhes.Click += new System.EventHandler(this.BtnDetalhes_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(135, 29);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(101, 29);
            this.BtnEditar.TabIndex = 25;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(28, 29);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(101, 29);
            this.BtnNovo.TabIndex = 26;
            this.BtnNovo.Text = "NOVO";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // DgIdiomas
            // 
            this.DgIdiomas.AllowUserToAddRows = false;
            this.DgIdiomas.AllowUserToDeleteRows = false;
            this.DgIdiomas.AllowUserToResizeColumns = false;
            this.DgIdiomas.AllowUserToResizeRows = false;
            this.DgIdiomas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgIdiomas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgIdiomas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome});
            this.DgIdiomas.Location = new System.Drawing.Point(28, 83);
            this.DgIdiomas.MultiSelect = false;
            this.DgIdiomas.Name = "DgIdiomas";
            this.DgIdiomas.ReadOnly = true;
            this.DgIdiomas.RowHeadersVisible = false;
            this.DgIdiomas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgIdiomas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgIdiomas.Size = new System.Drawing.Size(541, 216);
            this.DgIdiomas.TabIndex = 21;
            this.DgIdiomas.DataSourceChanged += new System.EventHandler(this.DgIdiomas_DataSourceChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "NOME";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // FrmIdiomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 329);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.BtnDetalhes);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.DgIdiomas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmIdiomas";
            this.Text = "Idiomas";
            ((System.ComponentModel.ISupportInitialize)(this.DgIdiomas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Button BtnDetalhes;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.DataGridView DgIdiomas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}