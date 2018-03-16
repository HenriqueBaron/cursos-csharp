using System;
using System.Collections.Generic;
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

namespace MySqlEntityApp
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
            CarregarDados();
        }

        private void CarregarDados()
        {
            using (TreinaWebMySqlModel entity = new TreinaWebMySqlModel())
            {
                dgCursos.ItemsSource = entity.Cursos.ToList();
            }
        }

        private void btnCadastrar_Click(object sender, RoutedEventArgs e)
        {
            using (TreinaWebMySqlModel entity = new TreinaWebMySqlModel())
            {
                var curso = new Curso()
                {
                    Nome = txtNome.Text,
                    Descricao = txtDescricao.Text
                };
                entity.Cursos.Add(curso);
                entity.SaveChanges();
            }

            CarregarDados();
        }
    }
}
