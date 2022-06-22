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
    using System.Windows;

    public partial class Difficult1 : Window
    {
        public string ViewModel { get; set; }

        public Difficult1()
        {
            InitializeComponent();
        }


        public void ShowViewModel()
        {
            MessageBox.Show(ViewModel);
        }

        private void Easy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Easy_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Hard_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}
