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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AIS_Games.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class GYM: Window
    {
        public GYM()
        {
            InitializeComponent();
        }


        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Windows.Difficulty winDif = new Windows.Difficulty();
            winDif.ShowDialog();
        }


    }
}
