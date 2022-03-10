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
    /// Interaction logic for quizAddAnswers.xaml
    /// </summary>
    public partial class quizAddAnswers : Window
    {
        quizAnswers quizAnswers = new quizAnswers();
        int questionId;
        int quizId;
        public quizAddAnswers(Int32 question_id, Int32 quiz_id)
        {
            InitializeComponent();

            questionId = question_id;
            quizId = quiz_id;                
        }
        
        private void addAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Wil je de antwoorden toevoegen", "Vraag", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                    quizAnswers.AddDelete(questionId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                quizAnswers.Create(questionId, txbAnswerA.Text, cbAnswerA.SelectedIndex.ToString());
                quizAnswers.Create(questionId, txbAnswerB.Text, cbAnswerB.SelectedIndex.ToString());
                quizAnswers.Create(questionId, txbAnswerC.Text, cbAnswerC.SelectedIndex.ToString());
                quizAnswers.Create(questionId, txbAnswerD.Text, cbAnswerD.SelectedIndex.ToString());

                quizAnswersGrid window = new quizAnswersGrid(questionId, quizId);
                window.Show();
                this.Close();
            }
            else
            {
                //nothing happens               
            }

        }

        private void cancelAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Stoppen met toevoegen van antwoorden", "Vraag", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                //nothing happens
            }
            else
            {
                quizAnswersGrid window = new quizAnswersGrid(questionId, quizId);
                window.Show();
                this.Close();
            }
        }
    }
}
