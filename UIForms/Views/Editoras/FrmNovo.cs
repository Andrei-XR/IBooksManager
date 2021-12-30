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
    public partial class FrmNovo : FrmBase
    {
        private EditoraRepository _editoraRepository = new EditoraRepository();

        public FrmNovo()
        {
            InitializeComponent();
        }

        private void CadastrarEditora()
        {
            var editora = new Editora
            {
                Nome = TxtNome.Text
            };

            _editoraRepository.Add(editora);
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtNome.Text))
            {
                CadastrarEditora();
            }

            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
