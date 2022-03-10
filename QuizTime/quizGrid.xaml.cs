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
    /// Interaction logic for quizGrid.xaml
    /// </summary>
    public partial class quizGrid : Window
    {
        Quiz quiz = new Quiz();
        public quizGrid()
        {
            InitializeComponent();


            //Haalt quiz data op
            dgQuiz.DataContext = quiz.getData();
        }
        private void btnAddQuiz_Click(object sender, RoutedEventArgs e)
        {
            quizAdd Window = new quizAdd();
            Window.Show();
            this.Close();
        }
        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {   
            try
            {
                object item = dgQuiz.SelectedItem;
                int quiz_id = int.Parse((dgQuiz.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);

                quizQuestionsGrid window = new quizQuestionsGrid(quiz_id);
                window.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }   
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object item = dgQuiz.SelectedItem;
                int quizNumber = int.Parse((dgQuiz.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                if (quiz.Delete(quizNumber) == true)
                {
                    dgQuiz.DataContext = quiz.getData();
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
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
