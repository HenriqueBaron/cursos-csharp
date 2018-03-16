using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreinaWeb.CSAvEx162.Apresentacao.ViewModels;
using TreinaWeb.CSAvEx162.Dominio;
using TreinaWeb.CSAvEx162.Repos.Comum;
using TreinaWeb.CSAvEx162.Repos.EF;

namespace TreinaWeb.CSAvEx162.Apresentacao
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewVendas();
            PreencherDataGridViewProdutos();
        }

        private async void PreencherDataGridViewVendas()
        {
            IRepositorio<Venda> repositorioVendas = new RepositorioVenda();
            List<Venda> vendas = await repositorioVendas.SelecionarTodos();
            List<VendaViewModel> vendaViewModels = new List<VendaViewModel>();
            foreach (Venda venda in vendas)
            {
                VendaViewModel viewModel = new VendaViewModel
                {
                    Id = venda.Id,
                    Data = venda.Data,
                    Valor = venda.Valor
                };
                vendaViewModels.Add(viewModel);
            }
            dgvVendas.Invoke((MethodInvoker)delegate
            {
                dgvVendas.DataSource = vendaViewModels;
                dgvVendas.Columns[2].DefaultCellStyle.Format = "c";
                dgvVendas.Refresh();
            });
        }

        private async void PreencherDataGridViewProdutos()
        {
            IRepositorio<Produto> repositorioProdutos = new RepositorioProduto();
            List<Produto> produtos = await repositorioProdutos.SelecionarTodos();
            List<ProdutoViewModel> produtoViewModels = new List<ProdutoViewModel>();
            foreach (Produto produto in produtos)
            {
                ProdutoViewModel viewModel = new ProdutoViewModel
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    Preco = produto.Preco
                };
                produtoViewModels.Add(viewModel);
            }
            dgvProdutos.Invoke((MethodInvoker)delegate
            {
                dgvProdutos.DataSource = produtoViewModels;
                dgvProdutos.Columns[2].DefaultCellStyle.Format = "c";
                dgvProdutos.Refresh();
            });
        }

        private void btnInserirProduto_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
            PreencherDataGridViewProdutos();
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            IRepositorio<Produto> repositorioProdutos = new RepositorioProduto();
            Produto produtoAEditar = repositorioProdutos.SelecionarPorId(Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells[0].Value));
            FrmProduto frmProduto = new FrmProduto(produtoAEditar);
            frmProduto.ShowDialog();
            PreencherDataGridViewProdutos();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            IRepositorio<Produto> repositorioProdutos = new RepositorioProduto();
            Produto produtoAExcluir = repositorioProdutos.SelecionarPorId((int)dgvProdutos.SelectedRows[0].Cells[0].Value);
            repositorioProdutos.Excluir(produtoAExcluir);
            PreencherDataGridViewProdutos();
        }

        private void btnInserirVenda_Click(object sender, EventArgs e)
        {
            FrmVendaEdicao frmVendaEdicao = new FrmVendaEdicao();
            frmVendaEdicao.ShowDialog();
            PreencherDataGridViewVendas();
        }

        private void btnEditarVenda_Click(object sender, EventArgs e)
        {
            IRepositorio<Venda> repositorioVendas = new RepositorioVenda();
            Venda vendaAEditar = repositorioVendas.SelecionarPorId((int)dgvVendas.SelectedRows[0].Cells[0].Value);
            FrmVendaEdicao frmVendaEdicao = new FrmVendaEdicao(vendaAEditar);
            frmVendaEdicao.ShowDialog();
            PreencherDataGridViewVendas();
        }

        private void btnExcluirVenda_Click(object sender, EventArgs e)
        {
            IRepositorio<Venda> repositorioVendas = new RepositorioVenda();
            repositorioVendas.Excluir(repositorioVendas.SelecionarPorId((int)dgvVendas.SelectedRows[0].Cells[0].Value));
            PreencherDataGridViewVendas();
        }
    }
}
