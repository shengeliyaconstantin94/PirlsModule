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
    public partial class MainWindow : Form
    {
        public MainWindow(string userName)
        {
            InitializeComponent();
            user = userName.Trim();
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        public string user;
        private void button1_Click(object sender, EventArgs e)
        {
            TestForm activeTestForm = new TestForm(user);// создание тестовой формы, передача имени пользователя
            activeTestForm.Show();
        }

       

        private void MainWindow_Load(object sender, EventArgs e)
        {
            FillUserReSults();
        }

        private void FillUserReSults()
        {
            string resultFillQuery = @"SELECT p.[Test_ID],p.[Question_1],p.[Question_2],p.[Question_3],p.[Question_4]
      ,p.[Question_5]
      ,p.[Points]
      ,p.[Username] FROM PISA_UserResult p INNER JOIN PISA_UserRealName pr ON p.Username=pr.name WHERE pr.username ='" + user + "'";
            DataTable usersResult = new DataTable();
            SqlDataAdapter showResult = new SqlDataAdapter(resultFillQuery, SQL_Controller.GetSqlConnectionPath());

            showResult.Fill(usersResult); // заполнение DataTable для создпния источника данных DataGreedView
            resultDataGridView1.DataSource = usersResult;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FillUserReSults();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }
    }
}
