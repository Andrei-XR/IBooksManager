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
    public partial class FrmNovo : FrmBase
    {
        private readonly CategoriaRepository _categoriaRepository = new CategoriaRepository();

        public FrmNovo()
        {
            InitializeComponent();
        }

        private void CadastrarCategoria()
        {
            Categoria categoria = new Categoria
            {
                Nome = TxtNome.Text
            };

            _categoriaRepository.Add(categoria);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                CadastrarCategoria();
            }

            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
