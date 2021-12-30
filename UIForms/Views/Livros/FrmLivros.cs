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

namespace UIForms.Views.Livros
{
    public partial class FrmLivros : FrmBase
    {
        private LivroRepository livroRepository = new LivroRepository();

        public FrmLivros()
        {
            InitializeComponent();
            CarregarLivros();
        }

        public void CarregarLivros()
        {
            var livros = livroRepository.List(new[] { "Idioma" });

            DgLivros.DataSource = livros.Select(l => new
            {
                Id = l.Id,
                Titulo = l.Titulo,
                Idioma = l.Idioma.Nome,
                Preco = l.Preco,
                Paginas = l.Paginas,
                Ano = l.Ano
            }).OrderBy(l => l.Titulo).ToList();
        }

        private void RemoverLivro()
        {
            int idLivro = (int)DgLivros.SelectedRows[0].Cells["Id"].Value;
            livroRepository.Delete(idLivro);
        }

        private void EditarLivro()
        {
            int idLivro = (int)DgLivros.SelectedRows[0].Cells["Id"].Value;

            using (var frm = new FrmEditar(idLivro))
            {
                frm.ShowDialog();
            }

            CarregarLivros();
        }

        private void ExibirDetalhesLivro()
        {
            int idLivro = (int)DgLivros.SelectedRows[0].Cells["Id"].Value;

            using (var frm = new FrmDetalhes(idLivro))
            {
                frm.ShowDialog();
            }
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmNovo())
            {
                frm.ShowDialog();
            }

            CarregarLivros();
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Confirmar remoção ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                RemoverLivro();
                CarregarLivros();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (DgLivros.SelectedRows.Count > 0)
            {
                EditarLivro();
            }
        }

        private void BtnDetalhes_Click(object sender, EventArgs e)
        {
            if (DgLivros.SelectedRows.Count > 0)
            {
                ExibirDetalhesLivro();
            }
        }

        private void DgLivros_DataSourceChanged(object sender, EventArgs e)
        {
            BtnRemover.Enabled = DgLivros.Rows.Count > 0;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
