using IBooksManagerLibrary.Data;
using IBooksManagerLibrary.Data.Contracts;
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
using UIForms.Views.Autores;
using UIForms.Views.Editoras;
using UIForms.Views.Idiomas;
using UIForms.Views.Livros;

namespace UIForms.Views
{
    public partial class FrmIBooksManager : FrmBase
    {

        private Form Formulario;

        public FrmIBooksManager()
        {
            InitializeComponent();
        }

        private void ExibirFormulario(Form form)
        {
            if (Formulario != null)
            {
                Formulario.Dispose();
            }

            Formulario = form;
            Formulario.TopLevel = false;
            this.SContainer.Panel2.Controls.Add(Formulario);
            Formulario.Show();
        }

        private void BtnLivros_Click(object sender, EventArgs e)
        {
            ExibirFormulario(new FrmLivros());
        }

        private void BtnAutores_Click(object sender, EventArgs e)
        {
            ExibirFormulario(new FrmAutores());
        }

        private void BtnEditoras_Click(object sender, EventArgs e)
        {
            ExibirFormulario(new FrmEditoras());
        }

        private void BtnIdiomas_Click(object sender, EventArgs e)
        {
            ExibirFormulario(new FrmIdiomas());
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
