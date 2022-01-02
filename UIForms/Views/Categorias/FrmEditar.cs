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

namespace UIForms.Views.Categorias
{
    public partial class FrmEditar : FrmBase
    {
        private readonly CategoriaRepository _categoriaRepository = new CategoriaRepository();
        private Categoria _categoria;

        public FrmEditar(int id)
        {
            InitializeComponent();
            _categoria = _categoriaRepository.Get(c => c.Id == id);
            CarregarDadosCategoria();
        }

        private void CarregarDadosCategoria()
        {
            TxtNome.Text = _categoria.Nome;
        }

        private void SalvarDadosCategoria()
        {
            _categoria.Nome = TxtNome.Text;
            _categoriaRepository.Update(_categoria);

            Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                SalvarDadosCategoria();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
