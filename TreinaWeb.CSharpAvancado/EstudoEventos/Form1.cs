using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstudoEventos
{
    public partial class frmGerenciadorLatidosCachorros : Form
    {
        private GerenciadorLatidos _gerenciadorLatidos;

        public frmGerenciadorLatidosCachorros()
        {
            InitializeComponent();
            _gerenciadorLatidos = new GerenciadorLatidos();

            /* A implementação abaixo foi comentada para dar lugar ao uso de expressões lambda, 
             * implementadas no trecho abaixo dos comentários.
            //Ao instanciar a classe do gerenciador, métodos desta classe assinam o evento, no padrão
            //já visto dos delegates.
            _gerenciadorLatidos.ExcessoDecibeisEvent += QuandoExcederDecibeis;
            _gerenciadorLatidos.ExcessoDecibeisEvent += QuandoExcederDecibeisDeNovo;
            */

            /* As linhas abaixo foram criadas na aula sobre expressões lambda, mais especificamente, métodos
             * anônimos. Aqui, as linhas que estão comentadas acima foram substituídas pela implementação abaixo,
             * onde se cria diretamente a lógica do método com um método anônimo. Desta forma, os métodos
             * QuandoExcederDecibeis e QuandoExcederDecibeisDeNovo nunca são chamados e poderiam ser apagados.
             * A vantagem disso é justamente tornar o código mais limpo e uma classe não tão cheia de métodos.
             */
            _gerenciadorLatidos.ExcessoDecibeisEvent += (sender, args) =>
            {
                ExcessoDecibeisEventArgs eventArgs = (ExcessoDecibeisEventArgs)args;
                MessageBox.Show(string.Format("O cachorro passou dos limites com {0} dB.", eventArgs.IntensidadeLatido),
                        "Excesso de decibéis", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
            _gerenciadorLatidos.ExcessoDecibeisEvent += (sender, args) =>
            {
                MessageBox.Show("Você será multado", "Excesso de decibéis",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            };
        }

        private void frmGerenciadorLatidosCachorros_Load(object sender, EventArgs e)
        {
            pgbIntensidadeLatido.Value = 0;
        }

        private void btnLatir_Click(object sender, EventArgs e)
        {
            pgbIntensidadeLatido.Value = _gerenciadorLatidos.Latir();
        }

        //Quando o evento ocorrer, os dois métodos abaixo serão chamados, porque eles assinaram para o evento.
        private void QuandoExcederDecibeis(object sender, EventArgs e)
        {
            ExcessoDecibeisEventArgs eventArgs = (ExcessoDecibeisEventArgs)e;
            MessageBox.Show(string.Format("O cachorro passou dos limites com {0} dB.", eventArgs.IntensidadeLatido), "Excesso de decibéis",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void QuandoExcederDecibeisDeNovo(object sender, EventArgs e)
        {
            MessageBox.Show("Você será multado", "Excesso de decibéis",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
