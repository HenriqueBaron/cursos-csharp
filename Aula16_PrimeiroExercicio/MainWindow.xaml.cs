using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace Aula16_PrimeiroExercicio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Task.Run(() => {
                var repositorio = new Repositorio.RepositorioBook();

                repositorio.ReadBookEvent += (obj, args) =>
                {
                    dgLivros.Dispatcher.Invoke(() => dgLivros.Items.Add(args.book));
                };

                repositorio.LerArquivo();
            });
        }
    }
}
