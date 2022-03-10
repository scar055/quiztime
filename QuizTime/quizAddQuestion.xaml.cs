using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for quizAddQuestion.xaml
    /// </summary>
    public partial class quizAddQuestion : Window
    {
        QuizQuestions quizQuestions = new QuizQuestions();
        int quizId;
        string filename = null;
        public quizAddQuestion(Int32 quiz_id)
        {
            InitializeComponent();

            quizId = quiz_id;
        }
        private void addQuiz_Click(object sender, RoutedEventArgs e)
        {
            
            quizQuestions.Create(quizId, txbQuestion.Text, filename);

            quizQuestionsGrid window = new quizQuestionsGrid(quizId);
            window.Show();
            this.Close();
        }

        private void cancelQuestion_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("stoppen met vraag toevoegen", "Vraag", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                quizQuestionsGrid window = new quizQuestionsGrid(quizId);
                window.Show();
                this.Close();
            }
            else
            {
                //nothing happens
            }
        }

        private void btnQuestionImage_Click(object sender, RoutedEventArgs e)
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
                    MessageBox.Show("Unable to open file " + exp.Message);
                }
            }
        }
    }
}
