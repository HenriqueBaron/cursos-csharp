using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EstudoEventos
{
    public class GerenciadorLatidos
    {
        private int _intensidadeLatido;

        /* As linhas abaixo, comentadas, mostram a declaração manual de um evento. Elas foram comentadas
         * para dar lugar à chamada pela classe EventHandler, que nos permite omitir a declaração do delegate.
        //Primeiro, é criado um delegate com a assinatura padrão de um evento: objeto e EventArgs
        public delegate void ExcessoDecibeisHandler(object sender, EventArgs e);

        //Então, é criado um evento com o delegate declarado.
        public event ExcessoDecibeisHandler ExcessoDecibeisEvent;
        */

        //A classe EventHandler é específica para eventos e omite a declaração do delegate.
        public event EventHandler ExcessoDecibeisEvent;

        public GerenciadorLatidos()
        {
            _intensidadeLatido = 0;
        }

        public int Latir()
        {
            _intensidadeLatido += 10;
            if (_intensidadeLatido > 80)
            {
                //O método onde se deseja que o evento aconteça chama o método auxiliar de disparo.
                /* Caso se deseje gerar um evento, sem qualquer parâmetro, declara-se o new EventArgs()
                 * na chamada do método
                OnExcessoDecibeis(new EventArgs());
                */

                /* Caso seja preciso fornecer parâmetros ao evento, é preciso criar uma classe que
                 * herde EventArgs, e programá-la como desejado. No caso deste exemplo, é a classe
                 * ExcessoDecibeisEventArgs
                 */
                ExcessoDecibeisEventArgs e = new ExcessoDecibeisEventArgs
                {
                    IntensidadeLatido = _intensidadeLatido
                };
                OnExcessoDecibeis(e);
            }
            return _intensidadeLatido;
        }

        //Este método é um assistente que serve para centralizar a chamada dos eventos.
        //Dentro dele está o gatilho do evento, que é disparado se houver algum assinante (ou seja, se
        //a instância do evento não for nula.
        //Ele geralmente é público ou protegido e também virtual, para que outras classes estendam ou
        //alterem seu comportamento.
        protected virtual void OnExcessoDecibeis(EventArgs e)
        {
            ExcessoDecibeisEvent?.Invoke(this, e);
        }
    }
}
