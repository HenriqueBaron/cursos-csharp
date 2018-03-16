using Ex12_1.EstoqueXML.DAO;
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
using static Ex12_1.EstoqueXML.DAO.ProdutoDAO;

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
            CarregarDataGridView();
        }

        private void CarregarDataGridView()
        {
            DataTable table = ProdutoDAO.GetProdutos();
            dgvProdutos.DataSource = table;

            dgvProdutos.Refresh();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmCriarOuEditar frmNovo = new frmCriarOuEditar();
            CarregarDataGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produtoSelecionado = new Produto
            {
                Id = (int)dgvProdutos.CurrentRow.Cells[0].Value,
                Descricao = dgvProdutos.CurrentRow.Cells[1].Value.ToString(),
                Preco = Convert.ToDouble(dgvProdutos.CurrentRow.Cells[2].Value),
                Quantidade = (int)dgvProdutos.CurrentRow.Cells[3].Value
            };
            
            frmCriarOuEditar frmEditar = new frmCriarOuEditar(produtoSelecionado);
            CarregarDataGridView();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirmacao = MessageBox.Show("Tem certeza que deseja excluir o produto selecionado?",
                                                    "Exclusão de produto", 
                                                    MessageBoxButtons.YesNo);
            if (confirmacao == DialogResult.Yes)
            {
                Produto produtoSelecionado = new Produto
                {
                    Id = (int)dgvProdutos.CurrentRow.Cells[0].Value,
                    Descricao = dgvProdutos.CurrentRow.Cells[1].Value.ToString(),
                    Preco = Convert.ToDouble(dgvProdutos.CurrentRow.Cells[2].Value),
                    Quantidade = (int)dgvProdutos.CurrentRow.Cells[3].Value
                };
                ProdutoDAO.Excluir(produtoSelecionado);
            }
            CarregarDataGridView();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoDAO.ImportarDeXML();
                MessageBox.Show("Importação finalizada com sucesso.");
                CarregarDataGridView();
            }
            catch { }
        }
    }
}
