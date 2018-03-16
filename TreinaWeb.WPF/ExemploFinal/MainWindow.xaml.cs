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

namespace ExemploFinal
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

        private void rbbSair_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Application.Current.Shutdown();
            }
        }

        private void rbbNovo_Click(object sender, RoutedEventArgs e)
        {
            TreinamentoEdicao edicao = new TreinamentoEdicao(new twc_cursos());
            stkContent.Content = edicao;
        }

        private void rbbLista_Click(object sender, RoutedEventArgs e)
        {
            TreinamentoLista lista = new TreinamentoLista();
            stkContent.Content = lista;
        }
    }
}
