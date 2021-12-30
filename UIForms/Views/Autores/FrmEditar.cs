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

namespace UIForms.Views.Autores
{
    public partial class FrmEditar : FrmBase
    {
        private AutorRepository autorRepository = new AutorRepository();
        private Autor Autor { get; set; }

        public FrmEditar(int id)
        {
            InitializeComponent();
            this.Autor = autorRepository.Get(a => a.Id == id);
            CarregarDadosAutor();
        }

        private void CarregarDadosAutor()
        {
            TxtNome.Text = this.Autor.Nome;
        }

        private void SalvarDadosAutor()
        {
            this.Autor.Nome = TxtNome.Text;
            autorRepository.Update(this.Autor);

            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                SalvarDadosAutor();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
