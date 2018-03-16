using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmControles : Form
    {
        public frmControles()
        {
            InitializeComponent();
        }

        private void frmControles_Load(object sender, EventArgs e)
        {
            CarregarListControlsVendedores();
            CarregarDomainUpDown();
            dtpData.Format = DateTimePickerFormat.Custom;
            dtpData.CustomFormat = "dd/MM/yyyy HH:mm";
            //dtpData.ShowUpDown = true;
        }

        private void btnExibirNome_Click(object sender, EventArgs e)
        {
            txtNomeControle.Text = ((Button)sender).Name;
        }

        private void chbEstado_CheckStateChanged(object sender, EventArgs e)
        {
            chkEstado.Text = string.Format("O estado é {0}", ((CheckBox)sender).CheckState);
        }

        #region ListControls

        private void CarregarListControlsMeses()
        {
            string[] meses =
            {
                "Janeiro",
                "Fevereiro",
                "Março",
                "Abril",
                "Maio",
                "Junho",
                "Julho",
                "Agosto",
                "Setembro",
                "Outubro",
                "Novembro",
                "Dezembro"
            };

            cboTeste.Items.AddRange(meses);
            lstTeste.Items.AddRange(meses);
            chlTeste.Items.AddRange(meses);

            int indice = cboTeste.FindString("Julho");
        }

        private void CarregarListControlsVendedores()
        {
            DataTable vendedores = new DataTable();
            DataColumn column;
            DataRow row;

            column = new DataColumn("id");
            //column.ColumnName = "id" //Equivalente ao construtor acima
            vendedores.Columns.Add(column);

            column = new DataColumn("nome");
            vendedores.Columns.Add(column);

            for (int i = 0; i < 10; i++)
            {
                row = vendedores.NewRow();
                row["id"] = i;
                row["nome"] = "Vendedor " + i;
                vendedores.Rows.Add(row);
            }

            cboTeste.DataSource = vendedores;
            cboTeste.DisplayMember = "nome";
            cboTeste.ValueMember = "id";

            lstTeste.DataSource = vendedores;
            lstTeste.DisplayMember = "nome";
            lstTeste.ValueMember = "id";

            /* Em tese, as propriedades relacionadas ao DataSource não estão disponíveis para o CheckedListBox. Contudo, é
             * possível descomentar o trecho de código abaixo e ele deve funcionar também. Estas propriedades não são exibidas
             * no grid de propriedades, nem no IntelliSense. */
            //chlTeste.DataSource = vendedores;
            //chlTeste.DisplayMember = "nome";
            //chlTeste.ValueMember = "id";
        }

        #endregion

        private void CarregarDomainUpDown()
        {
            dudNiveisUsuarios.Text = "Texto inicial";

            string[] niveisUsuarios =
            {
                "Administrador",
                "Programador",
                "Manutenção",
                "Operador"
            };

            dudNiveisUsuarios.Items.AddRange(niveisUsuarios);
        }

        private void txtTextoAValidar_Validated(object sender, EventArgs e)
        {
            if (txtTextoAValidar.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtTextoAValidar, "Este campo deve ser preenchido");
            }
            else
            {
                errorProvider1.SetError(txtTextoAValidar, "");
            }
        }
    }
}
