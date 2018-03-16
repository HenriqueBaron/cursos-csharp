using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPropertyGrid
{
    public class DatabaseSettingsConverter : ExpandableObjectConverter
    {
        /* Esta classe é responsável por fazer a conversão da classe DatabaseSettings para que ela possa
         * ser exibida como um item expansível no PropertyGrid, de modo que o usuário pode editar suas
         * propriedades pelo controle, o que, por padrão, não acontece. */

        public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
        {
            if (destinationType == typeof(DatabaseSettings))
                return true;
            return base.CanConvertTo(context, destinationType);
        }

        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(String) && value is DatabaseSettings)
            {
                DatabaseSettings database = (DatabaseSettings)value;

                return "Server:" + database.ServerName +
                        ", Database:" + database.Database +
                        ", User:" + database.Username +
                        ", Password:" + database.Password;
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }

        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            if (sourceType == typeof(String))
                return true;
            return base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value is String)
            {
                try
                {
                    string s = (string)value;
                    int colon = s.IndexOf(':');
                    int comma = s.IndexOf(',');

                    if (colon != -1 && comma != -1)
                    {
                        string serverName = s.Substring(colon + 1, (comma - colon - 1));

                        colon = s.IndexOf(':', comma + 1);
                        comma = s.IndexOf(',', comma + 1);

                        string database = s.Substring(colon + 1, (comma - colon - 1));

                        colon = s.IndexOf(':', comma + 1);
                        comma = s.IndexOf(',', comma + 1);

                        string username = s.Substring(colon + 1, (comma - colon - 1));

                        colon = s.IndexOf(':', comma + 1);

                        string password = s.Substring(colon + 1);

                        DatabaseSettings db = new DatabaseSettings();
                        db.ServerName = serverName;
                        db.Database = database;
                        db.Username = username;
                        db.Password = password;

                        return db;
                    }
                }
                catch
                {
                    throw new Exception("Não foi possível converter o tipo " + value.ToString() + " para o tipo DatabaseSettings");
                }
            }
            return base.ConvertFrom(context, culture, value);
        }
    }
}
