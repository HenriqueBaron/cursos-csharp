using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreinaWeb.ProdutosMarcas.Apresentacao.ViewModels;
using TreinaWeb.ProdutosMarcas.Dominio;
using TreinaWeb.ProdutosMarcas.Repos.EF;
using TreinaWeb.Repositorio.Comum;

namespace TreinaWeb.ProdutosMarcas.Apresentacao
{
    public partial class FrmProduto : Form
    {
        private Produto produtoAEditar;

        public FrmProduto(Produto produto = null)
        {
            produtoAEditar = produto;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void FrmProduto_Load(object sender, EventArgs e)
        {
            IRepositorioGenerico<Marca> repositorioMarcas = new RepositorioMarca();
            List<Marca> marcas = await repositorioMarcas.SelecionarTodos();
            List<MarcaViewModel> viewModels = new List<MarcaViewModel>();
            foreach (Marca marca in marcas)
            {
                MarcaViewModel viewModel = new MarcaViewModel()
                {
                    Id = marca.Id,
                    Nome = marca.Nome
                };
                viewModels.Add(viewModel);
            }
            cmbMarcas.DataSource = viewModels;
            cmbMarcas.DisplayMember = "Nome";
            cmbMarcas.ValueMember = "Id";
            cmbMarcas.Refresh();

            if (produtoAEditar != null)
            {
                txbNomeProduto.Text = produtoAEditar.Nome;
                cmbMarcas.SelectedValue = produtoAEditar.MarcaId;
            }
            else
            {
                txbNomeProduto.Text = string.Empty;
            }
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            IRepositorioGenerico<Produto> repositorioProdutos = new RepositorioProduto();
            if (produtoAEditar == null)
            {
                Produto novoProduto = new Produto()
                {
                    Nome = txbNomeProduto.Text.Trim(),
                    MarcaId = Convert.ToInt32(cmbMarcas.SelectedValue)
                };
                repositorioProdutos.Inserir(novoProduto);
            }
            else
            {
                produtoAEditar.Nome = txbNomeProduto.Text;
                produtoAEditar.MarcaId = Convert.ToInt32(cmbMarcas.SelectedValue);
                repositorioProdutos.Atualizar(produtoAEditar);
            }
            Close();
        }
    }
}
