using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

namespace QuizTime
{
    public partial class quizAnswersGrid : Window
    {
        QuizQuestions questions = new QuizQuestions();
        quizAnswers answers = new quizAnswers();
        int questionId;
        int quizId;
        string filename = null;
        public quizAnswersGrid(Int32 question_id, Int32 quiz_id)
        {
            InitializeComponent();
            DataSet ds = answers.getData(question_id);
            // haalt answers uit database
            dgAnswers.DataContext = ds;
            questionId = question_id;
            quizId = quiz_id;
            //stopt de vraag in de textbox
            questions.Read(question_id);
            txbQuestion.Text = questions.QuestionQuiz;

            btnAddAnswers.IsEnabled = ds.Tables[0].Rows.Count < 4;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            object item = dgAnswers.SelectedItem;
            int answerId = int.Parse((dgAnswers.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
            quizEditAnswers window = new quizEditAnswers(quizId, questionId, answerId);
            window.Show();
            this.Close();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object item = dgAnswers.SelectedItem;
                int answerNumber = int.Parse((dgAnswers.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                if (answers.Delete(answerNumber))
                {
                    dgAnswers.DataContext = answers.getData(questionId);

                    DataSet ds = answers.getData(questionId);
                    btnAddAnswers.IsEnabled = ds.Tables[0].Rows.Count < 4;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnAddAnswers_Click(object sender, RoutedEventArgs e)
        {
            quizAddAnswers window = new quizAddAnswers(questionId, quizId);
            window.Show();
            this.Close();
        }

        private void btn_changeQuestion_Click(object sender, RoutedEventArgs e)
        {
           

            if (txbQuestion.Text == string.Empty)
            {
                MessageBox.Show("er is iets mis gegaan");
            }
            else
            {
                SaveFileDialog dialog = new SaveFileDialog();


                questions.update(questionId, txbQuestion.Text, filename);

                quizQuestionsGrid window = new quizQuestionsGrid(quizId);
                window.Show();
                this.Close();
            }
        }

        private void btnChangeImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            // filters images only
            fd.Title = "select a image";
            fd.Filter = "Image Files(*.PNG;*.JPG;*.GIF)|*.PNG;*.JPG;*.GIF|All files (*.*)|*.*";
            if (fd.ShowDialog() == true)
            {
                try
                {
                    questionImage.Source = new BitmapImage(new Uri(fd.FileName));
                    filename = fd.FileName;
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Kan file niet openen " + exp.Message);
                }
            }
        }
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            quizQuestionsGrid window = new quizQuestionsGrid(quizId);
            window.Show();
            this.Close();
        }
    }
}
