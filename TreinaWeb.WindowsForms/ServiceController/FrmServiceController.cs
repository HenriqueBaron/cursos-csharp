using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoServiceController
{
    public partial class FrmServiceController : Form
    {
        public FrmServiceController()
        {
            InitializeComponent();
        }

        private void FrmServiceController_Load(object sender, EventArgs e)
        {
            CarregarServicos();

            btnIniciar.Enabled = false;
            btnPausar.Enabled = false;
            btnContinuar.Enabled = false;
            btnPausar.Enabled = false;
        }

        private void CarregarServicos()
        {
            foreach (ServiceController service in ServiceController.GetServices())
            {
                lstProcessos.Items.Add(service.DisplayName);
            }
            lstProcessos.Sorted = true;
        }

        private void lstProcessos_SelectedValueChanged(object sender, EventArgs e)
        {
            ServiceController service = ObterServicoSelecionado();
            AtualizarServico(service);
        }

        private ServiceController ObterServicoSelecionado()
        {
            string serviceName = lstProcessos.SelectedItem.ToString();
            return new ServiceController(serviceName);
        }

        private void AtualizarServico(ServiceController service)
        {
            btnIniciar.Enabled = false;
            btnPausar.Enabled = false;
            btnContinuar.Enabled = false;
            btnParar.Enabled = false;

            if (service.Status == ServiceControllerStatus.Running)
            {
                if (service.CanPauseAndContinue) btnPausar.Enabled = true;
                if (service.CanStop) btnParar.Enabled = true;
            }
            else if (service.Status == ServiceControllerStatus.Paused)
            {
                if (service.CanPauseAndContinue) btnContinuar.Enabled = true;
            }
            else if (service.Status == ServiceControllerStatus.Stopped)
                btnIniciar.Enabled = true;

            lblResultado.Text = "Status: " + service.Status.ToString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            ServiceController service = ObterServicoSelecionado();
            service.Start();
            AtualizarServico(service);
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            ServiceController service = ObterServicoSelecionado();
            service.Pause();
            AtualizarServico(service);
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            ServiceController service = ObterServicoSelecionado();
            service.Continue();
            AtualizarServico(service);
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            ServiceController service = ObterServicoSelecionado();
            service.Stop();
            AtualizarServico(service);
        }
    }
}
