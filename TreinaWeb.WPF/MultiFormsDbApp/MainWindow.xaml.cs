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

namespace MultiFormsDbApp
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
            string conn = @"Server=.\SQLEXPRESS;Database=TreinaWebWPF;User Id=sa;Password=hb_19079303;";
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM twc_cursos", conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "twc_cursos");

            dgCursos.ItemsSource = ds.Tables["twc_cursos"].DefaultView;
        }

        private void dgCursos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dgCursos.SelectedItem != null)
            {
                var dr = dgCursos.SelectedItem as DataRowView;

                Edicao form = new Edicao(dr);
                form.ShowDialog();
            }
        }
    }
}
