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
    public partial class FrmEditar : FrmBase
    {
        private EditoraRepository _editoraRepository = new EditoraRepository();
        private Editora Editora;

        public FrmEditar(int id)
        {
            InitializeComponent();
            this.Editora = _editoraRepository.Get(a => a.Id == id);
            CarregarDadosEditora();
        }

        private void CarregarDadosEditora()
        {
            TxtNome.Text = this.Editora.Nome;
        }

        private void SalvarDadosEditora()
        {
            this.Editora.Nome = TxtNome.Text;
            _editoraRepository.Update(this.Editora);

            this.Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                SalvarDadosEditora();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
