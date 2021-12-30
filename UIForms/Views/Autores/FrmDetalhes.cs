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
    public partial class FrmDetalhes : FrmBase
    {
        private AutorRepository autorRepository = new AutorRepository();
        private int IdAutor;

        public FrmDetalhes(int id)
        {
            InitializeComponent();
            this.IdAutor = id;
            CarregarDadosAutor();
        }

        private void CarregarDadosAutor()
        {
            Autor autor = autorRepository.Get(a => a.Id == IdAutor);
            LblNome.Text = autor.Nome;
        }
    }
}
