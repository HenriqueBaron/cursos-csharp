﻿namespace Controles
{
    partial class frmCommonDialogs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAbrirArquivo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtTextoArquivo = new System.Windows.Forms.TextBox();
            this.nicNotificacao = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // btnAbrirArquivo
            // 
            this.btnAbrirArquivo.Location = new System.Drawing.Point(48, 12);
            this.btnAbrirArquivo.Name = "btnAbrirArquivo";
            this.btnAbrirArquivo.Size = new System.Drawing.Size(75, 23);
            this.btnAbrirArquivo.TabIndex = 0;
            this.btnAbrirArquivo.Text = "&Abrir Arquivo";
            this.btnAbrirArquivo.UseVisualStyleBackColor = true;
            this.btnAbrirArquivo.Click += new System.EventHandler(this.btnAbrirArquivo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(199, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Sa&lvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtTextoArquivo
            // 
            this.txtTextoArquivo.Location = new System.Drawing.Point(12, 46);
            this.txtTextoArquivo.Multiline = true;
            this.txtTextoArquivo.Name = "txtTextoArquivo";
            this.txtTextoArquivo.Size = new System.Drawing.Size(310, 240);
            this.txtTextoArquivo.TabIndex = 2;
            // 
            // nicNotificacao
            // 
            this.nicNotificacao.Text = "notifyIcon1";
            this.nicNotificacao.Visible = true;
            this.nicNotificacao.DoubleClick += new System.EventHandler(this.nicNotificacao_DoubleClick);
            // 
            // frmCommonDialogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 298);
            this.Controls.Add(this.txtTextoArquivo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnAbrirArquivo);
            this.Name = "frmCommonDialogs";
            this.Text = "Estudo de Common Dialogs";
            this.Load += new System.EventHandler(this.frmCommonDialogs_Load);
            this.Resize += new System.EventHandler(this.frmCommonDialogs_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirArquivo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtTextoArquivo;
        private System.Windows.Forms.NotifyIcon nicNotificacao;
    }
}