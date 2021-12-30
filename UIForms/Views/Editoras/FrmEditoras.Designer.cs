namespace UIForms.Views.Editoras
{
    partial class FrmEditoras
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
            this.DgEditoras = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgEditoras)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.Location = new System.Drawing.Point(456, 29);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(109, 29);
            this.BtnSair.TabIndex = 16;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(349, 29);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(101, 29);
            this.BtnRemover.TabIndex = 17;
            this.BtnRemover.Text = "REMOVER";
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // BtnDetalhes
            // 
            this.BtnDetalhes.Location = new System.Drawing.Point(242, 29);
            this.BtnDetalhes.Name = "BtnDetalhes";
            this.BtnDetalhes.Size = new System.Drawing.Size(101, 29);
            this.BtnDetalhes.TabIndex = 18;
            this.BtnDetalhes.Text = "DETALHES";
            this.BtnDetalhes.UseVisualStyleBackColor = true;
            this.BtnDetalhes.Click += new System.EventHandler(this.BtnDetalhes_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(135, 29);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(101, 29);
            this.BtnEditar.TabIndex = 19;
            this.BtnEditar.Text = "EDITAR";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(28, 29);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(101, 29);
            this.BtnNovo.TabIndex = 20;
            this.BtnNovo.Text = "NOVO";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // DgEditoras
            // 
            this.DgEditoras.AllowUserToAddRows = false;
            this.DgEditoras.AllowUserToDeleteRows = false;
            this.DgEditoras.AllowUserToResizeColumns = false;
            this.DgEditoras.AllowUserToResizeRows = false;
            this.DgEditoras.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgEditoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgEditoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome});
            this.DgEditoras.Location = new System.Drawing.Point(28, 83);
            this.DgEditoras.MultiSelect = false;
            this.DgEditoras.Name = "DgEditoras";
            this.DgEditoras.ReadOnly = true;
            this.DgEditoras.RowHeadersVisible = false;
            this.DgEditoras.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DgEditoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgEditoras.Size = new System.Drawing.Size(541, 216);
            this.DgEditoras.TabIndex = 15;
            this.DgEditoras.DataSourceChanged += new System.EventHandler(this.DgEditoras_DataSourceChanged);
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
            // FrmEditoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 329);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.BtnDetalhes);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.DgEditoras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmEditoras";
            this.Text = "Editoras";
            ((System.ComponentModel.ISupportInitialize)(this.DgEditoras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.Button BtnDetalhes;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnNovo;
        private System.Windows.Forms.DataGridView DgEditoras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}