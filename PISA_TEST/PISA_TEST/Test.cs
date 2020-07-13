using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;

namespace PISA_TEST
{
    class Test
    {
        public List<Question> testQuestions = new List<Question>();//вопросы к тесту
        public string textOfTest = "null"; // текст теста
        public List<string> questionsString= new List<string>();


        public int rndTextNum;
        
        /// <summary>
        /// Метод делает запрос в БД, выбирая случайный текст теста
        /// </summary>
        public Test (int i)
        {
            rndTextNum = i;
        }
        public void GenerateTest()
        {
            
             


            using (SqlConnection con = new SqlConnection(SQL_Controller.GetSqlConnectionPath()))
            {

                SqlCommand comm = new SqlCommand("SELECT Text FROM PISA_TextTable WHERE Text_ID = " + rndTextNum, con);

                con.Open();
                DbDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    textOfTest=reader["Text"].ToString();
                }

            }
           

            
        }
        public byte[] GetImage(int txtid)
        {
            SqlConnection con = new SqlConnection(SQL_Controller.GetSqlConnectionPath());
            con.Open();
            string sqlQuery = $"SELECT Text_Img FROM PISA_TextTable WHERE Text_ID = {txtid}";

            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            if (reader.HasRows)
            {
                
                byte[] img = (byte[])reader[0];

                if (img == null)
                {
                    return null;
                }
                else
                {
                    return img;
                }
            }
            else
            {
                return null;
            }
        }
        
       
        }
    }


