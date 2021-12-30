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

namespace UIForms.Views.Editoras
{
    public partial class FrmDetalhes : FrmBase
    {
        private EditoraRepository _editoraRepository = new EditoraRepository();
        private int IdEditora;

        public FrmDetalhes(int id)
        {
            InitializeComponent();
            this.IdEditora = id;
            CarregarDadosEditora();
        }

        private void CarregarDadosEditora()
        {
            Editora editora = _editoraRepository.Get(a => a.Id == IdEditora);
            LblNome.Text = editora.Nome;
        }
    }
}
