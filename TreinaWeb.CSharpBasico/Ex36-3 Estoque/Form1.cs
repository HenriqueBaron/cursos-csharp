using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex36_3_Estoque
{
    public partial class frmControleEstoque : Form
    {
        private int SelecaoAtual;

        private enum PassoCadastro : int
        {
            Selecao = 0,
            Edicao = 1
        }

        private enum AlteracaoCadastro : int
        {
            Incluir = 0,
            Alterar = 1
        }

        private AlteracaoCadastro Alteracao = new AlteracaoCadastro();

        public frmControleEstoque()
        {
            InitializeComponent();
        }

        private void frmControleEstoque_Shown(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarControles(PassoCadastro.Selecao);
            try
            {
                CarregarListaProdutos();
            }
            catch (FileNotFoundException ex) { }
        }

        private void LimparCampos()
        {
            txbNome.Clear();
            txbValor.Clear();
            txbQuantidade.Clear();
        }

        private void HabilitarControles(PassoCadastro passo)
        {
            bool estado = passo == PassoCadastro.Selecao;
            btnIncluir.Enabled = estado;
            btnAlterar.Enabled = estado;
            btnExcluir.Enabled = estado;
            btnSalvar.Enabled = !estado;
            btnCancelar.Enabled = !estado;

            txbNome.Enabled = !estado;
            txbValor.Enabled = !estado;
            txbQuantidade.Enabled = !estado;
        }

        private void CarregarListaProdutos()
        {
            lbxProdutos.Items.Clear();
            lbxProdutos.Items.AddRange(ManipuladorArquivo.Ler().ToArray());
        }

        private void SalvarListaProdutos()
        {
            List<Produto> produtosCadastrados = new List<Produto>();
            foreach (Produto produto in lbxProdutos.Items)
            {
                produtosCadastrados.Add(produto);
            }
            ManipuladorArquivo.Escrever(produtosCadastrados);
        }

        private void AtualizarSelecao()
        {
            if (lbxProdutos.SelectedIndex < 0)
            {
                lbxProdutos.SelectedIndex = 0;
            }
            Produto produto = (Produto)lbxProdutos.Items[lbxProdutos.SelectedIndex];
            txbNome.Text = produto.Nome;
            txbValor.Text = produto.Valor.ToString("C");
            txbQuantidade.Text = produto.Quantidade.ToString();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            LimparCampos();
            HabilitarControles(PassoCadastro.Edicao);
            Alteracao = AlteracaoCadastro.Incluir;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            HabilitarControles(PassoCadastro.Edicao);
            Alteracao = AlteracaoCadastro.Alterar;
            SelecaoAtual = lbxProdutos.SelectedIndex;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o produto selecionado?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbxProdutos.Items.RemoveAt(lbxProdutos.SelectedIndex);
                SalvarListaProdutos();
                CarregarListaProdutos();
                lbxProdutos.SelectedIndex = 0;
                AtualizarSelecao();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto()
            {
                Nome = txbNome.Text,
                Valor = float.Parse(txbValor.Text,System.Globalization.NumberStyles.Currency),
                Quantidade = int.Parse(txbQuantidade.Text)
            };
            if (Alteracao == AlteracaoCadastro.Incluir)
            {
                lbxProdutos.Items.Add(produto);
            }
            else
            {
                lbxProdutos.Items.RemoveAt(SelecaoAtual);
                lbxProdutos.Items.Insert(SelecaoAtual, produto);
            }
            SalvarListaProdutos();
            CarregarListaProdutos();
            AtualizarSelecao();
            HabilitarControles(PassoCadastro.Selecao);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            HabilitarControles(PassoCadastro.Selecao);
            AtualizarSelecao();
        }

        private void lbxProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarSelecao();
        }
    }
}
