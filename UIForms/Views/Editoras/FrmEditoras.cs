using IBooksManagerLibrary.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIForms.Views.Editoras
{
    public partial class FrmEditoras : FrmBase
    {
        private EditoraRepository _editoraRepository = new EditoraRepository();

        public FrmEditoras()
        {
            InitializeComponent();
            CarregarEditoras();
        }

        private void CarregarEditoras()
        {
            var editoras = _editoraRepository.List();

            DgEditoras.DataSource = editoras.Select(e => new
            {
                Id = e.Id,
                Nome = e.Nome
            }).OrderBy(e => e.Nome).ToList();
        }

        private void EditarEditora()
        {
            var IdEditora = (int)DgEditoras.SelectedRows[0].Cells["Id"].Value;

            using (var frm = new FrmEditar(IdEditora))
            {
                frm.ShowDialog();
            }

            CarregarEditoras();
        }

        private void ExibirDetalhesEditora()
        {
            var IdEditora = (int)DgEditoras.SelectedRows[0].Cells["Id"].Value;

            using (var frm = new FrmDetalhes(IdEditora))
            {
                frm.ShowDialog();
            }
        }

        private void RemoverEditora()
        {
            var IdEditora = (int)DgEditoras.SelectedRows[0].Cells["Id"].Value;
            _editoraRepository.Delete(IdEditora);
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmNovo())
            {
                frm.ShowDialog();
            }

            CarregarEditoras();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgEditoras.SelectedRows.Count > 0)
            {
                EditarEditora();
            }
        }

        private void BtnDetalhes_Click(object sender, EventArgs e)
        {
            if (DgEditoras.SelectedRows.Count > 0)
            {
                ExibirDetalhesEditora();
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Confirmar remoção ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                RemoverEditora();
                CarregarEditoras();
            }
        }

        private void DgEditoras_DataSourceChanged(object sender, EventArgs e)
        {
            BtnRemover.Enabled = DgEditoras.Rows.Count > 0;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
