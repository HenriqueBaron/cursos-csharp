using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Ex12_1.EstoqueXML
{
    public partial class frmControleEstoque : Form
    {
        public frmControleEstoque()
        {
            InitializeComponent();
        }

        private void frmControleEstoque_Load(object sender, EventArgs e)
        {
            CarregarTitulo();
            CarregarListView();
        }

        private void CarregarTitulo()
        {
            lblTitulo.Text = XMLUtils.ObterTitulo("/estoque/titulo");
        }

        private void CarregarListView()
        {
            //Adiciona colunas programaticamente
            /*lsvProdutos.Columns.Add("Produto", -2);
            lsvProdutos.Columns.Add("Preço", -2);
            lsvProdutos.Columns.Add("Quantidade", -2);*/

            lsvProdutos.Items.Clear();

            List<ProdutoXML> produtos = ProdutoXML.ObterProdutos();
            List<ListViewItem> itensListView = new List<ListViewItem>();
            foreach (ProdutoXML produto in produtos)
            {
                ListViewItem item = new ListViewItem(produto.Descricao);
                item.SubItems.Add(produto.Preco.ToString("C"));
                item.SubItems.Add(produto.Quantidade.ToString());
                itensListView.Add(item);
            }

            lsvProdutos.Items.AddRange(itensListView.ToArray());

            //Autoajusta a largura das colunas
            //lsvProdutos.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCriarOuEditar frmNovo = new frmCriarOuEditar();
            CarregarListView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ProdutoXML produtoSelecionado = ProdutoXML.ObterProdutos()[lsvProdutos.SelectedIndices[0]];
            frmCriarOuEditar frmEditar = new frmCriarOuEditar(produtoSelecionado);
            CarregarListView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir o produto selecionado?",
                                                    "Exclusão de produto", 
                                                    MessageBoxButtons.YesNo);
            if (confirmacao == DialogResult.Yes)
            {
                ProdutoXML produtoSelecionado = ProdutoXML.ObterProdutos()[lsvProdutos.SelectedIndices[0]];
                ProdutoXML.ExcluirProduto(produtoSelecionado);
            }
            CarregarListView();
        }
    }
}
