using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula8_PrimeiroExercicio
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            var dialog = new CustomDialog();
            dialog.Title = "Caixa de diálogo!";
            dialog.Rotulo = "Informe um texto abaixo:";
            dialog.RotuloBotao = "OK!";

            dialog.ButtonOkClickEvent += (obj, args) =>
            {
                lblMensagem.Text = String.Format("Você informou a mensagem: \n{0}", ((CustomDialog)obj).Mensagem);
            };

            dialog.Show();
        }
    }
}
