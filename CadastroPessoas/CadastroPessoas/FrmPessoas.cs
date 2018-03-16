using CadastroPessoas.Dominio;
using CadastroPessoas.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroPessoas
{
    public partial class FrmPessoas : Form
    {
        private List<Pessoa> pessoas = new List<Pessoa>();
        private static readonly object locker = new Object();

        public FrmPessoas()
        {
            InitializeComponent();
        }

        private void FrmPessoas_Load(object sender, EventArgs e)
        {
            PreencherDataGridViewAsync();
            txbPesquisa.Text = string.Empty;

            /* Abaixo cria-se uma nova thread, que recebe um delegate para o qual foi passado o método de
             * preencher o DataGridView. Este trecho de código foi comentado para dar lugar à execução da
             * mesma operação através da chamada de uma Task. */
            /*Thread thread = new Thread(PreencherDataGridView);
            thread.Start(); */


            /* O bloco try abaixo demonstra que, diferente do caso das threads, o tratamento de exceção com
             * as tasks pode ser feita diretamente no método que a chama. Contudo, se utilizado o método
             * ContinueWith(), a exceção gerada no método anônimo criado em Run() é passada para a task seguinte.
             * Isso torna necessário o tratamento de erro na task seguinte, ou seja, na task chamada pelo método
             * ContinueWith().
             * O trecho de código abaixo (dentro do bloco try..catch) foi comentado para dar lugar à demonstração das
             * keywords async e await. */
            //try
            //{
            //    var myTask = Task<int>.Run(() =>
            //    {
            //        throw new Exception("Teste");
            //        Thread.Sleep(3000);
            //        IRepositorio<Pessoa> repositorioPessoas = new PessoaRepositorio();
            //        pessoas = repositorioPessoas.SelecionarTodos();
            //        return pessoas.Count;
            //    }).ContinueWith((taskAnterior) =>
            //    {
            //        try
            //        {
            //            dgvPessoas.Invoke((MethodInvoker)delegate
            //            {
            //                dgvPessoas.DataSource = pessoas;
            //                dgvPessoas.Refresh();
            //            });
            //            MessageBox.Show(string.Format("Há {0} registros.", taskAnterior.Result));
            //        }
            //        catch (Exception ex)
            //        {   /* Uso da propriedade Exception.InnerException: as exceções geradas por métodos em tasks
            //         * são aninhadas na InnerException da Exception que é gerada para o método chamador */
            //            MessageBox.Show(ex.InnerException.Message);
            //        }
            //    });
            //    // MessageBox.Show(string.Format("Há {0} registros", myTask.Result));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.InnerException.Message);
            //}

            /* O método TaskAwaiter.OnCompleted() recebe um delegate do tipo Action e define a ação que
             * será tomada na finalização da Task. O trecho de código abaixo foi comentado para a demonstração
             * do método ContinueWith() */
            /* var awaiter = myTask.GetAwaiter();
            awaiter.OnCompleted(() =>
            {
                dgvPessoas.DataSource = pessoas;
                dgvPessoas.Refresh();
            }); */
        }

        private async void PreencherDataGridViewAsync()
        {
            int quantidadeLinhas = await PreencherDataGridView();
            MessageBox.Show(string.Format("Há {0} registros.", quantidadeLinhas));
            dgvPessoas.Invoke((MethodInvoker)delegate
                    {
                        dgvPessoas.DataSource = pessoas;
                        dgvPessoas.Refresh();
                    });

        }

        private Task<int> PreencherDataGridView()
        {
            Thread.Sleep(2000); //Este sleep serve apenas para gerar um atraso intencional na aplicação, simulando uma tarefa mais longa

            /* A tarefa de preencher o campo desta classe com a lista de pessoas é passada para outra thread, apenas por demonstração.
             * Este método aguarda esta mesma thread finalizar utilizando o método Join(). 
             * O trecho de código abaixo foi comentado para dar lugar à demonstração das keywords async e await. */
            /* Thread thread = new Thread(PreencherListaPessoasLento);
            Thread thread2 = new Thread(PreencherListaPessoasRapido);
            thread.Start();
            thread2.Start();
            thread.Join();
            thread2.Join(); */

            return Task<int>.Run(() =>
                {
                    Thread.Sleep(3000);
                    IRepositorio<Pessoa> repositorioPessoas = new PessoaRepositorio();
                    pessoas = new List<Pessoa>();
                    List<Pessoa> pessoasTemp = repositorioPessoas.SelecionarTodos();
                    Parallel.ForEach(pessoasTemp, (pessoa) =>
                    {
                        pessoa.Nome += " - Paralelizado";
                        pessoas.Add(pessoa);
                    });
                    return pessoas.Count;
                });

            /* Como este método está rodando em uma thread diferente da thread que gerencia a UI, o método Invoke é chamado
             * para a referência deste objeto. Ele recebe um delegate no qual foi empregado um método anônimo que chama as
             * instruções e métodos necessários para este controle */
            //dgvPessoas.Invoke((MethodInvoker)delegate
            //{
            //    dgvPessoas.DataSource = pessoas;
            //    dgvPessoas.Refresh();
            //});
        }

        private void PreencherListaPessoasLento()
        {
            try
            {
                IRepositorio<Pessoa> repositorioPessoas = new PessoaRepositorio();
                List<Pessoa> pessoasLocal = repositorioPessoas.SelecionarTodos();
                lock (locker)
                {
                    foreach (Pessoa p in pessoasLocal)
                    {
                        p.Nome += " Thread 1";
                        pessoas.Add(p);
                        Thread.Sleep(300);
                    }
                }
            }
            catch (Exception ex)
            {
                ExibirErro(ex);
            }
        }

        private void PreencherListaPessoasRapido()
        {
            try
            {
                IRepositorio<Pessoa> repositorioPessoas = new PessoaRepositorio();
                List<Pessoa> pessoasLocal = repositorioPessoas.SelecionarTodos();
                lock (locker)
                {
                    foreach (Pessoa p in pessoasLocal)
                    {
                        p.Nome += " Thread 2";
                        pessoas.Add(p);
                        Thread.Sleep(100);
                    }
                }
            }
            catch (Exception ex)
            {
                ExibirErro(ex);
            }
        }

        private void ExibirErro(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            FrmAdicionarPessoa frmAdicionarPessoa = new FrmAdicionarPessoa();
            frmAdicionarPessoa.ShowDialog();
            PreencherDataGridViewAsync();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            IRepositorio<Pessoa> repositorioPessoas = new PessoaRepositorio();
            dgvPessoas.DataSource = repositorioPessoas.Selecionar(pessoa => pessoa.Nome.Contains(txbPesquisa.Text));
            dgvPessoas.Refresh();
        }
    }
}
