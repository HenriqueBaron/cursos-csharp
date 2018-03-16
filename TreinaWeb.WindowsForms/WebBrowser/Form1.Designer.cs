namespace WebBrowser
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.wbrBrowser = new System.Windows.Forms.WebBrowser();
            this.btnIr = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço:";
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(74, 6);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(662, 20);
            this.txtUrl.TabIndex = 1;
            // 
            // wbrBrowser
            // 
            this.wbrBrowser.Location = new System.Drawing.Point(12, 32);
            this.wbrBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrBrowser.Name = "wbrBrowser";
            this.wbrBrowser.Size = new System.Drawing.Size(724, 541);
            this.wbrBrowser.TabIndex = 2;
            this.wbrBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbrBrowser_Navigated);
            // 
            // btnIr
            // 
            this.btnIr.Location = new System.Drawing.Point(12, 579);
            this.btnIr.Name = "btnIr";
            this.btnIr.Size = new System.Drawing.Size(75, 23);
            this.btnIr.TabIndex = 3;
            this.btnIr.Text = "Ir";
            this.btnIr.UseVisualStyleBackColor = true;
            this.btnIr.Click += new System.EventHandler(this.btnIr_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(93, 579);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(75, 23);
            this.btnParar.TabIndex = 4;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(174, 579);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 5;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 609);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnIr);
            this.Controls.Add(this.wbrBrowser);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.WebBrowser wbrBrowser;
        private System.Windows.Forms.Button btnIr;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnAtualizar;
    }
}

