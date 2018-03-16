using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreinaWeb.ProdutosMarcas.Apresentacao.ViewModels;
using TreinaWeb.ProdutosMarcas.Dominio;
using TreinaWeb.ProdutosMarcas.Repos.EF;
using TreinaWeb.Repositorio.Comum;

namespace TreinaWeb.ProdutosMarcas.Apresentacao
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewMarcasAsync();
            PreencherDataGridViewProdutosAsync();
        }

        private async void PreencherDataGridViewMarcasAsync()
        {
            IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
            List<Marca> marcas = await repositorioMarcas.SelecionarTodos();
            List<MarcaViewModel> marcaViewModels = new List<MarcaViewModel>();
            foreach (Marca marca in marcas)
            {
                MarcaViewModel viewModel = new MarcaViewModel()
                {
                    Id = marca.Id,
                    Nome = marca.Nome
                };
                marcaViewModels.Add(viewModel);
            }
            dgvMarcas.Invoke((MethodInvoker)delegate
            {
                dgvMarcas.DataSource = marcaViewModels;
                dgvMarcas.Refresh();
            });
        }

        private async void PreencherDataGridViewProdutosAsync()
        {
            IRepositorioGenerico<Produto> repositorioProdutos = new RepositorioProduto();
            List<Produto> produtos = await repositorioProdutos.SelecionarTodos();
            List<ProdutoViewModel> marcaViewModels = new List<ProdutoViewModel>();
            foreach (Produto produto in produtos)
            {
                ProdutoViewModel viewModel = new ProdutoViewModel()
                {
                    Id = produto.Id,
                    Marca = produto.Marca.Nome,
                    MarcaId = produto.MarcaId,
                    Nome = produto.Nome
                };
                marcaViewModels.Add(viewModel);
            }
            dgvProdutos.Invoke((MethodInvoker)delegate
            {
                dgvProdutos.DataSource = marcaViewModels;
                dgvProdutos.Refresh();
            });
        }

        private void btnCadastrarMarca_Click(object sender, EventArgs e)
        {
            FrmMarca frmMarca = new FrmMarca();
            frmMarca.ShowDialog();
            PreencherDataGridViewMarcasAsync();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.ShowDialog();
            PreencherDataGridViewProdutosAsync();
        }

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedRows.Count > 0)
            {
                int idMarcaSelecionada = Convert.ToInt32(dgvMarcas.SelectedRows[0].Cells[0].Value);
                IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
                Marca marcaAEditar = repositorioMarcas.SelecionarPorId(idMarcaSelecionada);
                FrmMarca frmMarca = new FrmMarca(marcaAEditar);
                frmMarca.ShowDialog();
                PreencherDataGridViewMarcasAsync();
                PreencherDataGridViewProdutosAsync();
            }
            else
            {
                MessageBox.Show("Selecione uma marca antes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEditarProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int idProdutoSelecionado = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells[0].Value);
                IRepositorioGenerico<Produto> repositorioProdutos = new RepositorioProduto();
                Produto produtoAEditar = repositorioProdutos.SelecionarPorId(idProdutoSelecionado);
                FrmProduto frmProduto = new FrmProduto(produtoAEditar);
                frmProduto.ShowDialog();
                PreencherDataGridViewProdutosAsync();
            }
            else
            {
                MessageBox.Show("Selecione um produto antes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluirMarca_Click(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedRows.Count > 0)
            {
                int idMarcaSelecionada = Convert.ToInt32(dgvMarcas.SelectedRows[0].Cells[0].Value);
                IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
                Marca marcaAExcluir = repositorioMarcas.SelecionarPorId(idMarcaSelecionada);
                repositorioMarcas.Excluir(marcaAExcluir);
                PreencherDataGridViewMarcasAsync();
                PreencherDataGridViewProdutosAsync();
            }
            else
            {
                MessageBox.Show("Selecione uma marca antes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                int idProdutoSelecionado = Convert.ToInt32(dgvProdutos.SelectedRows[0].Cells[0].Value);
                IRepositorioGenerico<Produto> repositorioProdutos = new RepositorioProduto();
                Produto produtoAExcluir = repositorioProdutos.SelecionarPorId(idProdutoSelecionado);
                repositorioProdutos.Excluir(produtoAExcluir);
                PreencherDataGridViewProdutosAsync();
            }
            else
            {
                MessageBox.Show("Selecione um produto antes.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
