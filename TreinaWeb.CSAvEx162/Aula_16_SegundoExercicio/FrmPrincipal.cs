using Aula_16_SegundoExercicio.ViewModels;
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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            CarregarPedidos();
        }

        private void CarregarPedidos()
        {
            var repositorio = new Repositorio.RepositorioPedido();
            var pedidos = repositorio.GetDados();

            var pedidoViewModels = new List<PedidoViewModel>();

            foreach (var pedido in pedidos)
            {
                var pedidoViewModel = new PedidoViewModel
                {
                    Id = pedido.Id,
                    DataVenda = pedido.DataVenda,
                    Valor = pedido.Detalhes.Sum(p => p.Valor)
                };

                pedidoViewModels.Add(pedidoViewModel);
            }

            dgvPedidos.DataSource = pedidoViewModels;
            dgvPedidos.Refresh();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            var frmProdutos = new FrmProdutos();

            frmProdutos.Show();
        }

        private void btnCadastrarPedido_Click(object sender, EventArgs e)
        {
            var frmPedido = new FrmPedido();

            frmPedido.ShowDialog();

            CarregarPedidos();
        }

        private void dgvPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var pedidoView = ((List<PedidoViewModel>)dgvPedidos.DataSource)[e.RowIndex];

            var repositorio = new Repositorio.RepositorioPedido();

            var pedido = repositorio.GetById(pedidoView.Id);

            var frmPedido = new FrmPedido { Pedido = pedido };

            frmPedido.ShowDialog();

            CarregarPedidos();
        }
    }
}
