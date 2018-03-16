using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TreinaWeb.CSAvEx162.Dominio;
using TreinaWeb.CSAvEx162.Repos.Comum;
using TreinaWeb.CSAvEx162.Repos.EF;

namespace TreinaWeb.CSAvEx162.Apresentacao
{
    public partial class FrmProduto : Form
    {
        private Produto produtoAEditar;

        public FrmProduto(Produto produto = null)
        {
            produtoAEditar = produto;
            InitializeComponent();
            if (produto != null)
            {
                txbNome.Text = produto.Nome;
                txbPreco.Text = produto.Preco.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            IRepositorio<Produto> repositorioProdutos = new RepositorioProduto();
            string novoNome = txbNome.Text.Trim();
            double novoPreco = Convert.ToDouble(txbPreco.Text);
            if (produtoAEditar == null)
            {
                Produto novoProduto = new Produto
                {
                    Nome = novoNome,
                    Preco = novoPreco
                };
                repositorioProdutos.Inserir(novoProduto);
            }
            else
            {
                produtoAEditar.Nome = novoNome;
                produtoAEditar.Preco = novoPreco;
                repositorioProdutos.Atualizar(produtoAEditar);
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
