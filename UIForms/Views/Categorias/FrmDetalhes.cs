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
    public partial class FrmDetalhes : FrmBase
    {
        private readonly CategoriaRepository _categoriaRepository = new CategoriaRepository();
        private int _idCategoria;

        public FrmDetalhes(int id)
        {
            InitializeComponent();
            this._idCategoria = id;
            CarregarDadosCategoria();
        }

        private void CarregarDadosCategoria()
        {
            var categoria = _categoriaRepository.Get(c => c.Id == _idCategoria);
            LblNome.Text = categoria.Nome;
        }
    }
}
