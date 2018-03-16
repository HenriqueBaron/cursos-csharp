using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataSources
{
    public partial class FrmTabela : Form
    {
        public FrmTabela()
        {
            InitializeComponent();
        }

        private void produtoesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.produtoesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.produtosVendasDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'produtosVendasDataSet.Produtoes'. Você pode movê-la ou removê-la conforme necessário.
            this.produtoesTableAdapter.Fill(this.produtosVendasDataSet.Produtoes);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            FrmProduto novoProduto = new FrmProduto();
            novoProduto.ShowDialog();
            produtoesTableAdapter.Fill(produtosVendasDataSet.Produtoes);
            produtoesBindingSource.DataSource = produtosVendasDataSet;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            string id = produtoesDataGridView.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Deseja realmente apagar?", "Exclusão de produto", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataSources.Properties.Settings.ProdutosVendasConnectionString"].ConnectionString))
                using (SqlCommand cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Produtoes WHERE Id = @ID";
                    cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(id));

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    produtoesBindingSource.RemoveCurrent();
                }
            }
        }
    }
}
