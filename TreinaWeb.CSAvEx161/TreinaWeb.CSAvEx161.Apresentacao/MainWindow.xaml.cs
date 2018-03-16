using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Xml;
using TreinaWeb.CSAvEx161.Apresentacao.Repositorio;

namespace TreinaWeb.CSAvEx161.Apresentacao
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

        private void WndMain_Loaded(object sender, RoutedEventArgs e)
        {
            // Dispara o carregamento dos itens da lista.
            CarregarItensAsync();
        }

        private async void CarregarItensAsync()
        {
            // Método assíncrono que adiciona os itens à lista, em uma task separada. Por isso, é preciso chamar o método
            // Control.Dispatcher.Invoke para executar ações sobre o controle em uma thread separada.
            await Task.Run(() =>
            {
                IRepositorioItem repositorioItem = new RepositorioItemXML();
                repositorioItem.SelecionarTodos((novoItem) =>
                {
                    dgItens.Dispatcher.Invoke(() =>
                    {
                        dgItens.Items.Add(novoItem);
                    });
                });
            });
        }
    }
}
