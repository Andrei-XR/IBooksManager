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
        private LivroRepository livroRepository = new LivroRepository();
        private AutorRepository autorRepository = new AutorRepository();
        private EditoraRepository editoraRepository = new EditoraRepository();
        private IdiomaRepository idiomaRepository = new IdiomaRepository();
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
            CarregarDadosLivro();
        }

        private void BuscarLivro()
        {
            this.Livro = livroRepository.Get(l => l.Id == this.IdLivro);
        }

        private void CarregarAutores()
        {
            var autores = autorRepository.List().OrderBy(a => a.Nome).ToList();

            CbAutor.DisplayMember = "Nome";
            CbAutor.ValueMember = "Id";
            CbAutor.DataSource = autores;
            CbAutor.SelectedIndex = 0;
        }

        public void CarregarEditoras()
        {
            var editoras = editoraRepository.List().OrderBy(e => e.Nome).ToList();

            CbEditora.DisplayMember = "Nome";
            CbEditora.ValueMember = "Id";
            CbEditora.DataSource = editoras;
            CbEditora.SelectedIndex = 0;
        }

        public void CarregarIdiomas()
        {
            var idiomas = idiomaRepository.List().OrderBy(i => i.Nome).ToList();

            CbIdioma.DisplayMember = "Nome";
            CbIdioma.ValueMember = "Id";
            CbIdioma.DataSource = idiomas;
            CbIdioma.SelectedIndex = 0;
        }

        private void CarregarDadosLivro()
        {
            TxtTitulo.Text = this.Livro.Titulo;
            TxtGenero.Text = this.Livro.Genero;
            NudPreco.Value = this.Livro.Preco;
            NudPaginas.Value = this.Livro.Paginas;
            NudAno.Value = this.Livro.Ano;
            NudQuantidade.Value = this.Livro.Quantidade;
            CbAutor.SelectedValue = this.Livro.AutorId;
            CbEditora.SelectedValue = this.Livro.EditoraId;
            CbIdioma.SelectedValue = this.Livro.IdiomaId;
        }

        private void SalvarEdicaoLivro()
        {
            this.Livro.Titulo = TxtTitulo.Text;
            this.Livro.Genero = TxtGenero.Text;
            this.Livro.Preco = NudPreco.Value;
            this.Livro.Paginas = (int)NudPaginas.Value;
            this.Livro.Ano = (int)NudAno.Value;
            this.Livro.Quantidade = (int)NudQuantidade.Value;
            this.Livro.AutorId = (int)CbAutor.SelectedValue;
            this.Livro.EditoraId = (int)CbEditora.SelectedValue;
            this.Livro.IdiomaId = (int)CbIdioma.SelectedValue;

            livroRepository.Update(this.Livro);
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
