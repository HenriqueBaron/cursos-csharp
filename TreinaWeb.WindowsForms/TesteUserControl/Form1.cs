using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteUserControl
{
    public partial class FrmLogon : Form
    {
        public FrmLogon()
        {
            InitializeComponent();
        }

        private void FrmLogon_Load(object sender, EventArgs e)
        {
            loginControl.ServerName = @".\SQLEXPRESS";
            loginControl.Database = "AdventureWorks2012";
            loginControl.DbWindowsAuthentication = false;
            loginControl.DbUserName = "sa";
            loginControl.DbPassword = "hb_19079303";

            loginControl.Table = "Users";
            loginControl.Columns = new string[] { "UserId", "Name", "[User]", "Password" };
        }

        private void loginControl_Authentication(object sender, EventArgs e)
        {
            if (loginControl.UserId > 0)
                lblUsuarioAtual.Text = "Acessado por " + loginControl.UserName;
            else
                lblUsuarioAtual.Text = "Usuário ou senha inválidos.";
        }
    }
}
