using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoPropertyGrid
{
    public partial class FrmPropertyGrid : Form
    {
        public FrmPropertyGrid()
        {
            InitializeComponent();
        }

        private void FrmPropertyGrid_Load(object sender, EventArgs e)
        {
            AppSettings appSettings = new AppSettings();

            prgAppSettings.SelectedObject = appSettings;
        }
    }
}
