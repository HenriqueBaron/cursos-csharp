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
    public partial class frmListView : Form
    {
        public frmListView()
        {
            //CreateMyListView();
            InitializeComponent();
        }

        private void frmListView_Load(object sender, EventArgs e)
        {
            CarregarDados();
            lvwDados.View = View.Details;
        }

        private void CarregarDados()
        {
            lvwDados.View = View.Details;
            lvwDados.CheckBoxes = true;
            lvwDados.Columns.Clear();

            ListViewItem item1 = new ListViewItem("Item 1", 0);
            item1.Checked = true;
            item1.SubItems.Add("sub 1");
            item1.SubItems.Add("sub 2");
            item1.SubItems.Add("sub 3");

            ListViewItem item2 = new ListViewItem("Item 2", 1);
            item2.Checked = true;
            item2.SubItems.Add("sub 4");
            item2.SubItems.Add("sub 5");
            item2.SubItems.Add("sub 6");

            ListViewItem item3 = new ListViewItem("Item 3", 0);
            item3.SubItems.Add("sub 7");
            item3.SubItems.Add("sub 8");
            item3.SubItems.Add("sub 9");

            lvwDados.Columns.Add("Coluna do Item", -2, HorizontalAlignment.Left);
            lvwDados.Columns.Add("Coluna 2", -2, HorizontalAlignment.Left);
            lvwDados.Columns.Add("Coluna 3", -2, HorizontalAlignment.Left);
            lvwDados.Columns.Add("Coluna 4", -2, HorizontalAlignment.Center);

            lvwDados.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            imageListSmall.Images.Add(Bitmap.FromFile(@"C:\Users\Henrique Baron\Source\Repos\TreinaWeb.WindowsForms\Controles\Imagens\FolderSmall.png"));
            imageListSmall.Images.Add(Bitmap.FromFile(@"C:\Users\Henrique Baron\Source\Repos\TreinaWeb.WindowsForms\Controles\Imagens\MessageSmall.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(@"C:\Users\Henrique Baron\Source\Repos\TreinaWeb.WindowsForms\Controles\Imagens\DefaultLarge.png"));
            imageListLarge.Images.Add(Bitmap.FromFile(@"C:\Users\Henrique Baron\Source\Repos\TreinaWeb.WindowsForms\Controles\Imagens\ConfigLarge.png"));

            lvwDados.SmallImageList = imageListSmall;
            lvwDados.LargeImageList = imageListLarge;
        }
    }
}
