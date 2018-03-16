using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileSystemWatcherEstudo
{
    public partial class FrmFileSystemWatcher : Form
    {
        public FrmFileSystemWatcher()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK) txtCaminho.Text = folderBrowser.SelectedPath;
        }

        private void btnMonitorar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtCaminho.Text))
            {
                fswMonitor.Path = txtCaminho.Text;
                fswMonitor.IncludeSubdirectories = true;
                fswMonitor.EnableRaisingEvents = true;
                fswMonitor.Filter = "*.txt";
                fswMonitor.NotifyFilter = System.IO.NotifyFilters.LastAccess | 
                                            System.IO.NotifyFilters.LastWrite | 
                                            System.IO.NotifyFilters.FileName | 
                                            System.IO.NotifyFilters.DirectoryName | 
                                            System.IO.NotifyFilters.Size;

                lstEventos.Items.Add("Monitorando o diretório " + txtCaminho.Text);
            }
        }

        private void fswMonitor_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            InserirNaLista("Arquivo/diretório " + e.Name + " alterado.");
        }

        private void fswMonitor_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            InserirNaLista("Arquivo/diretório " + e.Name + " criado.");
        }

        private void fswMonitor_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            InserirNaLista("Arquivo/diretório " + e.Name + " excluído.");
        }

        private void fswMonitor_Renamed(object sender, System.IO.RenamedEventArgs e)
        {
            InserirNaLista("Arquivo/diretório " + e.Name + " renomeado.");
        }

        private void InserirNaLista(string item)
        {
            if (lstEventos.InvokeRequired) lstEventos.Invoke((MethodInvoker)delegate { lstEventos.Items.Add(item); });
            else lstEventos.Items.Add(item);
        }
    }
}
