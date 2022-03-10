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
    /// Interaction logic for quizQuestionsGrid.xaml
    /// </summary>
    public partial class quizQuestionsGrid : Window
    {
        Quiz quiz = new Quiz();
        QuizQuestions questions = new QuizQuestions();
        int quizId;
        public quizQuestionsGrid(Int32 quiz_id)
        {
            InitializeComponent();
            
            //haalt data op hij sql database naar de grid
            dgQuestions.DataContext = questions.getData(quiz_id);
            quizId = quiz_id;
            // moet data van quiz database halen om invoer veld de naam te laten wijzigen
            quiz.Read(quiz_id);
            txbQuizname.Text = quiz.quizName;
        }
        //voegt vraag toe
        private void btnAddQuestions_Click(object sender, RoutedEventArgs e)
        {
            quizAddQuestion window = new quizAddQuestion(quizId);
            window.Show();
            this.Close();
        }
        //veranderd naam van quiz
        private void btn_changeQuizName_Click(object sender, RoutedEventArgs e)
        {
            if (txbQuizname.Text == string.Empty)
            {
                MessageBox.Show("er is iets mis gegaan");
            }
            else
            {
                quiz.update(quizId, txbQuizname.Text);

                quizGrid window = new quizGrid();
                window.Show();
                this.Close();
            }
        }
        // gaat naar antwoord edit sherm
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object item = dgQuestions.SelectedItem;
                int questions_id = int.Parse((dgQuestions.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);

                quizAnswersGrid window = new quizAnswersGrid(questions_id, quizId);
                window.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        //verwijderd de vraag met antwoorden
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object item = dgQuestions.SelectedItem;
                int answerNumber = int.Parse((dgQuestions.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                if (questions.Delete(answerNumber) == true)
                {
                    dgQuestions.DataContext = questions.getData(quizId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            quizGrid window = new quizGrid();
            window.Show();
            this.Close();
        }
    }
}
