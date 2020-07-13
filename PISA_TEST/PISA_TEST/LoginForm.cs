using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PISA_TEST
{
    
    public partial class LoginForm : Form
    {
        public string userName;
        public SqlConnection connectionToPISADB;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            SqlConnection connectionToPISADB = new SqlConnection(SQL_Controller.GetSqlConnectionPath());
            string loginQuery = "SELECT * FROM PISA_Autentification WHERE ussername ='" + textBox1.Text.Trim() + "' AND password ='" + textBox2.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(loginQuery, connectionToPISADB);// запрос, сверяющий логин и пароль

            DataTable proxyTable = new DataTable();
            sda.Fill(proxyTable);
            if(proxyTable.Rows.Count == 1)
            {
                userName = textBox1.Text;
                MainWindow workWindow = new MainWindow(userName); // передача имени пользователя для выгрузки результатов
                this.Hide();
                connectionToPISADB.Close();
                workWindow.Show();
            }
            else
            {
                MessageBox.Show("Неверный логин и/или пароль");
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
