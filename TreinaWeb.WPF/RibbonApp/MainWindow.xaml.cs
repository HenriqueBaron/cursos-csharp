using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RibbonApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : RibbonWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RibbonAbrir_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Application Menu - Abrir");
        }

        private void RibbonSalvar_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Application Menu - Salvar");
        }

        private void RibbonSair_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
