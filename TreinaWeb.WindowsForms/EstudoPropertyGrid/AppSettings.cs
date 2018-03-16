using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPropertyGrid
{
    [DefaultProperty("SaveOnClose")]
    public class AppSettings
    {
        /* Classe que é exibida no PropertyGrid deste exemplo. As anotações sobre cada propriedade da classe determinam configurações
         * sobre como as propriedades serão exibidas no PropertyGrid. */
        bool saveOnClose = true;
        string msgStart = "Bem-vindo!";
        bool settingsChanged = true;
        string appVersion = "1.0";
        Font appFont = new Font("Arial", 8, FontStyle.Regular);
        Size windowSize = new Size(100, 100);
        Color appColor = SystemColors.Control;
        private DatabaseSettings databaseSettings = new DatabaseSettings();

        [Category("Settings Global"),
            Description("Define se o aplicativo salvará os dados quando a aplicação for fechada"),
            DefaultValue(true)]
        public bool SaveOnClose { get => saveOnClose; set => saveOnClose = value; }

        [Category("Settings Global"),
            Description("Mensagem inicial do aplicativo")]
        public string MsgStart { get => msgStart; set => msgStart = value; }

        [Category("Settings Global"),
            Description("Define se as configurações foram alteradas"),
            DefaultValue(true)]
        public bool SettingsChanged { get => settingsChanged; set => settingsChanged = value; }

        [Category("Version"),
            Description("Versão do aplicativo"),
            DefaultValue("1.0"),
            ReadOnly(true)]
        public string AppVersion { get => appVersion; set => appVersion = value; }

        [Category("Layout"),
            Description("Fonte utilizada no aplicativo")]
        public Font AppFont { get => appFont; set => appFont = value; }

        [Category("Layout"),
            Description("Tamanho da janela do aplicativo")]
        public Size WindowSize { get => windowSize; set => windowSize = value; }

        [Category("Layout"),
            Description("Cor utilizada no aplicativo")]
        public Color AppColor { get => appColor; set => appColor = value; }

        [Category("Database"),
            Description("Define as configurações do banco de dados")]
        public DatabaseSettings DatabaseSettings { get => databaseSettings; set => databaseSettings = value; }
    }
}
