namespace TesteUserControl
{
    partial class FrmLogon
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginControl = new LoginControl.Login();
            this.lblUsuarioAtual = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginControl
            // 
            this.loginControl.Columns = null;
            this.loginControl.Database = null;
            this.loginControl.DbConnectionString = null;
            this.loginControl.DbPassword = null;
            this.loginControl.DbUserName = null;
            this.loginControl.Location = new System.Drawing.Point(5, 4);
            this.loginControl.LoginPassword = "";
            this.loginControl.LoginUser = "";
            this.loginControl.Name = "loginControl";
            this.loginControl.SelectQuery = null;
            this.loginControl.ServerName = null;
            this.loginControl.Size = new System.Drawing.Size(240, 86);
            this.loginControl.TabIndex = 0;
            this.loginControl.Table = null;
            this.loginControl.UserName = null;
            this.loginControl.Authentication += new LoginControl.AuthenticationEventHandler(this.loginControl_Authentication);
            // 
            // lblUsuarioAtual
            // 
            this.lblUsuarioAtual.AutoSize = true;
            this.lblUsuarioAtual.Location = new System.Drawing.Point(12, 93);
            this.lblUsuarioAtual.Name = "lblUsuarioAtual";
            this.lblUsuarioAtual.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioAtual.TabIndex = 1;
            // 
            // FrmLogon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 121);
            this.Controls.Add(this.lblUsuarioAtual);
            this.Controls.Add(this.loginControl);
            this.Name = "FrmLogon";
            this.Text = "Logon";
            this.Load += new System.EventHandler(this.FrmLogon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LoginControl.Login loginControl;
        private System.Windows.Forms.Label lblUsuarioAtual;
    }
}

