using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PISA_TEST
{
    public partial class TestForm : Form
    {
        public TestForm(string username)
        {
            InitializeComponent();
            userName = username;
        }
        public string userName ;
        List<Question> currentQuestions = new List<Question>(); // список вопросов
        List<Question> pupilAnswers = new List<Question>(); //список ответов
        int currentQuestionNumber = 0;//счетчик вопросов
        private void TestForm_Load(object sender, EventArgs e)
        {
            GetRnd newRnd = new GetRnd();
            int i = newRnd.GetRndNum();

            Test currentTest = new Test(i);
            currentTest.GenerateTest();
            testTextTextBox.Text = currentTest.textOfTest;

            MemoryStream mstreem = new MemoryStream(currentTest.GetImage(currentTest.rndTextNum));
            pictureBox1.Image = Image.FromStream(mstreem);
            pictureBox1.BackgroundImage = pictureBox1.Image;
            pictureBox1.Image = null;
            GetQuestinContent(currentQuestions,currentTest);

            

            FormFiller(currentQuestionNumber);
            PupilAnswerFill(currentQuestions);

        }
        /// <summary>
        /// Метод заполняет список вопросов текстом вопросов и ответов
        /// </summary>
        /// <param name="currentQuestions"></param>
        /// <param name="currentTest"></param>
        private void GetQuestinContent(List<Question> currentQuestions,Test currentTest)
        {
            currentQuestions = Question.GetQuestionText(currentQuestions, currentTest.rndTextNum);
            currentQuestions = Question.FillQuestionVariant(currentQuestions);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentQuestionNumber < currentQuestions.Count-1)
            {
                if (answerARadioButton.Checked == true)
                {
                    pupilAnswers[currentQuestionNumber].CorrectAnswer = currentQuestions[currentQuestionNumber].VariantA;

                }
                if (answerBRadioButton.Checked == true)
                {
                    pupilAnswers[currentQuestionNumber].CorrectAnswer = currentQuestions[currentQuestionNumber].VariantB;

                }
                if (answerCRadioButton.Checked == true)
                {
                    pupilAnswers[currentQuestionNumber].CorrectAnswer = currentQuestions[currentQuestionNumber].VariantC;

                }
                if (answerDRadioButton.Checked == true)
                {
                    pupilAnswers[currentQuestionNumber].CorrectAnswer = currentQuestions[currentQuestionNumber].VariantD;

                }
                if (currentQuestionNumber < currentQuestions.Count)
                {
                    currentQuestionNumber++;

                    FormFiller(currentQuestionNumber);
                }
            }
            else
            {
                ResultForm result = new ResultForm(userName,testTextTextBox.Text, currentQuestions, pupilAnswers);
                result.Show();
                this.Close();
            }


        }
        

        private void backButton_Click(object sender, EventArgs e)
        {
            if( currentQuestionNumber ==0)
            {
                MessageBox.Show("Невозможно вернуться к предыдущему вопросу");
            }
            else
            {
                currentQuestionNumber--;
                FormFiller(currentQuestionNumber);
            }
        }
        /// <summary>
        /// Метод заполняет форму данными теста: текстом вопроса и вариантов
        /// </summary>
        /// <param name="currentQuestionIndex"></param>
        private void FormFiller(int currentQuestionIndex)
        {
            questionTextBox.Text = currentQuestions[currentQuestionIndex].QuestionText;
            answerARadioButton.Text = currentQuestions[currentQuestionIndex].VariantA;
            answerBRadioButton.Text = currentQuestions[currentQuestionIndex].VariantB;
            answerCRadioButton.Text = currentQuestions[currentQuestionIndex].VariantC;
            answerDRadioButton.Text = currentQuestions[currentQuestionIndex].VariantD;
        }
        /// <summary>
        /// Метод заполняет пустыми записями список ответов ученика в соответствии с количеством вопросов
        /// </summary>
        /// <param name="questList"></param>
        private void PupilAnswerFill(List<Question> questList)
        {
            for (int questionCount = 0; questionCount <= questList.Count; questionCount++)
            {
                pupilAnswers.Add(new Question());

            }
        }
    }
}
