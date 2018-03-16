using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginControl
{
    public delegate void AuthenticationEventHandler(object sender, EventArgs e);

    public partial class Login : UserControl
    {
        public event AuthenticationEventHandler Authentication;

        //User Data
        [Category("User Data"),
            Description("Id do usuário"),
            DefaultValue(0)]
        public int UserId { get; set; }

        [Category("User Data"),
            Description("Nome do usuário"),
            DefaultValue("")]
        public string UserName { get; set; }

        //Connection data
        private string database;
        private string dbUserName;
        private string dbPassword;
        private bool dbWindowsAuthentication;
        private string dbConnectionString;

        [Category("Connection Data"),
            Description("Nome e instância do servidor"),
            DefaultValue("")]
        public string ServerName { get; set; }

        [Category("Connection Data"),
            Description("Nome do banco de dados"),
            DefaultValue("")]
        public string Database
        {
            get { return database; }
            set
            {
                database = value;
                UpdateConnectionString();
            }
        }

        [Category("Connection Data"),
            Description("Nome de usuário do banco de dados"),
            DefaultValue("")]
        public string DbUserName
        {
            get { return dbUserName; }
            set
            {
                dbUserName = value;
                UpdateConnectionString();
            }
        }

        [Category("Connection Data"),
            Description("Senha de usuário do banco de dados"),
            DefaultValue("")]
        public string DbPassword
        {
            get { return dbPassword; }
            set
            {
                dbPassword = value;
                UpdateConnectionString();
            }
        }

        [Category("Connection Data"),
            Description("Utilizar a autenticação do Windows para logon no banco de dados"),
            DefaultValue(false)]
        public bool DbWindowsAuthentication
        {
            get { return dbWindowsAuthentication; }
            set
            {
                dbWindowsAuthentication = value;
                UpdateConnectionString();
            }
        }

        [Category("Connection Data"),
            Description("String de conexão com o banco de dados"),
            DefaultValue("")]
        public string DbConnectionString
        {
            get { return dbConnectionString; }
            set
            {
                dbConnectionString = value;
                UpdateConnectionString();
            }
        }

        //Select data
        private string table;
        private string[] columns;

        [Description("Nome da tabela"),
            Browsable(false)]
        public string Table
        {
            get { return table; }
            set
            {
                table = value;
                UpdateSelectQuery();
            }
        }

        [Description("Nomes das colunas da tabela." +
            "As duas primeiras colunas informadas serão retornadas, respectivamente, nas propriedades UserId e UserName" +
            "As duas últimas serão, respectivamente, para validar o User e Password"),
            Browsable(false)]
        public string[] Columns
        {
            get { return columns; }
            set
            {
                if (value != null)
                    if (value.Length != 4)
                        throw new ArgumentOutOfRangeException("value", "Devem ser informadas apenas quatro colunas");
                columns = value;
                UpdateSelectQuery();
            }
        }

        [Description("Nome do usuário do login"),
            Browsable(false)]
        public string LoginUser { get => txtUsuario.Text; set => txtUsuario.Text = value; }

        [Description("Senha do usuário do login"),
            Browsable(false)]
        public string LoginPassword { get => txtSenha.Text; set => txtSenha.Text = value; }

        [Description("SELECT query completa"),
            Browsable(false)]
        public string SelectQuery { get; set; }

        private void UpdateConnectionString()
        {
            if (dbWindowsAuthentication)
                dbConnectionString = "Data Source=" + ServerName + ";Initial Catalog=" + database + ";Integrated Security=True";
            else
                dbConnectionString = "Data Source=" + ServerName + ";Initial Catalog=" + database + ";User Id=" + dbUserName + ";Password=" + dbPassword;
        }

        private void UpdateSelectQuery()
        {
            if (columns != null)
            {
                SelectQuery = "SELECT ";
                SelectQuery += columns[0] + ", ";
                SelectQuery += columns[1] + ", ";
                SelectQuery += columns[2] + ", ";
                SelectQuery += columns[3] + " ";
                SelectQuery += "FROM ";
                SelectQuery += table + " ";
                SelectQuery += "WHERE ";
                SelectQuery += columns[2] + " = '";
                SelectQuery += txtUsuario.Text + "' AND ";
                SelectQuery += columns[3] + " = '";
                SelectQuery += txtSenha.Text + "';";
            }
        }

        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            UpdateSelectQuery();
            using (SqlConnection conn = new SqlConnection(dbConnectionString))
            {
                conn.Open();
                string query = SelectQuery;
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    UserId = Convert.ToInt32(reader[columns[0]]);
                    UserName = reader[columns[1]].ToString();
                }
                else
                {
                    UserId = 0;
                    UserName = string.Empty;
                }
                reader.Close();
                Authentication?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
