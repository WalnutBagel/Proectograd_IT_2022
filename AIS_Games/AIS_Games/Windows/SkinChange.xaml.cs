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

namespace AIS_Games.Windows
{
    /// <summary>
    /// Логика взаимодействия для SkinChange.xaml
    /// </summary>
    public partial class SkinChange : Window
    {
        public SkinChange()
        {
            InitializeComponent();
        }

        private void flappyBird1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Tick1.Visibility = Visibility.Visible;
            Tick2.Visibility = Visibility.Hidden;
        }

        private void flappyBird2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Tick2.Visibility = Visibility.Visible;
            Tick1.Visibility = Visibility.Hidden;
            //Flappybird = "/Resources/bbird.png";
        }
    }
}
