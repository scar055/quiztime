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
    /// Interaction logic for operatorscreen.xaml
    /// </summary>
    public partial class operatorscreen : Window
    {
        playscreen playscreen;
        public operatorscreen(playscreen _playscreen)
        {
            InitializeComponent();
            playscreen = _playscreen;

            btnNext.Click += btnNext_click;
            btnBack.Click += btnBack_click;
        }
        private void btnNext_click(object sender, RoutedEventArgs e)
        {
            playscreen.nextQuestion();
        }
        private void btnBack_click(object sender, RoutedEventArgs e)
        {
            playscreen.backQuestion();
        }

    }
}
