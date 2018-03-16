using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class frmCommonDialogs : Form
    {
        public frmCommonDialogs()
        {
            InitializeComponent();
        }

        private void frmCommonDialogs_Load(object sender, EventArgs e)
        {
            PrepararAjuda();
            nicNotificacao.Icon = new Icon(@"C:\Users\Henrique Baron\Source\Repos\TreinaWeb.WindowsForms\Controles\Imagens\ZelleIcone.ico");
            nicNotificacao.Text = "Aplicativo Windows Forms";
        }

        private void PrepararAjuda()
        {
            HelpProvider help = new HelpProvider();

            help.SetShowHelp(btnAbrirArquivo, true);
            help.SetHelpString(btnAbrirArquivo, "Seleciona um arquivo .txt para ser exibido no campo abaixo.");

            help.SetShowHelp(btnSalvar, true);
            help.SetHelpString(btnSalvar, "Salva o texto do campo abaixo em um arquivo.");

            help.SetShowHelp(txtTextoArquivo, true);
            help.SetHelpString(txtTextoArquivo, "O conteúdo do arquivo de texto é exibido e editado aqui.");
        }

        private void btnAbrirArquivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.CheckFileExists = true;
            openFile.DefaultExt = "txt";
            openFile.Filter = "Arquivos de texto|*.txt";
            openFile.Multiselect = false;
            openFile.InitialDirectory = @"C:\Users\Henrique Baron\Desktop";
            openFile.Title = "Selecione um arquivo de texto";

            DialogResult result = openFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    string arquivo = openFile.FileName;
                    StreamReader sr = File.OpenText(arquivo);
                    txtTextoArquivo.Text = sr.ReadToEnd();
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.CheckFileExists = false;
            saveFile.DefaultExt = "txt";
            saveFile.Filter = "Arquivos de texto|*.txt|Todos os arquivos|*.*";
            saveFile.OverwritePrompt = true;
            saveFile.InitialDirectory = @"C:\Users\Henrique Baron\Desktop";
            saveFile.Title = "Salvar arquivo";
            saveFile.FileOk += SalvarArquivo;

            saveFile.ShowDialog();
        }

        private void SalvarArquivo(object sender, CancelEventArgs e)
        {
            try
            {
                string arquivo = ((SaveFileDialog)sender).FileName;
                StreamWriter sw = new StreamWriter(arquivo, false);
                sw.WriteLine(txtTextoArquivo.Text);
                sw.Flush();
                sw.Close();
                MessageBox.Show("Arquivo salvo com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void frmCommonDialogs_Resize(object sender, EventArgs e)
        {
            ShowInTaskbar = !(WindowState == FormWindowState.Minimized);
        }

        private void nicNotificacao_DoubleClick(object sender, EventArgs e)
        {
            if (!ShowInTaskbar)
            {
                WindowState = FormWindowState.Normal;
                Focus();
            }
            else
            {
                nicNotificacao.BalloonTipTitle = "Aviso";
                nicNotificacao.BalloonTipText = "Aplicação aberta!";
                nicNotificacao.ShowBalloonTip(1000);
            }
        }
    }
}
