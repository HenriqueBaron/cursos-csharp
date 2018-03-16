using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace BindingCollectionApp
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            ObservableCollection<Pessoa> pessoas = new ObservableCollection<Pessoa>();

            pessoas.Add(new Pessoa()
            {
                Id = 1,
                Nome = "Henrique",
                Email = "henrique.baron@gmail.com",
                Sexo = Pessoa.PessoaSexo.Masculino
            });

            pessoas.Add(new Pessoa()
            {
                Id = 2,
                Nome = "Pedro",
                Email = "pedro@outlook.com",
                Sexo = Pessoa.PessoaSexo.Masculino
            });

            pessoas.Add(new Pessoa()
            {
                Id = 3,
                Nome = "Maria",
                Email = "maria@yahoo.com",
                Sexo = Pessoa.PessoaSexo.Feminino
            });

            pessoas.Add(new Pessoa()
            {
                Id = 4,
                Nome = "João",
                Email = "joao@outlook.com",
                Sexo = Pessoa.PessoaSexo.Masculino
            });

            pessoas.Add(new Pessoa()
            {
                Id = 5,
                Nome = "Adriana",
                Email = "adriana@gmail.com",
                Sexo = Pessoa.PessoaSexo.Feminino
            });

            lstPessoas.ItemsSource = pessoas;
        }
    }
}
