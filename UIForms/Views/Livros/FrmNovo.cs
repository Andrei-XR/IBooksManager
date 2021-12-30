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
        private LivroRepository livroRepository = new LivroRepository();
        private AutorRepository autorRepository = new AutorRepository();
        private EditoraRepository editoraRepository = new EditoraRepository();
        private IdiomaRepository idiomaRepository = new IdiomaRepository();

        public FrmNovo()
        {
            InitializeComponent();
            CarregarAutores();
            CarregarEditoras();
            CarregarIdiomas();
        }

        public void CarregarAutores()
        {
            var autores = autorRepository.List();

            CbAutor.DisplayMember = "Nome";
            CbAutor.ValueMember = "Id";
            CbAutor.DataSource = autores;
            CbAutor.SelectedIndex = 0;
        }

        public void CarregarEditoras()
        {
            var editoras = editoraRepository.List();

            CbEditora.DisplayMember = "Nome";
            CbEditora.ValueMember = "Id";
            CbEditora.DataSource = editoras;
            CbEditora.SelectedIndex = 0;
        }

        public void CarregarIdiomas()
        {
            var idiomas = idiomaRepository.List();

            CbIdioma.DisplayMember = "Nome";
            CbIdioma.ValueMember = "Id";
            CbIdioma.DataSource = idiomas;
            CbIdioma.SelectedIndex = 0;
        }

        public void SalvarLivro()
        {
            var livro = new Livro
            {
                Titulo = TxtTitulo.Text,
                Genero = TxtGenero.Text,
                Preco = NudPreco.Value,
                Paginas = (int)NudPaginas.Value,
                Quantidade = (int)NudQuantidade.Value,
                Ano = (int)NudAno.Value,
                AutorId = (int)CbAutor.SelectedValue,
                EditoraId = (int)CbEditora.SelectedValue,
                IdiomaId = (int)CbIdioma.SelectedValue,
            };

            livroRepository.Add(livro);
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
