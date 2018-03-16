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
    public partial class FrmItemVenda : Form
    {
        ItemVenda itemAEditar;
        int vendaId;

        public FrmItemVenda(ItemVenda item)
        {
            InitializeComponent();
            PreencherComboBoxProdutos();
            itemAEditar = item;
            txbQuantidade.Text = item.Quantidade.ToString();
        }

        public FrmItemVenda(int vendaId)
        {
            InitializeComponent();
            PreencherComboBoxProdutos();
            this.vendaId = vendaId;
            txbQuantidade.Text = "0";
        }

        public async void PreencherComboBoxProdutos()
        {
            IRepositorio<Produto> repositorioProdutos = new RepositorioProduto();
            List<Produto> produtos = await repositorioProdutos.SelecionarTodos();
            List<ProdutoViewModel> produtosViewModels = new List<ProdutoViewModel>();
            foreach (Produto produto in produtos)
            {
                ProdutoViewModel viewModel = new ProdutoViewModel
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    Preco = produto.Preco
                };
                produtosViewModels.Add(viewModel);
            }
            cmbProdutos.Invoke((MethodInvoker)delegate
            {
                cmbProdutos.DataSource = produtosViewModels;
                cmbProdutos.DisplayMember = "Nome";
                cmbProdutos.ValueMember = "Id";
                cmbProdutos.Refresh();
            });
        }

        private double CalcularValorItem(ItemVenda item)
        {
            return ((ProdutoViewModel)cmbProdutos.SelectedItem).Preco * item.Quantidade;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            IRepositorio<ItemVenda> repositorioItensVenda = new RepositorioItemVenda();
            if (itemAEditar == null)
            {
                ItemVenda itemVenda = new ItemVenda
                {
                    VendaId = vendaId,
                    ProdutoId = (int)cmbProdutos.SelectedValue,
                    Quantidade = Convert.ToInt32(txbQuantidade.Text),
                };
                itemVenda.Valor = CalcularValorItem(itemVenda);
                repositorioItensVenda.Inserir(itemVenda);
            }
            else
            {
                itemAEditar.ProdutoId = (int)cmbProdutos.SelectedValue;
                itemAEditar.Quantidade = Convert.ToInt32(txbQuantidade.Text);
                itemAEditar.Valor = CalcularValorItem(itemAEditar);
                repositorioItensVenda.Atualizar(itemAEditar);
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
