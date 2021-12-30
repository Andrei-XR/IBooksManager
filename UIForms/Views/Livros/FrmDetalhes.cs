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
    public partial class FrmDetalhes : FrmBase
    {
        private LivroRepository livroRepository = new LivroRepository();
        private Livro Livro;

        public FrmDetalhes(int id)
        {
            InitializeComponent();
            this.Livro = livroRepository.Get(l => l.Id == id, new[] { "Autor", "Editora", "Idioma" });
            CarregarDadosLivro();
        }

        private void CarregarDadosLivro()
        {
            LblTitulo.Text = this.Livro.Titulo;
            LblGenero.Text = this.Livro.Genero;
            LblPreco.Text = this.Livro.Preco.ToString("C2");
            LblAno.Text = this.Livro.Ano.ToString();
            LblPaginas.Text = this.Livro.Paginas.ToString();
            LblQuantidade.Text = this.Livro.Quantidade.ToString();
            LblAutor.Text = this.Livro.Autor.Nome;
            LblEditora.Text = this.Livro.Editora.Nome;
            LblIdioma.Text = this.Livro.Idioma.Nome;
        }
    }
}
