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
    public partial class FrmMainWindow : Form
    {
        public FrmMainWindow()
        {
            InitializeComponent(); 
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            /* O form que exibe a caixa de diálogo que pede o texto é chamado, e então é realizada a assinatura para o 
             * evento que repassa a mensagem digitada na caixa de diálogo. Reparar que neste caso um método anônimo com uma
             * expressão lambda também foi utilizado.*/

            FrmDialogo dialogo = new FrmDialogo();
            dialogo.ButtonOkClickEvent += (eventSender, eventE) =>
            {
                ButtonOkClickEventArgs args = (ButtonOkClickEventArgs)eventE;
                lblMensagem.Text = args.Mensagem;
            };
        }
    }
}
