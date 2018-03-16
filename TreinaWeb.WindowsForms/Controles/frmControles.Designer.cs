namespace Controles
{
    partial class frmControles
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
            this.components = new System.ComponentModel.Container();
            this.btnExibirNome = new System.Windows.Forms.Button();
            this.txtNomeControle = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.cboTeste = new System.Windows.Forms.ComboBox();
            this.lstTeste = new System.Windows.Forms.ListBox();
            this.chlTeste = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.dudNiveisUsuarios = new System.Windows.Forms.DomainUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTextoAValidar = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExibirNome
            // 
            this.btnExibirNome.Location = new System.Drawing.Point(226, 10);
            this.btnExibirNome.Name = "btnExibirNome";
            this.btnExibirNome.Size = new System.Drawing.Size(75, 23);
            this.btnExibirNome.TabIndex = 0;
            this.btnExibirNome.Text = "Exibir nome";
            this.btnExibirNome.UseVisualStyleBackColor = true;
            this.btnExibirNome.Click += new System.EventHandler(this.btnExibirNome_Click);
            // 
            // txtNomeControle
            // 
            this.txtNomeControle.Location = new System.Drawing.Point(12, 12);
            this.txtNomeControle.Name = "txtNomeControle";
            this.txtNomeControle.Size = new System.Drawing.Size(208, 20);
            this.txtNomeControle.TabIndex = 1;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(331, 14);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(126, 17);
            this.chkEstado.TabIndex = 2;
            this.chkEstado.Text = "Estado do CheckBox";
            this.chkEstado.ThreeState = true;
            this.chkEstado.UseVisualStyleBackColor = true;
            this.chkEstado.CheckStateChanged += new System.EventHandler(this.chbEstado_CheckStateChanged);
            // 
            // cboTeste
            // 
            this.cboTeste.FormattingEnabled = true;
            this.cboTeste.Location = new System.Drawing.Point(12, 90);
            this.cboTeste.Name = "cboTeste";
            this.cboTeste.Size = new System.Drawing.Size(121, 21);
            this.cboTeste.TabIndex = 3;
            // 
            // lstTeste
            // 
            this.lstTeste.FormattingEnabled = true;
            this.lstTeste.Location = new System.Drawing.Point(139, 90);
            this.lstTeste.Name = "lstTeste";
            this.lstTeste.Size = new System.Drawing.Size(120, 95);
            this.lstTeste.TabIndex = 4;
            // 
            // chlTeste
            // 
            this.chlTeste.FormattingEnabled = true;
            this.chlTeste.Location = new System.Drawing.Point(265, 90);
            this.chlTeste.Name = "chlTeste";
            this.chlTeste.Size = new System.Drawing.Size(120, 94);
            this.chlTeste.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "List controls:";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(12, 205);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(200, 20);
            this.dtpData.TabIndex = 7;
            // 
            // dudNiveisUsuarios
            // 
            this.dudNiveisUsuarios.Location = new System.Drawing.Point(12, 237);
            this.dudNiveisUsuarios.Name = "dudNiveisUsuarios";
            this.dudNiveisUsuarios.Size = new System.Drawing.Size(200, 20);
            this.dudNiveisUsuarios.TabIndex = 8;
            this.dudNiveisUsuarios.Text = "domainUpDown1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTextoAValidar);
            this.groupBox1.Location = new System.Drawing.Point(226, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 52);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Demonstração do ErrorProvider";
            // 
            // txtTextoAValidar
            // 
            this.txtTextoAValidar.Location = new System.Drawing.Point(6, 19);
            this.txtTextoAValidar.Name = "txtTextoAValidar";
            this.txtTextoAValidar.Size = new System.Drawing.Size(242, 20);
            this.txtTextoAValidar.TabIndex = 10;
            this.txtTextoAValidar.Validated += new System.EventHandler(this.txtTextoAValidar_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 271);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dudNiveisUsuarios);
            this.Controls.Add(this.dtpData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chlTeste);
            this.Controls.Add(this.lstTeste);
            this.Controls.Add(this.cboTeste);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.txtNomeControle);
            this.Controls.Add(this.btnExibirNome);
            this.Name = "frmControles";
            this.Text = "Estudo Controles";
            this.Load += new System.EventHandler(this.frmControles_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExibirNome;
        private System.Windows.Forms.TextBox txtNomeControle;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.ComboBox cboTeste;
        private System.Windows.Forms.ListBox lstTeste;
        private System.Windows.Forms.CheckedListBox chlTeste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.DomainUpDown dudNiveisUsuarios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTextoAValidar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

