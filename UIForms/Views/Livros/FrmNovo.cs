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
    public partial class FrmNovo : FrmBase
    {
        private readonly LivroRepository _livroRepository = new LivroRepository();
        private readonly AutorRepository _autorRepository = new AutorRepository();
        private readonly EditoraRepository _editoraRepository = new EditoraRepository();
        private readonly IdiomaRepository _idiomaRepository = new IdiomaRepository();
        private readonly CategoriaRepository _categoriaRepository = new CategoriaRepository();

        public FrmNovo()
        {
            InitializeComponent();
            CarregarAutores();
            CarregarEditoras();
            CarregarIdiomas();
            CarregarCategorias();
        }

        private void CarregarAutores()
        {
            var autores = _autorRepository.List().OrderBy(a => a.Nome).ToList();

            CbAutor.DisplayMember = "Nome";
            CbAutor.ValueMember = "Id";
            CbAutor.DataSource = autores;
            CbAutor.SelectedIndex = 0;
        }

        private void CarregarEditoras()
        {
            var editoras = _editoraRepository.List().OrderBy(e => e.Nome).ToList();

            CbEditora.DisplayMember = "Nome";
            CbEditora.ValueMember = "Id";
            CbEditora.DataSource = editoras;
            CbEditora.SelectedIndex = 0;
        }

        private void CarregarIdiomas()
        {
            var idiomas = _idiomaRepository.List().OrderBy(i => i.Nome).ToList();

            CbIdioma.DisplayMember = "Nome";
            CbIdioma.ValueMember = "Id";
            CbIdioma.DataSource = idiomas;
            CbIdioma.SelectedIndex = 0;
        }

        private void CarregarCategorias()
        {
            var categorias = _categoriaRepository.List().OrderBy(c => c.Nome).ToList();

            ((ListBox)CkListCategorias).DataSource = categorias;
            ((ListBox)CkListCategorias).DisplayMember = "Nome";
            ((ListBox)CkListCategorias).ValueMember = "Id";
        }

        private void SalvarLivro()
        {
            var livro = new Livro
            {
                Titulo = TxtTitulo.Text,
                Preco = NudPreco.Value,
                Paginas = (int)NudPaginas.Value,
                Quantidade = (int)NudQuantidade.Value,
                Ano = (int)NudAno.Value,
                AutorId = (int)CbAutor.SelectedValue,
                EditoraId = (int)CbEditora.SelectedValue,
                IdiomaId = (int)CbIdioma.SelectedValue,
                Categorias = CkListCategorias.CheckedItems.Cast<Categoria>().ToList()
            };

            _livroRepository.Add(livro);
            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            SalvarLivro();
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
