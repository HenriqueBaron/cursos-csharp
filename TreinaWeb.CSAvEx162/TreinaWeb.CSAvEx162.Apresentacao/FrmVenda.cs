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
    public partial class FrmVendaEdicao : Form
    {
        private Venda vendaAtiva;

        public FrmVendaEdicao(Venda venda = null)
        {
            InitializeComponent();
            if (venda != null)
            {
                vendaAtiva = venda;
                PreencherDataGridViewItens();
            }
            else
            {
                vendaAtiva = CriarNovaVenda();
                txbValorTotal.Text = 0.ToString("c");
            }
            txbData.Text = vendaAtiva.Data.ToString();
        }

        private Venda CriarNovaVenda()
        {
            DateTime agora = ArrendondarMilissegundos(DateTime.Now);
            Venda novaVenda = new Venda { Data = agora };
            IRepositorio<Venda> repositorioVendas = new RepositorioVenda();
            repositorioVendas.Inserir(novaVenda);
            List<Venda> vendas = repositorioVendas.SelecionarTodos().Result;
            IEnumerable<Venda> buscaVendas = vendas.Where(v => v.Data == agora);
            return buscaVendas.ElementAt(0);
        }

        private DateTime ArrendondarMilissegundos(DateTime data)
        {
            return new DateTime(data.Ticks - data.Ticks % 100000);
        }

        private async void PreencherDataGridViewItens()
        {
            IRepositorio<ItemVenda> repositorioItens = new RepositorioItemVenda();
            List<ItemVenda> itens = await repositorioItens.SelecionarTodos();
            IEnumerable<ItemVenda> itensVendaAtiva = itens.Where(i => i.VendaId == vendaAtiva.Id);
            List<ItemVendaViewModel> itensViewModels = new List<ItemVendaViewModel>();
            foreach (ItemVenda item in itensVendaAtiva)
            {
                ItemVendaViewModel viewModel = new ItemVendaViewModel
                {
                    Id = item.Id,
                    ProdutoId = item.ProdutoId,
                    ProdutoNome = item.Produto.Nome,
                    ProdutoPreco = item.Produto.Preco,
                    Quantidade = item.Quantidade,
                    Valor = item.Valor
                };
                itensViewModels.Add(viewModel);
            }
            dgvItens.Invoke((MethodInvoker)delegate
            {
                dgvItens.DataSource = itensViewModels;
                dgvItens.Columns[3].DefaultCellStyle.Format = "c";
                dgvItens.Columns[5].DefaultCellStyle.Format = "c";
                dgvItens.Refresh();
            });
            PreencherValorVenda(itensVendaAtiva);
        }

        private void PreencherValorVenda(IEnumerable<ItemVenda> itensVendaAtiva)
        {
            List<double> valores = new List<double>();
            foreach (ItemVenda item in itensVendaAtiva)
            {
                valores.Add(item.Valor);
            }
            double valorTotal = valores.Sum();
            vendaAtiva.Valor = valorTotal;
            IRepositorio<Venda> repositorioVendas = new RepositorioVenda();
            repositorioVendas.Atualizar(vendaAtiva);
            txbValorTotal.Invoke((MethodInvoker)delegate
            {
                txbValorTotal.Text = valorTotal.ToString("c");
            });
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            FrmItemVenda frmItemVenda = new FrmItemVenda(vendaAtiva.Id);
            frmItemVenda.ShowDialog();
            PreencherDataGridViewItens();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            IRepositorio<ItemVenda> repositorioItensVenda = new RepositorioItemVenda();
            FrmItemVenda frmItemVenda = new FrmItemVenda(repositorioItensVenda.SelecionarPorId((int)dgvItens.SelectedRows[0].Cells[0].Value));
            frmItemVenda.ShowDialog();
            PreencherDataGridViewItens();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            IRepositorio<ItemVenda> repositorioItensVenda = new RepositorioItemVenda();
            repositorioItensVenda.Excluir(repositorioItensVenda.SelecionarPorId((int)dgvItens.SelectedRows[0].Cells[0].Value));
            PreencherDataGridViewItens();
        }
    }
}
