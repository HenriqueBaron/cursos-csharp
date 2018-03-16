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

namespace DadosTabelas
{
    public partial class frmDataGridView : Form
    {
        public frmDataGridView()
        {
            InitializeComponent();
            CarregarDadosLista();
        }

        private void frmDataGridView_Load(object sender, EventArgs e)
        {
            CarregarStates();
        }

        /* Um DataGridView pode ser carregado com diversos tipos de objetos. Os métodos abaixo demonstram isso, preenchendo o controle
         * com diferentes fontes de dados. */

        #region Dados de uma base de dados

        private void CarregarDadosDB()
        {
            // Atribuição de um DataSet como DataSource do DataGridView. O DataSet é um conjunto de dados de um banco de dados.
            string customers = "SELECT * FROM Sales.Customer";
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureConnString"].ConnectionString))
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(customers, conn);
                da.Fill(ds, "Customer");
                dgvDados.AutoGenerateColumns = true;
                dgvDados.DataSource = ds;
                dgvDados.DataMember = "Customer";
            }
        }

        #endregion

        #region Dados de Arrays

        private void CarregarDadosArray()
        {
            // Atribuição de um Array como DataSource do DataGridView.
            /* O código abaixo não funciona, pois o DataGridView exibe as propriedades públicas de um array.
             * Portanto, será exibida apenas uma coluna com os valores da propriedade String.Length das strings,
             * já que esta é a única propriedade pública deste tipo de objeto. */
            /* string[] nomes = new string[] { "Carlos", "Ana", "Maria" };
            dgvDados.DataSource = nomes;*/

            // Solução para o problema: criar uma classe, tendo como propriedade pública o valor a exibir.
            Item[] nomes = new Item[] { new Item("Carlos"), new Item("Ana"), new Item("Maria") };
            dgvDados.DataSource = nomes;
        }

        private class Item
        {
            public Item(string nome)
            {
                this.Nome = nome;
            }
            public string Nome { get; set; }
        }

        #endregion

        #region Dados de uma DataTable

        private void CarregarDadosDataTable()
        {
            DataTable vendedores = new DataTable();
            DataColumn column;
            DataRow row;

            column = new DataColumn("Código");
            vendedores.Columns.Add(column);

            column = new DataColumn("Nome");
            vendedores.Columns.Add(column);

            column = new DataColumn("Ativo", Type.GetType("System.Boolean"));
            vendedores.Columns.Add(column);

            for (int i = 0; i < 10; i++)
            {
                row = vendedores.NewRow();
                row["Código"] = i;
                row["Nome"] = "Vendedor" + i;
                if (i % 2 == 0)
                {
                    row["Ativo"] = true;
                }
                else
                {
                    row["Ativo"] = false;
                }
                vendedores.Rows.Add(row);
            }

            dgvDados.DataSource = vendedores;

        }

        #endregion

        #region Exibição de DataView para filtragem de dados

        private void CarregarDadosFiltroTexto()
        {
            // Carrega um conjunto de dados filtráveis por texto. Essencialmente, o conteúdo exibido no DataGridView é um DataView
            string customers = "SELECT FirstName, MiddleName, LastName FROM Person.Person";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureConnString"].ConnectionString))
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(customers, con);
                da.Fill(ds, "Person");

                DataTable person = ds.Tables["Person"];
                DataView dataView = new DataView(person);

                dgvDados.AutoGenerateColumns = true;
                dgvDados.DataSource = dataView;
            }

            txtPesquisa.Enabled = true;
            cboStates.Enabled = false;
        }

        private void CarregarDadosFiltroState()
        {
            // Carrega um conjunto de dados filtráveis por um ComboBox. Essencialmente, o conteúdo exibido no DataGridView é uma DataTable
            string customers = "SELECT FirstName, MiddleName, LastName FROM Person.Person";
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureConnString"].ConnectionString))
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(customers, con);
                da.Fill(ds, "Person");

                DataTable person = ds.Tables["Person"];

                dgvDados.AutoGenerateColumns = true;
                dgvDados.DataSource = person;
            }

            cboStates.Enabled = true;
            txtPesquisa.Enabled = false;
        }

        //Filtragem dos resultados na caixa de pesquisa
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDados.DataSource != null)
                {
                    DataView dv = (DataView)dgvDados.DataSource;
                    if (txtPesquisa.Text.Trim().Length > 0)
                    {
                        dv.RowFilter = "FirstName LIKE '%" + txtPesquisa.Text + "%' ";
                    }
                    else
                    {
                        dv.RowFilter = "";
                    }
                    dgvDados.DataSource = dv;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void CarregarStates()
        {
            cboStates.DataSource = Enum.GetValues(typeof(DataViewRowState));
        }

        private void cboStates_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDados.DataSource != null)
                {
                    DataView dv = new DataView((DataTable)dgvDados.DataSource);
                    if ((int)cboStates.SelectedValue > 0)
                    {
                        dv.RowStateFilter = (DataViewRowState)cboStates.SelectedValue;
                        dgvFiltroState.DataSource = dv;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        #endregion

        #region Dados de uma lista genérica List<>

        private void CarregarDadosLista()
        {
            Contatos contatos = new Contatos();

            Contato teste = new Contato("Nome", Sexo.Masculino, new DateTime(1, 1, 1));

            contatos.Add(new Contato("Carlos Silva", Sexo.Masculino, new DateTime(1980, 3, 23)));
            contatos.Add(new Contato("Maria Aparecida", Sexo.Feminino, new DateTime(1978, 6, 13)));
            contatos.Add(new Contato("João Pedro", Sexo.Masculino, new DateTime(1990, 8, 21)));
            contatos.Add(new Contato("Roberto Carlos", Sexo.Masculino, new DateTime(1940, 1, 13)));
            contatos.Add(new Contato("Carla Regina", Sexo.Feminino, new DateTime(1986, 10, 30)));
            contatos.Add(new Contato("Paulo Pereira", Sexo.Masculino, new DateTime(1989, 5, 16)));
            contatos.Add(new Contato("Jesus Pedro", Sexo.Masculino, new DateTime(1995, 12, 15)));

            dgvDados.DataSource = contatos;

            cboStates.Enabled = true;
            txtPesquisa.Enabled = true;
        }

        #endregion
    }
}
