namespace TreinaWeb.CSAvEx162.Apresentacao
{
    partial class FrmPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnExcluirVenda = new System.Windows.Forms.Button();
            this.btnEditarVenda = new System.Windows.Forms.Button();
            this.btnInserirVenda = new System.Windows.Forms.Button();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.IdVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.btnEditarProduto = new System.Windows.Forms.Button();
            this.btnInserirProduto = new System.Windows.Forms.Button();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.IdProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnExcluirVenda);
            this.groupBox1.Controls.Add(this.btnEditarVenda);
            this.groupBox1.Controls.Add(this.btnInserirVenda);
            this.groupBox1.Controls.Add(this.dgvVendas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendas";
            // 
            // btnExcluirVenda
            // 
            this.btnExcluirVenda.Location = new System.Drawing.Point(714, 85);
            this.btnExcluirVenda.Name = "btnExcluirVenda";
            this.btnExcluirVenda.Size = new System.Drawing.Size(111, 26);
            this.btnExcluirVenda.TabIndex = 4;
            this.btnExcluirVenda.Text = "Excluir";
            this.btnExcluirVenda.UseVisualStyleBackColor = true;
            this.btnExcluirVenda.Click += new System.EventHandler(this.btnExcluirVenda_Click);
            // 
            // btnEditarVenda
            // 
            this.btnEditarVenda.Location = new System.Drawing.Point(714, 53);
            this.btnEditarVenda.Name = "btnEditarVenda";
            this.btnEditarVenda.Size = new System.Drawing.Size(111, 26);
            this.btnEditarVenda.TabIndex = 3;
            this.btnEditarVenda.Text = "Editar";
            this.btnEditarVenda.UseVisualStyleBackColor = true;
            this.btnEditarVenda.Click += new System.EventHandler(this.btnEditarVenda_Click);
            // 
            // btnInserirVenda
            // 
            this.btnInserirVenda.Location = new System.Drawing.Point(714, 21);
            this.btnInserirVenda.Name = "btnInserirVenda";
            this.btnInserirVenda.Size = new System.Drawing.Size(111, 26);
            this.btnInserirVenda.TabIndex = 2;
            this.btnInserirVenda.Text = "Inserir";
            this.btnInserirVenda.UseVisualStyleBackColor = true;
            this.btnInserirVenda.Click += new System.EventHandler(this.btnInserirVenda_Click);
            // 
            // dgvVendas
            // 
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdVenda,
            this.DataVenda,
            this.ValorVenda});
            this.dgvVendas.Location = new System.Drawing.Point(6, 21);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.RowTemplate.Height = 24;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(702, 228);
            this.dgvVendas.TabIndex = 1;
            // 
            // IdVenda
            // 
            this.IdVenda.DataPropertyName = "Id";
            this.IdVenda.HeaderText = "Id";
            this.IdVenda.Name = "IdVenda";
            this.IdVenda.ReadOnly = true;
            this.IdVenda.Visible = false;
            // 
            // DataVenda
            // 
            this.DataVenda.DataPropertyName = "Data";
            this.DataVenda.HeaderText = "Data";
            this.DataVenda.Name = "DataVenda";
            this.DataVenda.ReadOnly = true;
            // 
            // ValorVenda
            // 
            this.ValorVenda.DataPropertyName = "Valor";
            this.ValorVenda.HeaderText = "Valor";
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExcluirProduto);
            this.groupBox2.Controls.Add(this.btnEditarProduto);
            this.groupBox2.Controls.Add(this.btnInserirProduto);
            this.groupBox2.Controls.Add(this.dgvProdutos);
            this.groupBox2.Location = new System.Drawing.Point(12, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 255);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produtos";
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Location = new System.Drawing.Point(714, 85);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(111, 26);
            this.btnExcluirProduto.TabIndex = 8;
            this.btnExcluirProduto.Text = "Excluir";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluirProduto_Click);
            // 
            // btnEditarProduto
            // 
            this.btnEditarProduto.Location = new System.Drawing.Point(714, 53);
            this.btnEditarProduto.Name = "btnEditarProduto";
            this.btnEditarProduto.Size = new System.Drawing.Size(111, 26);
            this.btnEditarProduto.TabIndex = 7;
            this.btnEditarProduto.Text = "Editar";
            this.btnEditarProduto.UseVisualStyleBackColor = true;
            this.btnEditarProduto.Click += new System.EventHandler(this.btnEditarProduto_Click);
            // 
            // btnInserirProduto
            // 
            this.btnInserirProduto.Location = new System.Drawing.Point(714, 21);
            this.btnInserirProduto.Name = "btnInserirProduto";
            this.btnInserirProduto.Size = new System.Drawing.Size(111, 26);
            this.btnInserirProduto.TabIndex = 6;
            this.btnInserirProduto.Text = "Inserir";
            this.btnInserirProduto.UseVisualStyleBackColor = true;
            this.btnInserirProduto.Click += new System.EventHandler(this.btnInserirProduto_Click);
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProduto,
            this.NomeProduto,
            this.PrecoProduto});
            this.dgvProdutos.Location = new System.Drawing.Point(6, 21);
            this.dgvProdutos.MultiSelect = false;
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowTemplate.Height = 24;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(702, 228);
            this.dgvProdutos.TabIndex = 5;
            // 
            // IdProduto
            // 
            this.IdProduto.DataPropertyName = "Id";
            this.IdProduto.HeaderText = "Id";
            this.IdProduto.Name = "IdProduto";
            this.IdProduto.ReadOnly = true;
            this.IdProduto.Visible = false;
            // 
            // NomeProduto
            // 
            this.NomeProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NomeProduto.DataPropertyName = "Nome";
            this.NomeProduto.HeaderText = "Nome";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.Width = 74;
            // 
            // PrecoProduto
            // 
            this.PrecoProduto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PrecoProduto.DataPropertyName = "Preco";
            this.PrecoProduto.HeaderText = "Preço";
            this.PrecoProduto.Name = "PrecoProduto";
            this.PrecoProduto.ReadOnly = true;
            this.PrecoProduto.Width = 74;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 550);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrincipal";
            this.Text = "Gerenciador de Vendas";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.Button btnEditarVenda;
        private System.Windows.Forms.Button btnInserirVenda;
        private System.Windows.Forms.Button btnExcluirVenda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.Button btnEditarProduto;
        private System.Windows.Forms.Button btnInserirProduto;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecoProduto;
    }
}

