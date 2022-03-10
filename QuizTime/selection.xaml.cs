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
    /// Interaction logic for selection.xaml
    /// </summary>
    public partial class selection : Window
    {
        Quiz quiz = new Quiz();
        public selection()
        {
            InitializeComponent();
            dgQuiz.DataContext = quiz.getData();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object item = dgQuiz.SelectedItem;
                int quiz_id = int.Parse((dgQuiz.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                playscreen playscreen = new playscreen(quiz_id, false);
                playscreen.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnCheckAnswers_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                object item = dgQuiz.SelectedItem;
                int quiz_id = int.Parse((dgQuiz.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text);
                playscreen playscreen = new playscreen(quiz_id, true);
                playscreen.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
