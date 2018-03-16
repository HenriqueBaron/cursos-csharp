using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesImpressao
{
    public partial class FrmImpressao : Form
    {
        string printText;

        public FrmImpressao()
        {
            InitializeComponent();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument1.DocumentName = "TreinaWeb.docx";
                //printDocument1.PrinterSettings.PrintFileName = "Send to OneNote 2013";
                printDocument1.PrinterSettings.PrinterName = "Microsoft Print to PDF";
                printText = txtTexto.Text;
                printDocument1.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font("Verdana", 9);
            int caracteresPagina;
            int linhasPagina;

            e.Graphics.MeasureString(printText, printFont, e.MarginBounds.Size, StringFormat.GenericTypographic, out caracteresPagina, out linhasPagina);
            e.Graphics.DrawString(printText, printFont, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);

            printText = printText.Substring(caracteresPagina);

            if (printText.Length > 0) e.HasMorePages = true;
            else e.HasMorePages = false;

        }
    }
}
