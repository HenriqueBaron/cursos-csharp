using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmListViewImageList : Form
    {
        public frmListViewImageList()
        {
            InitializeComponent();
        }

        private void frmListViewImageList_Load(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\Henrique Baron\Pictures\Outras");
            int imageIndex;
            foreach (FileSystemInfo file in dirInfo.GetFileSystemInfos())
            {
                if (file.Attributes == FileAttributes.Directory)
                {
                    imageIndex = 0;
                }
                else
                {
                    imageIndex = 1;
                }
                ListViewItem item = new ListViewItem()
                {
                    Tag = file,
                    Text = file.Name,
                    ImageIndex = imageIndex
                };
                lvwInfoDiretorio.Items.Add(item);
            }
        }

        private void íconesGrandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwInfoDiretorio.View = View.LargeIcon;
        }

        private void íconesPequenosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwInfoDiretorio.View = View.SmallIcon;
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvwInfoDiretorio.View = View.List;
        }

        private void lvwInfoDiretorio_DoubleClick(object sender, EventArgs e)
        {
            FileSystemInfo file = (FileSystemInfo)lvwInfoDiretorio.SelectedItems[0].Tag;
            MessageBox.Show(file.Name);
        }
    }
}
