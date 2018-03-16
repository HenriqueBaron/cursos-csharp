using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPropertyGrid
{
    [TypeConverter(typeof(DatabaseSettingsConverter))]
    public class DatabaseSettings
    {
        /* Um objeto desta classe é uma propriedade da classe AppSettings, que é exibida no PropertyGrid.
         * Como, por padrão, no controle a única coisa que seria exibida para este objeto é o nome da classe,
         * é preciso tomar medidas para que as propriedades da classe sejam exibidas em um item expansível dentro
         * do PropertyGrid. Para tanto, a anotação [TypeConverter(typeof(DatabaseSettingsConverter)] é utilizada.
         * A classe DatabaseSettingsConverter é responsável por fazer essa conversão. */
        [Description("Nome do servidor de banco de dados")]
        public string ServerName { get; set; }

        [Description("Nome do banco de dados")]
        public string Database { get; set; }

        [Description("Usuário do banco de dados")]
        public string Username { get; set; }

        [Description("Senha do usuário")]
        public string Password { get; set; }
    }
}
