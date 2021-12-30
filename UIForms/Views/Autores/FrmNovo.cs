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
using IBooksManagerLibrary.Models;

namespace UIForms.Views.Autores
{
    public partial class FrmNovo : FrmBase
    {
        private AutorRepository autorRepository = new AutorRepository();

        public FrmNovo()
        {
            InitializeComponent();
        }

        private void CadastrarAutor()
        {
            Autor autor = new Autor
            {
                Nome = TxtNome.Text
            };

            autorRepository.Add(autor);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                CadastrarAutor();
            }

            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
