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
    public partial class FrmDetalhes : FrmBase
    {
        private IdiomaRepository _idiomaRepository = new IdiomaRepository();
        private int IdIdioma;

        public FrmDetalhes(int id)
        {
            InitializeComponent();
            this.IdIdioma = id;
            CarregarDadosIdioma();
        }

        private void CarregarDadosIdioma()
        {
            Idioma idioma = _idiomaRepository.Get(a => a.Id == IdIdioma);
            LblNome.Text = idioma.Nome;
        }
    }
}
