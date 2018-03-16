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

namespace MenuApp
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

        private void ExibirMensagem(string mensagem)
        {
            MessageBox.Show(mensagem);
        }

        private void MenuNovo_Click(object sender, RoutedEventArgs e)
        {
            ExibirMensagem("Clicou em novo");
        }

        private void MenuAbrir_Click(object sender, RoutedEventArgs e)
        {
            ExibirMensagem("Clicou em abrir");
        }

        private void MenuSalvar_Click(object sender, RoutedEventArgs e)
        {
            ExibirMensagem("Clicou em salvar");
        }

        private void MenuFechar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair?","Sair",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void MenuUsuarios_Click(object sender, RoutedEventArgs e)
        {
            ExibirMensagem("Clicou em usuários");
        }

        private void MenuGrupos_Click(object sender, RoutedEventArgs e)
        {
            ExibirMensagem("Clicou em grupos");
        }
    }
}
