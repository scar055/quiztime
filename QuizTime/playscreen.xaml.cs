using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace QuizTime
{
    /// <summary>
    /// Interaction logic for playscreen.xaml
    /// </summary>
    public partial class playscreen : Window
    {
        QuizQuestions quizQuestions = new QuizQuestions();
        quizAnswers quizAnswers = new quizAnswers();
        DataSet questions;
        DataSet answers;
        int questionIndex = 0;
        int answerIndex = 0;
        bool checkAnswers;

        public playscreen(Int32 quiz_id, bool _checkAnswers)
        {

            InitializeComponent();

            checkAnswers = _checkAnswers;
            questions = quizQuestions.getData(quiz_id);

            // operator scherm openen

            operatorscreen operatorscreen = new operatorscreen(this);
            operatorscreen.Show();

            displayQuestionAnswers();
        }
        public void btnBack_Click(object sender, RoutedEventArgs e)
        {
            backQuestion();
        }
        public void btnNext_Click(object sender, RoutedEventArgs e)
        {
            nextQuestion();
        }
        public void nextQuestion()
        {
            questionIndex++;
            answerIndex = 0;
            if (questionIndex <= questions.Tables[0].Rows.Count-1)
            {
                displayQuestionAnswers();
            }
            else
            {
                endscreen endscreen = new endscreen();
                endscreen.Show();
                this.Close();
            }
        }
        public void backQuestion()
        {
            if (questionIndex <= 0)
            {
                selection window = new selection();
                window.Show();
                this.Close();
            }
            else
            {
                questionIndex--;
                answerIndex = 0;
                displayQuestionAnswers();
            }
        }
        private void displayQuestionAnswers()
        {
            DataRow currentQuestion = questions.Tables[0].Rows[questionIndex];
            answers = quizAnswers.getData(Convert.ToInt32(currentQuestion["question_id"].ToString()));

            Label[] answer = new Label[] { lblAnwser1, lblAnwser2, lblAnwser3, lblAnwser4 };

            for (int i = 0; i < answer.Length; i++)
            {
                DataRow currentanswers = answers.Tables[0].Rows[answerIndex];
                answer[i].Content = currentanswers["answers"].ToString();

                if (checkAnswers)
                {
                    if (currentanswers["right_answer"].ToString() == "1")
                    {
                        switch (i)
                        {
                            case 0:
                                lblAnwser1.Background = Brushes.LightGreen;
                                break;
                            case 1:
                                lblAnwser2.Background = Brushes.LightGreen;
                                break;
                            case 2:
                                lblAnwser3.Background = Brushes.LightGreen;
                                break;
                            case 3:
                                lblAnwser4.Background = Brushes.LightGreen;
                                break;
                            default:
                                break;
                        }

                    }
                }
                answerIndex++;
            }
            image_quiz.Source  = new BitmapImage(new Uri(currentQuestion["question_image"].ToString()));
            lblQuestion.Content = currentQuestion["quiz_questions"].ToString();
        }
    }
}