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

namespace UIForms.Views.Idiomas
{
    public partial class FrmEditar : FrmBase
    {
        private IdiomaRepository _editoraRepository = new IdiomaRepository();
        private Idioma Idioma;

        public FrmEditar(int id)
        {
            InitializeComponent();
            this.Idioma = _editoraRepository.Get(a => a.Id == id);
            CarregarDadosIdiomas();
        }

        private void CarregarDadosIdiomas()
        {
            TxtNome.Text = this.Idioma.Nome;
        }

        private void SalvarDadosIdioma()
        {
            this.Idioma.Nome = TxtNome.Text;
            _editoraRepository.Update(this.Idioma);

            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                SalvarDadosIdioma();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
