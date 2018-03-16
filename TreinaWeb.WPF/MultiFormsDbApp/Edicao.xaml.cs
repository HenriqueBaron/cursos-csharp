using System;
using System.Collections.Generic;
using System.Data;
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

namespace MultiFormsDbApp
{
    /// <summary>
    /// Lógica interna para Edicao.xaml
    /// </summary>
    public partial class Edicao : Window
    {
        public Edicao()
        {
            InitializeComponent();
        }

        public Edicao(DataRowView curso)
        {
            InitializeComponent();

            if (curso != null)
            {
                txtId.Text = curso["twc_id"].ToString();
                txtNome.Text = curso["twc_nome"].ToString();
                txtDescricao.Text = curso["twc_descricao"].ToString();
            }
        }
    }
}
