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
    public partial class FrmPedido : Form
    {
        public Pedido Pedido { get; set; }

        public FrmPedido()
        {
            InitializeComponent();

            btnCadastro.DialogResult = DialogResult.OK;
            btnAlterar.DialogResult = DialogResult.OK;
            btnExcluir.DialogResult = DialogResult.OK;
        }

        public void CarregarProdutos()
        {
            var repositorio = new Repositorio.RepositorioProduto();
            var produtos = repositorio.GetDados();

            dgvProdutos.DataSource = produtos;
            dgvProdutos.Refresh();

            if (Pedido != null)
            {
                btnCadastro.Enabled = false;

                txtmData.Text = Pedido.DataVenda.ToString("dd/MM/yyyy");
                CarregarDetalhes();
            }
            else
            {
                btnAlterar.Enabled = false;
                btnExcluir.Enabled = false;
            }
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            CarregarProdutos();
        }

        private void dgvProdutos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProdutos.Columns[e.ColumnIndex].HeaderText.Equals("Quantidade"))
            {
                var cell = dgvProdutos.Rows[e.RowIndex].Cells["Quantidade"];
                var quantidade = Convert.ToInt32(cell.Value);
                cell = dgvProdutos.Rows[e.RowIndex].Cells["Preco"];
                var preco = Convert.ToDouble(cell.Value);

                cell = dgvProdutos.Rows[e.RowIndex].Cells["Desconto"];

                var desconto = 0.0;
                if (cell.Value != null) //já aplica o desconto
                {
                    desconto = Convert.ToDouble(cell.Value.ToString().Replace("R$", ""));//remove o "R$" do texto se o usuário o informou
                }
                else
                {
                    cell.Value = desconto; //define o desconto
                }
                
                cell = dgvProdutos.Rows[e.RowIndex].Cells["Total"];
                cell.Value = (preco * quantidade) - desconto;

                CalcularTotal();//fica dentro do if para não ser chamado a todo momento
            }

            else if (dgvProdutos.Columns[e.ColumnIndex].HeaderText.Equals("Desconto"))
            {
                var cell = dgvProdutos.Rows[e.RowIndex].Cells["Quantidade"];
                var quantidade = 1;

                if (cell.Value != null)//já aplica a quantidade
                {
                    quantidade = Convert.ToInt32(cell.Value);
                }
                else
                {
                    cell.Value = quantidade;//define a quantidade
                }
                    
                cell = dgvProdutos.Rows[e.RowIndex].Cells["Preco"];
                var preco = Convert.ToDouble(cell.Value);

                cell = dgvProdutos.Rows[e.RowIndex].Cells["Desconto"];
                var desconto = Convert.ToDouble(cell.Value.ToString().Replace("R$", ""));//remove o "R$" do texto se o usuário o informou


                cell = dgvProdutos.Rows[e.RowIndex].Cells["Total"];
                cell.Value = (preco * quantidade) - desconto;

                CalcularTotal();//fica dentro do if para não ser chamado a todo momento
            }
        }

        private void CalcularTotal()
        {
            var total = 0.0;
            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                var cellTotal = row.Cells["Total"];
                if(cellTotal.Value != null)
                    total += Convert.ToDouble(cellTotal.Value);
            }

            txtTotal.Text = total.ToString("C2");
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var repositorioProduto = new Repositorio.RepositorioProduto();

            Pedido = new Pedido { DataVenda = Convert.ToDateTime(txtmData.Text) };

            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                var cellTotal = row.Cells["Total"];
                if (cellTotal.Value != null)
                {
                    var quantidade = row.Cells["Quantidade"];
                    var desconto = row.Cells["Desconto"];
                    var idProduo = row.Cells["Id"];


                    var detalhe = new PedidoDetalhe
                    {
                        Quantidade = Convert.ToInt32(quantidade.Value),
                        Desconto = Convert.ToDouble(desconto.Value.ToString().Replace("R$", "")),
                        Valor = Convert.ToDouble(cellTotal.Value),
                        Produto = new Produto { Id = Convert.ToInt32(idProduo.Value) },
                    };

                    Pedido.Detalhes.Add(detalhe);
                } 
            }

            var repositorio = new Repositorio.RepositorioPedido();
            repositorio.Inserir(Pedido);
        }

        public void CarregarDetalhes()
        {
            txtmData.Text = Pedido.DataVenda.ToString("dd/MM/yyyy");

            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                var cellId = row.Cells["Id"];
                if (cellId.Value != null)
                {
                    var detalhe = Pedido.Detalhes.FirstOrDefault(d => d.Produto.Id == (int) cellId.Value);
                    if(detalhe != null)
                    {
                        var quantidade = row.Cells["Quantidade"];
                        var desconto = row.Cells["Desconto"];
                        var total = row.Cells["Total"];

                        quantidade.Value = detalhe.Quantidade;
                        desconto.Value = detalhe.Desconto;
                        total.Value = detalhe.Valor;
                    }
                }
            }

            CalcularTotal();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            var repositorioProduto = new Repositorio.RepositorioProduto();

            Pedido.DataVenda = Convert.ToDateTime(txtmData.Text);

            foreach (DataGridViewRow row in dgvProdutos.Rows)
            {
                var cellTotal = row.Cells["Total"];
                if (cellTotal.Value != null)
                {
                    var repositorioDetalhe = new Repositorio.RepositorioPedidoDetalhe();

                    var quantidade = row.Cells["Quantidade"];
                    var desconto = row.Cells["Desconto"];
                    var idProduo = row.Cells["Id"];

                    var detalhe = Pedido.Detalhes.FirstOrDefault(d => d.Produto.Id == (int) idProduo.Value);
                    if (detalhe != null)
                    {
                        detalhe.Quantidade = Convert.ToInt32(quantidade.Value);
                        detalhe.Desconto = Convert.ToDouble(desconto.Value.ToString().Replace("R$", ""));
                        detalhe.Valor = Convert.ToDouble(cellTotal.Value);
                        detalhe.Pedido = new Pedido { Id = Pedido.Id };

                        repositorioDetalhe.Atualizar(detalhe);
                    }
                    else
                    {
                        detalhe = new PedidoDetalhe
                        {
                            Quantidade = Convert.ToInt32(quantidade.Value),
                            Desconto = Convert.ToDouble(desconto.Value.ToString().Replace("R$", "")),
                            Valor = Convert.ToDouble(cellTotal.Value),
                            Produto = new Produto { Id = Convert.ToInt32(idProduo.Value) },
                            Pedido = new Pedido { Id = Pedido.Id }
                    };

                        repositorioDetalhe.Inserir(detalhe);


                        Pedido.Detalhes.Add(detalhe);
                    }
                }
            }

            var repositorio = new Repositorio.RepositorioPedido();
            repositorio.Atualizar(Pedido);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var repositorio = new Repositorio.RepositorioPedido();

            repositorio.Excluir(Pedido);
        }

        private void FrmPedido_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
