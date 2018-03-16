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
using System.Windows.Shapes;

namespace MultiFormsApp
{
    /// <summary>
    /// Lógica interna para SegundaJanela.xaml
    /// </summary>
    public partial class SegundaJanela : Window
    {
        public SegundaJanela()
        {
            InitializeComponent();
        }

        public SegundaJanela(string valor)
        {
            InitializeComponent();

            txtTexto.Text += valor;
        }
    }
}
