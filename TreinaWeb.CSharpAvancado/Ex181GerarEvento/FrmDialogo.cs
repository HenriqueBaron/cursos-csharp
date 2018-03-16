using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex181GerarEvento
{
    public partial class FrmDialogo : Form
    {
        // Os controles desejados são definidos como membros da classe. Assim posso acessá-los por toda a classe.
        private Label lblTitulo;
        private TextBox txbMensagem;
        private Button btnOK;

        // O evento que desejo gerar é declarado como campo da classe também.
        public event EventHandler ButtonOkClickEvent;

        public FrmDialogo()
        {
            // Cria-se uma lista de controles, para posteriormente adicionar ao form.
            List<Control> controles = new List<Control>();

            // Ao instanciar a classe é que os campos relativos aos controles são inicializados.
            lblTitulo = new Label();
            txbMensagem = new TextBox();
            btnOK = new Button();

            // O método SuspendLayout() suspende a lógica refente à UI. É conveniente para a execução das linhas onde os controles
            // são parametrizados.
            SuspendLayout();

            // Parâmetros são passados a cada um dos controles. Os valores específicos de tamanho e posição foram copiados da resposta
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(13, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(35, 13);
            lblTitulo.TabIndex = 0;
            controles.Add(lblTitulo); // Após parametrizar, o controle é adicionado à lista.

            txbMensagem.Location = new Point(13, 30);
            txbMensagem.Name = "txbMensagem";
            txbMensagem.Size = new Size(436, 20);
            txbMensagem.TabIndex = 1;
            controles.Add(txbMensagem);

            btnOK.Location = new Point(373, 67);
            btnOK.Name = "btnOk";
            btnOK.Size = new Size(75, 23);
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            controles.Add(btnOK);

            /* Aqui, executa-se um procedimento de assinatura para evento. O construtor da classe deste Form assina o 
             * evento Click do botão OK, para que alguma ação seja tomada. Observar que a lógica deve ser executada no 
             * evento Click do botão é declarada como um método anônimo. Isto é equivalente a declarar nesta classe um 
             * método com as instruções que estão dentro da expressão lambda e fazer a assinatura da linha de assinatura
             * do evento Click do botão OK inscrever tal método.*/

            // 1. Assinatura para o evento Click do botão OK
            btnOK.Click += (object sender, EventArgs e) =>
            {
                 // 2. Os parâmetros necessários são passados ao evento definido no começo da classe.
                e = new ButtonOkClickEventArgs()
                {
                    Mensagem = txbMensagem.Text
                };

                // 3. O método que executa o delegate do evento ButtonOkClickEvent é disparado.
                OnButtonOkClick(e);
            };

            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 106);
            Controls.AddRange(controles.ToArray());
            ResumeLayout(false);
            PerformLayout();
            Text = "Diálogo";
            StartPosition = FormStartPosition.CenterScreen;
            Show();

        }
        
        /// <summary>
        /// Este método dispara o evento declarado no início da classe.
        /// </summary>
        /// <param name="e">Argumentos do evento a ser gerado. </param>
        protected virtual void OnButtonOkClick(EventArgs e)
        {
            ButtonOkClickEvent?.Invoke(this, e);

            this.Close();
        }
    }
}
