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
    /// Interaction logic for quizEditAnswers.xaml
    /// </summary>
    public partial class quizEditAnswers : Window
    {
        quizAnswers quizAnswers = new quizAnswers();
        int questionId;
        int answerId;
        int quizId;
        public quizEditAnswers(Int32 quiz_id ,Int32 question_id, Int32 answer_id)
        {
            InitializeComponent();

            quizId = quiz_id;
            questionId = question_id;
            answerId = answer_id;

            quizAnswers.Read(answerId);
            txbAnswer.Text = quizAnswers.Answers;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (txbAnswer.Text == string.Empty)
            {
                MessageBox.Show("er is iets mis gegaan");
            }
            else
            {
                quizAnswers.update(answerId, txbAnswer.Text, cbEditAnswer.SelectedIndex.ToString());

                quizAnswersGrid window = new quizAnswersGrid(questionId, quizId);
                window.Show();
                this.Close();
            }
        }
        private void BtnCancelEdit_Click(object sender, RoutedEventArgs e)
        {
            quizAnswersGrid window = new quizAnswersGrid(questionId, quizId);
            window.Show();
            this.Close();
        }
    }
}
