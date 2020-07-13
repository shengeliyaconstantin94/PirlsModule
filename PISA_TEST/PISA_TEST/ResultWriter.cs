using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISA_TEST
{
  public  class ResultWriter
    {
        public void CreateRecord(int textNumber, string username, List<Question> answers, List<Question> pupilAnswer)
        {
            int score = 0;
            List<string> truOrFalseList = new List<string>();
           
            for (int i = 0; i < answers.Count-1; i++)
            {
                if (pupilAnswer[i].CorrectAnswer.ToString().Trim() == answers[i].CorrectAnswer.ToString().Trim())
                {

                    truOrFalseList.Add("Верно");
                    score += answers[i].Cost;
                }
                if (pupilAnswer[i].CorrectAnswer.ToString().Trim() != answers[i].CorrectAnswer.ToString().Trim())
                {

                    truOrFalseList.Add("Неверно");


                }

            }
            string name = GetUserName(username);

            string resultFillQuery = $"INSERT INTO PISA_UserResult ([Text_ID],[Question_1],[Question_2],[Question_3],[Question_4],[Question_5],[Points],[Username]) VALUES('{textNumber}','{truOrFalseList[0]}','{truOrFalseList[1]}','{truOrFalseList[2]}','{truOrFalseList[3]}','{truOrFalseList[4]}',{score},'{name}')";
            SqlConnection con = new SqlConnection(SQL_Controller.GetSqlConnectionPath());
            SqlCommand showResult = new SqlCommand(resultFillQuery,con );
            con.Open();
            showResult.ExecuteNonQuery();
            con.Close();
            
        }
        public string GetUserName(string user)
        {
            string getUsernameQuery = $"SELECT name FROM PISA_UserRealName WHERE username ='{user}'";
            SqlConnection con = new SqlConnection(SQL_Controller.GetSqlConnectionPath());
            SqlCommand showResult = new SqlCommand(getUsernameQuery, con);
            con.Open();
            string username = showResult.ExecuteScalar().ToString();
            con.Close();
            return username;
        }
    }
}
