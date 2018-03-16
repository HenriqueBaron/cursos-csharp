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
    /// Interação lógica para TreinamentoLista.xam
    /// </summary>
    public partial class TreinamentoLista : UserControl
    {
        public TreinamentoLista()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void dgCursos_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dgCursos.SelectedItem != null)
            {
                var curso = dgCursos.SelectedItem as twc_cursos;

                if (curso != null)
                {
                    TreinamentoEdicao frm = new TreinamentoEdicao(curso);

                    MainWindow window = Window.GetWindow(this) as MainWindow;
                    window.stkContent.Content = frm;
                }
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            TreinaWebWPFEntities entities = new TreinaWebWPFEntities();
            dgCursos.ItemsSource = entities.twc_cursos.OrderBy(c => c.twc_nome).ToList();
        }
    }
}
