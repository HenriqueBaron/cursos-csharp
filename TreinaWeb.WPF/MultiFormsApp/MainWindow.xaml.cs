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

namespace MultiFormsApp
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

        private void btnSemParametro_Click(object sender, RoutedEventArgs e)
        {
            SegundaJanela janela = new SegundaJanela();
            janela.Show();
        }

        private void btnComParametro_Click(object sender, RoutedEventArgs e)
        {
            SegundaJanela janela = new SegundaJanela("Aluno");
            janela.Show();
        }

        private void btnCaixaDialogo_Click(object sender, RoutedEventArgs e)
        {
            SegundaJanela janela = new SegundaJanela("Diálogo");
            janela.ShowDialog();
        }

        private void btnRespostaDialogo_Click(object sender, RoutedEventArgs e)
        {
            TerceiraJanela janela = new TerceiraJanela();
            bool? result = janela.ShowDialog(); //O tipo com o ponto de interrogação instancia um tipo Nullable<T>. Ou seja, esta variável pode receber o valor null.

            if (result.HasValue && result == true)
            {
                MessageBox.Show("Clicou em OK");
            }
            else
            {
                MessageBox.Show("Não clicou em OK");
            }
        }
    }
}
