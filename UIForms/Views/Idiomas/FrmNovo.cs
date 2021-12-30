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
    public partial class FrmNovo : FrmBase
    {
        private IdiomaRepository _idiomaRepository = new IdiomaRepository();

        public FrmNovo()
        {
            InitializeComponent();
        }

        private void CadastrarIdioma()
        {
            var idioma = new Idioma
            {
                Nome = TxtNome.Text
            };

            _idiomaRepository.Add(idioma);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                CadastrarIdioma();
            }

            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
