using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PISA_TEST
{
    public class Question
    {
        #region Поля
        string questionText;
        string variantA;
        string variantB;
        string variantC;
        string variantD;
        string correctAnswer;
        int cost;
        #endregion

        #region Свойства
        public string QuestionText
        {
            get
            {
                return questionText;
            }

            set
            {
                questionText = value;
            }
        }
        public string VariantA
        {
            get
            {
                return variantA;
            }

            set
            {
                variantA = value;
            }
        }
        public string VariantB
        {
            get
            {
                return variantB;
            }

            set
            {
                variantB = value;
            }
        }
        public string VariantC
        {
            get
            {
                return variantC;
            }

            set
            {
                variantC = value;
            }
        }
        public string VariantD
        {
            get
            {
                return variantD;
            }

            set
            {
                variantD = value;
            }
        }
        /// <summary>
        /// правильный ответ. Присваевается значение одного из свойств
        /// </summary>
        public string CorrectAnswer
        {
            get
            {
                return correctAnswer;
            }

            set
            {
                correctAnswer = value;
            }
        }
        public int Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }

        #endregion
        /// <summary>
        /// Заполняет текст вопросов. Первый параметр-список вопросов. Второй- ID набора вопросов
        /// </summary>
        /// <param name="quest"></param>
        /// <param name="questSetNumber"></param>
        /// <returns></returns>
        public static List<Question> GetQuestionText(List<Question> quest, int questSetNumber)
        {
            List<string> testquestions = new List<string>();
            using (SqlConnection con = new SqlConnection(SQL_Controller.GetSqlConnectionPath()))
            {

                SqlCommand comm = new SqlCommand("SELECT Question_Text FROM PISA_QuestinTable WHERE Question_Set_ID = " + questSetNumber, con);

                con.Open();
                DbDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    testquestions.Add(reader["Question_Text"].ToString());
                }


            }


            foreach (string questText in testquestions)
            {
                quest.Add(new Question { QuestionText = questText });
            }
            return quest;

        }
        /// <summary>
        /// Метод обращается к БД для заполнения текста вариантов ответа конкретного вопроса.
        /// </summary>
        /// <param name="questionsWithText"></param>
        /// <returns></returns>
        public static List<Question> FillQuestionVariant(List<Question> questionsWithText)
        {
            using (SqlConnection con = new SqlConnection(SQL_Controller.GetSqlConnectionPath()))
            { 
                
                foreach (Question q in questionsWithText)
                {
                    SqlCommand fillCommand = new SqlCommand("SELECT * FROM PISA_QuestinTable WHERE Question_Text = '" + q.questionText + "'", con);

                    con.Open();
                    DbDataReader reader = fillCommand.ExecuteReader();
                    while (reader.Read())
                    {
                       q.VariantA=(reader["Question_Var_A"].ToString());
                        q.VariantB = (reader["Question_Var_B"].ToString());
                        q.VariantC = (reader["Question_Var_C"].ToString());
                        q.VariantD = (reader["Question_Var_D"].ToString());
                        q.CorrectAnswer = (reader["Question_Answer"].ToString());
                        q.Cost = (int.Parse(reader["Question_Value"].ToString()));
                    }
                    con.Close();
                }
                return questionsWithText;
            }

        }
    }
}
