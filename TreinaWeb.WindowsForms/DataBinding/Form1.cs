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

namespace DataBinding
{
    public partial class frmBindingNavigator : Form
    {
        public frmBindingNavigator()
        {
            InitializeComponent();
        }

        private void frmBindingNavigator_Load(object sender, EventArgs e)
        {
            bdnNavigator.BindingSource = bdsSource;

            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureConnString"].ConnectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM Sales.Store", connection));
                DataSet ds = new DataSet();
                ds.Tables.Add("Store");
                dataAdapter.Fill(ds.Tables["Store"]);

                ds.Tables["Store"].TableNewRow += new DataTableNewRowEventHandler(Table_NewRow);
                bdsSource.DataSource = ds.Tables["Store"];

                txtBusinessEntityId.DataBindings.Add(
                    new Binding("Text", bdsSource, "BusinessEntityID", true));

                txtNome.DataBindings.Add(
                    new Binding("Text", bdsSource, "Name", true));
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                bdsSource.EndEdit();
                DataTable dt = (DataTable)bdsSource.DataSource;
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureConnString"].ConnectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT * FROM Sales.Store", connection));
                    SqlCommandBuilder cmd = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.InsertCommand = cmd.GetInsertCommand();
                    dataAdapter.UpdateCommand = cmd.GetUpdateCommand();
                    dataAdapter.DeleteCommand = cmd.GetDeleteCommand();

                    dataAdapter.Update(dt);

                    MessageBox.Show("Dados cadastrados com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private static void Table_NewRow(object sender, DataTableNewRowEventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["AdventureConnString"].ConnectionString))
                {
                    string query = "INSERT INTO Person.BusinessEntity VALUES (NEWID(), GETDATE())";
                    query += " SELECT SCOPE_IDENTITY() ";

                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query, connection);
                    long id = long.Parse(cmd.ExecuteScalar().ToString());
                    connection.Close();

                    e.Row["BusinessEntityID"] = id;
                    e.Row["SalesPersonID"] = DBNull.Value;
                    e.Row["Demographics"] = DBNull.Value;
                    e.Row["rowguid"] = Guid.NewGuid();
                    e.Row["ModifiedDate"] = DateTime.Today;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
