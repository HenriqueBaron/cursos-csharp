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
    /// Interação lógica para TreinamentoEdicao.xam
    /// </summary>
    public partial class TreinamentoEdicao : UserControl
    {
        private twc_cursos cursoAtual;

        public TreinamentoEdicao( twc_cursos curso)
        {
            InitializeComponent();

            cursoAtual = curso;

            stkCampos.DataContext = cursoAtual;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Content = null;
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente salvar?", "Atenção", MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                TreinaWebWPFEntities entities = new TreinaWebWPFEntities();

                if (cursoAtual.twc_id != 0)
                {
                    entities.Entry(cursoAtual).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    entities.Entry(cursoAtual).State = System.Data.Entity.EntityState.Added;
                }

                entities.SaveChanges();
            }
        }
    }
}
