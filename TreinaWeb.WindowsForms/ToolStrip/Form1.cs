using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolStrip
{
    public partial class frmToolStrip : Form
    {
        public frmToolStrip()
        {
            InitializeComponent();
            ToolStripManager.RenderMode = ToolStripManagerRenderMode.Professional;
        }

        private void btnUnirToolStrips_Click(object sender, EventArgs e)
        {
            if (tstFerramentas1.Items.Count > 0)
            {
                ToolStripManager.Merge(tstFerramentas1, tstFerramentas2);
                tstFerramentas1.Visible = false;
            }
            else
            {
                ToolStripManager.RevertMerge(tstFerramentas2, tstFerramentas1);
                tstFerramentas1.Visible = true;
            }
        }
    }
}
