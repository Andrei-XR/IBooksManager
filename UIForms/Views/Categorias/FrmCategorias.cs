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

namespace UIForms.Views.Categorias
{
    public partial class FrmCategorias : FrmBase
    {
        private readonly CategoriaRepository _categoriaRepository = new CategoriaRepository();

        public FrmCategorias()
        {
            InitializeComponent();
            CarregarCategorias();
        }

        private void CarregarCategorias()
        {
            var categorias = _categoriaRepository.List();

            DgCategorias.DataSource = categorias.Select(c => new
            {
                Id = c.Id,
                Nome = c.Nome
            }).OrderBy(c => c.Nome).ToList();
        }

        private void EditarCategoria()
        {
            var IdCategoria = (int)DgCategorias.SelectedRows[0].Cells["Id"].Value;

            using (var frm = new FrmEditar(IdCategoria))
            {
                frm.ShowDialog();
            }

            CarregarCategorias();
        }

        private void ExibirDetalhesCategoria()
        {
            var IdCategoria = (int)DgCategorias.SelectedRows[0].Cells["Id"].Value;

            using (var frm = new FrmDetalhes(IdCategoria))
            {
                frm.ShowDialog();
            }
        }

        private void RemoverCategoria()
        {
            var IdCategoria = (int)DgCategorias.SelectedRows[0].Cells["Id"].Value;
            bool remocaoValidada = _categoriaRepository.ValidarRemocao(IdCategoria);

            if (remocaoValidada)
            {
                _categoriaRepository.Delete(IdCategoria);
                return;
            }

            MessageBox.Show("A categoria não pode ser removida, pois existe vinculo com livro(s).", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmNovo())
            {
                frm.ShowDialog();
            }

            CarregarCategorias();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgCategorias.SelectedRows.Count > 0)
            {
                EditarCategoria();
            }
        }

        private void BtnDetalhes_Click(object sender, EventArgs e)
        {
            if (DgCategorias.SelectedRows.Count > 0)
            {
                ExibirDetalhesCategoria();
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Confirmar remoção ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                RemoverCategoria();
                CarregarCategorias();
            }
        }

        private void DgCategorias_DataSourceChanged(object sender, EventArgs e)
        {
            BtnRemover.Enabled = DgCategorias.Rows.Count > 0;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
