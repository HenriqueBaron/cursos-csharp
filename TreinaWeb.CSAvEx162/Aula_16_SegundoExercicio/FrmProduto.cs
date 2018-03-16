using Aula_16_SegundoExercicio.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_16_SegundoExercicio
{
    public partial class FrmProduto : Form
    {
        public Produto Produto { get; set; } 

        public FrmProduto()
        {
            InitializeComponent();

            btnCadastro.DialogResult = DialogResult.OK;
            btnAlterar.DialogResult = DialogResult.OK;
            btnExcluir.DialogResult = DialogResult.OK;
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            if (Produto != null)
            {
                btnCadastro.Enabled = false;

                txtNome.Text = Produto.Nome;
                txtPreco.Text = Produto.Preco.ToString();
            }
            else
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var repositorio = new Repositorio.RepositorioProduto();

            var produto = new Produto
            {
                Nome = txtNome.Text,
                Preco = Convert.ToDouble(txtPreco.Text)
            };

            repositorio.Inserir(produto);

            this.Close();
        }

        private void FrmProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var repositorio = new Repositorio.RepositorioProduto();

            Produto.Nome = txtNome.Text;
            Produto.Preco = Convert.ToDouble(txtPreco.Text);

            repositorio.Atualizar(Produto);

            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var repositorio = new Repositorio.RepositorioProduto();

            repositorio.Excluir(Produto);

            this.Close();
        }
    }
}
