using Aula_16_SegundoExercicio.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_16_SegundoExercicio
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            var frm = new FrmProduto();
            frm.ShowDialog();

            CarregarDados();
        }

        public void CarregarDados()
        {
            var repositorio = new Repositorio.RepositorioProduto();
            var produtos = repositorio.GetDados();

            dgvProdutos.DataSource = produtos;
            dgvProdutos.Refresh();
        }

        private void dgvProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var produto = ((List<Produto>)dgvProdutos.DataSource)[e.RowIndex];

            var frmProduto = new FrmProduto { Produto = produto };

            frmProduto.ShowDialog();

            CarregarDados();
        }
    }
}
