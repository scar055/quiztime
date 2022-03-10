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
    /// Interaction logic for quizAdd.xaml
    /// </summary>
    public partial class quizAdd : Window
    {
        Quiz quiz = new Quiz();
        public quizAdd()
        {

            InitializeComponent();

        }
        private void addQuiz_Click(object sender, RoutedEventArgs e)
        {
            quiz.Create(txbQuizName.Text);

            quizGrid window = new quizGrid();
            window.Show();
            this.Close();
        }

        private void cancelQuiz_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Stoppen met de quiz toe tevoegen", "Vraag", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
            {
                //nothing happens
            }
            else
            {
                quizGrid window = new quizGrid();
                window.Show();
                this.Close();
            }
        }
    }
}
