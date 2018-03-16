namespace Controles
{
    partial class frmListView
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
            this.lvwDados = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lvwDados
            // 
            this.lvwDados.Location = new System.Drawing.Point(12, 12);
            this.lvwDados.Name = "lvwDados";
            this.lvwDados.Size = new System.Drawing.Size(577, 444);
            this.lvwDados.TabIndex = 0;
            this.lvwDados.UseCompatibleStateImageBehavior = false;
            this.lvwDados.View = System.Windows.Forms.View.Details;
            // 
            // frmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 468);
            this.Controls.Add(this.lvwDados);
            this.Name = "frmListView";
            this.Text = "Estudo ListView";
            this.Load += new System.EventHandler(this.frmListView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwDados;
    }
}