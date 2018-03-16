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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DataSources.Properties.Settings.ProdutosVendasConnectionString"].ConnectionString))
            using (SqlCommand cmd = connection.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO Produtoes (Nome, Preco) VALUES (@Nome, @Preco)";
                cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@Preco", Convert.ToSingle(txtPreco.Text));
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Cadastrado com sucesso.");
            }
            this.Close();
        }
    }
}
