using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessEstudo
{
    public partial class FrmProcess : Form
    {
        public FrmProcess()
        {
            InitializeComponent();
        }

        private void btnIniciarParar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(process1.StartInfo.FileName))
                {
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.UseShellExecute = false;
                    startInfo.FileName = "notepad.exe";
                    startInfo.CreateNoWindow = true;

                    process1.StartInfo = startInfo;
                    process1.Start();
                }
                else
                {
                    if (process1.HasExited) process1.Start();
                    else process1.Kill();
                }

                lblProcesso.Text = "Processo: " + process1.ProcessName;
                lblIniciado.Text = "Iniciado: " + process1.StartTime;
                if (process1.HasExited) lblFinalizado.Text = "Finalizado: " + process1.ExitTime;
                lblMemoriaFisica.Text = "Memória Física: " + process1.PeakWorkingSet64;
                lblMemoriaVirtual.Text = "Memória Virtual: " + process1.PeakVirtualMemorySize64;
                lblProcessador.Text = "Processador: " + process1.TotalProcessorTime;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
