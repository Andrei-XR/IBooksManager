using IBooksManagerLibrary.Data.Repositories;
using IBooksManagerLibrary.Models;
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
    public partial class FrmEditar : FrmBase
    {
        private readonly LivroRepository _livroRepository = new LivroRepository();
        private readonly AutorRepository _autorRepository = new AutorRepository();
        private readonly EditoraRepository _editoraRepository = new EditoraRepository();
        private readonly IdiomaRepository _idiomaRepository = new IdiomaRepository();
        private readonly CategoriaRepository _categoriaRepository = new CategoriaRepository();
        private Livro Livro;
        private int IdLivro;

        public FrmEditar(int id)
        {
            InitializeComponent();
            this.IdLivro = id;
            BuscarLivro();
            CarregarAutores();
            CarregarEditoras();
            CarregarIdiomas();
            CarregarCategorias();
            CarregarDadosLivro();
        }

        private void BuscarLivro()
        {
            this.Livro = _livroRepository.Get(l => l.Id == this.IdLivro, new[] { "Categorias" });
        }

        private void CarregarAutores()
        {
            var autores = _autorRepository.List().OrderBy(a => a.Nome).ToList();

            CbAutor.DisplayMember = "Nome";
            CbAutor.ValueMember = "Id";
            CbAutor.DataSource = autores;
        }

        public void CarregarEditoras()
        {
            var editoras = _editoraRepository.List().OrderBy(e => e.Nome).ToList();

            CbEditora.DisplayMember = "Nome";
            CbEditora.ValueMember = "Id";
            CbEditora.DataSource = editoras;
        }

        public void CarregarIdiomas()
        {
            var idiomas = _idiomaRepository.List().OrderBy(i => i.Nome).ToList();

            CbIdioma.DisplayMember = "Nome";
            CbIdioma.ValueMember = "Id";
            CbIdioma.DataSource = idiomas;
        }

        private void CarregarCategorias()
        {
            var categorias = _categoriaRepository.List().OrderBy(c => c.Nome).ToList();

            ((ListBox)CkListCategorias).DataSource = categorias;
            ((ListBox)CkListCategorias).DisplayMember = "Nome";
            ((ListBox)CkListCategorias).ValueMember = "Id";
        }

        private void CarregarDadosLivro()
        {
            TxtTitulo.Text = this.Livro.Titulo;
            NudPreco.Value = this.Livro.Preco;
            NudPaginas.Value = this.Livro.Paginas;
            NudAno.Value = this.Livro.Ano;
            NudQuantidade.Value = this.Livro.Quantidade;
            CbAutor.SelectedValue = this.Livro.AutorId;
            CbEditora.SelectedValue = this.Livro.EditoraId;
            CbIdioma.SelectedValue = this.Livro.IdiomaId;

            foreach (var categoria in this.Livro.Categorias)
            {
                for (int i = 0; i < CkListCategorias.Items.Count; i++)
                {
                    if (((Categoria)CkListCategorias.Items[i]).Id == categoria.Id)
                    {
                        CkListCategorias.SetItemCheckState(i, CheckState.Checked);
                    }
                }
            }
        }

        private void SalvarEdicaoLivro()
        {
            this.Livro.Titulo = TxtTitulo.Text;
            this.Livro.Preco = NudPreco.Value;
            this.Livro.Paginas = (int)NudPaginas.Value;
            this.Livro.Ano = (int)NudAno.Value;
            this.Livro.Quantidade = (int)NudQuantidade.Value;
            this.Livro.AutorId = (int)CbAutor.SelectedValue;
            this.Livro.EditoraId = (int)CbEditora.SelectedValue;
            this.Livro.IdiomaId = (int)CbIdioma.SelectedValue;
            this.Livro.Categorias = CkListCategorias.CheckedItems.Cast<Categoria>().ToList();

            _livroRepository.Update(this.Livro);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SalvarEdicaoLivro();
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
