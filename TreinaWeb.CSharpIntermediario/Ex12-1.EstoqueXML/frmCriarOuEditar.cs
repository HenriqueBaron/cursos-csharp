using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex12_1.EstoqueXML
{
    public partial class frmCriarOuEditar : Form
    {
        bool criarNovo = false;
        ProdutoXML produtoAnterior;

        public frmCriarOuEditar()
        {
            criarNovo = true;
            InitializeComponent();
            ShowDialog();
        }

        public frmCriarOuEditar(ProdutoXML produtoAEditar)
        {
            InitializeComponent();

            txbDescricao.Text = produtoAEditar.Descricao; ;
            txbPreco.Text = produtoAEditar.Preco.ToString();
            txbQuantidade.Text = produtoAEditar.Quantidade.ToString();

            produtoAnterior = produtoAEditar;
            ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string descricao = txbDescricao.Text;
            double preco = Convert.ToDouble(txbPreco.Text);
            int quantidade = Convert.ToInt32(txbQuantidade.Text);
            ProdutoXML novoProduto = new ProdutoXML(descricao, preco, quantidade);
            if (criarNovo)
            {
                ProdutoXML.AdicionarProduto(novoProduto);
            }
            else
            {
                ProdutoXML.SubstituirProduto(novoProduto, produtoAnterior);
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
