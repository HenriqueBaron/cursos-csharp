using CadastroPessoas.Dominio;
using CadastroPessoas.Repositorio;
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

namespace CadatroPessoas.WPF
{
    /// <summary>
    /// Lógica interna para WndCadastrarPessoa.xaml
    /// </summary>
    public partial class WndCadastrarPessoa : Window
    {
        public WndCadastrarPessoa()
        {
            InitializeComponent();
        }

        private void btnSalvarPessoa_Click(object sender, RoutedEventArgs e)
        {
            IRepositorio<Pessoa> repositorioPessoas = new PessoaRepositorio();
            Pessoa pessoa = new Pessoa()
            {
                Nome = txbNome.Text,
                Idade = Convert.ToInt32(txbIdade.Text),
                Endereco = txbEndereco.Text,
            };
            //repositorioPessoas.Adicionar(pessoa);
            Close();
        }
    }
}
