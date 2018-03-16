using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AdoApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Define-se a string de conexão
            string con = @"Server=.\SQLEXPRESS;Database=TreinaWebWPF;User Id=sa;Password = hb_19079303;";

            // Define-se a query SQL que será executada
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM twc_cursos", con);

            // Executa-se a query e armazena-se o resultado em memória
            DataSet ds = new DataSet();
            da.Fill(ds, "twc_cursos");

            // Atribui-se o resultado ao DataGrid
            dgCursos.ItemsSource = ds.Tables["twc_cursos"].DefaultView;
        }
    }
}
