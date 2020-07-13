using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PISA_TEST
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }
        public ResultForm(string username,string testText,List<Question> questions, List<Question> pupilAnswers)
        {
            InitializeComponent();
            quest = questions;
            pupAnsw = pupilAnswers;
            testTextForResult = testText;
            usernameToRes = username;
        }
        public List<Question> quest = new List<Question>();
        public List<Question> pupAnsw = new List<Question>();
        string testTextForResult = "";
        string usernameToRes = "";
        private void ResultForm_Load(object sender, EventArgs e)
        {
            int score = 0;
            int i = 0;
            while (i < quest.Count-1)
            {
                if (pupAnsw[i].CorrectAnswer.ToString().Trim() == quest[i].CorrectAnswer.ToString().Trim())
                {

                    resultTextBox.Text += $"Вопрос {i + 1} - ответ верный \n" + Environment.NewLine;
                    score += quest[i].Cost;

                }
                if (pupAnsw[i].CorrectAnswer.ToString().Trim() != quest[i].CorrectAnswer.ToString().Trim())
                {


                    resultTextBox.Text += $"Вопрос {i + 1} - ответ неверный \n" + Environment.NewLine;

                }
                i++;
                scoreLabel.Text = $"Баллы:{score}";

            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int textId = 0;
            using (SqlConnection con = new SqlConnection(SQL_Controller.GetSqlConnectionPath()))
            {

                    SqlCommand fillCommand = new SqlCommand($"SELECT Text_ID FROM PISA_TextTable WHERE Text ='" + testTextForResult + "'", con);

                    con.Open();
                    DbDataReader reader = fillCommand.ExecuteReader();
                    while (reader.Read())
                    {
                       textId = (int)reader["Text_ID"];
                      
                    }
                    con.Close();
                }
           
            ResultWriter rw = new ResultWriter();
            rw.CreateRecord(textId, usernameToRes, quest, pupAnsw);
            this.Close();
        }
        
          
    }
    }
