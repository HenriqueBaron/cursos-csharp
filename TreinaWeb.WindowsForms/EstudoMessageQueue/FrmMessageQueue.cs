using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoMessageQueue
{
    public partial class FrmMessageQueue : Form
    {
        public FrmMessageQueue()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string queueName = @".\private$\minhaQueue";

            try
            {
                MessageQueue queue;
                if (MessageQueue.Exists(queueName))
                    queue = new MessageQueue(queueName);
                else
                    queue = MessageQueue.Create(queueName);

                queue.Send(txtMensagem.Text);
                txtMensagem.Text = string.Empty;
                lblResultado.Text = "Mensagem enviada.";
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Erro: " + ex.Message;
            }
        }
    }
}
