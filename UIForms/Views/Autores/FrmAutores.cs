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

namespace UIForms.Views.Autores
{
    public partial class FrmAutores : FrmBase
    {
        private AutorRepository _autorRepository = new AutorRepository();

        public FrmAutores()
        {
            InitializeComponent();
            CarregarAutores();
        }

        private void CarregarAutores()
        {
            var autores = _autorRepository.List();

            DgAutores.DataSource = autores.Select(a => new
            {
                Id = a.Id,
                Nome = a.Nome
            }).OrderBy(a => a.Nome).ToList();
        }

        private void EditarAutor()
        {
            var IdAutor = (int)DgAutores.SelectedRows[0].Cells["Id"].Value;

            using (var frm = new FrmEditar(IdAutor))
            {
                frm.ShowDialog();
            }

            CarregarAutores();
        }

        private void ExibirDetalhesAutor()
        {
            var IdAutor = (int)DgAutores.SelectedRows[0].Cells["Id"].Value;

            using (var frm = new FrmDetalhes(IdAutor))
            {
                frm.ShowDialog();
            }
        }

        private void RemoverAutor()
        {
            var IdAutor = (int)DgAutores.SelectedRows[0].Cells["Id"].Value;
            _autorRepository.Delete(IdAutor);
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmNovo())
            {
                frm.ShowDialog();
            }

            CarregarAutores();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(DgAutores.SelectedRows.Count > 0)
            {
                EditarAutor();
            }
        }

        private void BtnDetalhes_Click(object sender, EventArgs e)
        {
            if(DgAutores.SelectedRows.Count > 0)
            {
                ExibirDetalhesAutor();
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Confirmar remoção ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                RemoverAutor();
                CarregarAutores();
            }
        }

        private void DgAutores_DataSourceChanged(object sender, EventArgs e)
        {
            BtnRemover.Enabled = DgAutores.Rows.Count > 0;
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
