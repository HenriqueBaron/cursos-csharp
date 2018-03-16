using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableLayoutPanelForm
{
    public partial class frmTableLayout : Form
    {
        public frmTableLayout()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
                Label lblResultado = new Label();
                lblResultado.AutoSize = true;

                if (txtUsuario.Text.ToLower() == "admin" && txtSenha.Text == "123")
                {
                    lblResultado.Text = "Bem vindo, admin.";
                }
                else
                {
                    lblResultado.Text = "Usuário ou senha inválido.";
                }
                tableLayoutPanel1.Controls.Add(lblResultado, 1, 3);
            } catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
    }
}
