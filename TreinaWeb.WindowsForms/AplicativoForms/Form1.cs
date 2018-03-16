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

namespace AplicativoForms
{
    public delegate void Update(int i);

    public partial class FrmExemploThread : Form
    {
        Thread tarefa;

        public FrmExemploThread()
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("pt-BR");
            InitializeComponent();
        }

        private void FrmExemploThread_Load(object sender, EventArgs e)
        {
            timer1.Start();
            tarefa = new Thread(new ThreadStart(PreencherProgresso));
        }

        private void PreencherProgresso()
        {
            for (int i = 0; i < 100; i++)
            {
                pgbProgresso.Invoke(new Update(AtualizarProgresso), new object[] { i });
                Thread.Sleep(100);
            }
        }

        private void AtualizarProgresso(int progresso)
        {
            pgbProgresso.Value = progresso;
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            tarefa.IsBackground = true;
            tarefa.Priority = ThreadPriority.Lowest;
            tarefa.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHorario.Text = "Horário: " + DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
