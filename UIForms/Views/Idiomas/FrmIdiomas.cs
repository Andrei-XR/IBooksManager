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

namespace UIForms.Views.Idiomas
{
    public partial class FrmIdiomas : FrmBase
    {
        private IdiomaRepository _idiomaRepository = new IdiomaRepository();

        public FrmIdiomas()
        {
            InitializeComponent();
            CarregarIdiomas();
        }

        private void CarregarIdiomas()
        {
            var idiomas = _idiomaRepository.List();

            DgIdiomas.DataSource = idiomas.Select(e => new
            {
                Id = e.Id,
                Nome = e.Nome
            }).OrderBy(e => e.Nome).ToList();
        }

        private void EditarIdioma()
        {
            var IdIdioma = (int)DgIdiomas.SelectedRows[0].Cells["Id"].Value;

            using (var frm = new FrmEditar(IdIdioma))
            {
                frm.ShowDialog();
            }

            CarregarIdiomas();
        }

        private void ExibirDetalhesIdioma()
        {
            var IdIdioma = (int)DgIdiomas.SelectedRows[0].Cells["Id"].Value;

            using (var frm = new FrmDetalhes(IdIdioma))
            {
                frm.ShowDialog();
            }
        }

        private void RemoverIdioma()
        {
            var IdIdioma = (int)DgIdiomas.SelectedRows[0].Cells["Id"].Value;
            bool remocaoValidada = _idiomaRepository.ValidarRemocao(IdIdioma);

            if (remocaoValidada)
            {
                _idiomaRepository.Delete(IdIdioma);
                return;
            }

            MessageBox.Show("O idioma não pode ser removido, pois existe vinculo com livro(s).", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmNovo())
            {
                frm.ShowDialog();
            }

            CarregarIdiomas();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgIdiomas.SelectedRows.Count > 0)
            {
                EditarIdioma();
            }
        }

        private void BtnDetalhes_Click(object sender, EventArgs e)
        {
            if (DgIdiomas.SelectedRows.Count > 0)
            {
                ExibirDetalhesIdioma();
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Confirmar remoção ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                RemoverIdioma();
                CarregarIdiomas();
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgIdiomas_DataSourceChanged(object sender, EventArgs e)
        {
            BtnRemover.Enabled = DgIdiomas.Rows.Count > 0;
        }
    }
}
