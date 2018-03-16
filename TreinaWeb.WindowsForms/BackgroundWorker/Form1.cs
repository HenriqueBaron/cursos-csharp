using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TesteBackgroundWorker
{
    public partial class frmBackgroundWorker : Form
    {
        public frmBackgroundWorker()
        {
            InitializeComponent();
        }

        private void frmBackgroundWorker_Load(object sender, EventArgs e)
        {
            bcwWorker.WorkerReportsProgress = true;
            bcwWorker.WorkerSupportsCancellation = true;
            lblStatus.Text = "";
        }

        private void bcwWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 0; i <= 10; i++)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    Thread.Sleep(500);
                    worker.ReportProgress(i * 10);
                }
            }
        }

        private void bcwWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (pgbOperacao.InvokeRequired)
            {
                pgbOperacao.Invoke((MethodInvoker)delegate { pgbOperacao.Value = e.ProgressPercentage; });
            }
            else pgbOperacao.Value = e.ProgressPercentage;
        }

        private void bcwWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled) lblStatus.Text = "Cancelado!";
            else if (e.Error != null) lblStatus.Text = "Erro: " + e.Error.Message;
            else lblStatus.Text = "Finalizado!";
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (!bcwWorker.IsBusy) bcwWorker.RunWorkerAsync();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (bcwWorker.WorkerSupportsCancellation) bcwWorker.CancelAsync();
        }
    }
}
