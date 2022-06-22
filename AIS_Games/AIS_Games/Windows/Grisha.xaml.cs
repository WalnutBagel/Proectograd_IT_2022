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
    public partial class Grisha : Window
    {
        Random rnd = new Random();
        string Player = "";
        string compucter = "";
        string modeGame = "show";
        int scoreWin;
        int scoreLose;
        int scoreDraw;




        public Grisha()
        {
            InitializeComponent();

        }

        private void Rock_Click(object sender, RoutedEventArgs e)
        {
            //BitmapImage image = new BitmapImage();
            //image.BeginInit();
            //image.UriSource = new Uri("/Resources/Grisha/TheRock.jpg");
            //image.EndInit();
            //img_Player.Source = image;
        }

        private void Paper_Click(object sender, RoutedEventArgs e)
        {
            //BitmapImage image = new BitmapImage();
            //image.BeginInit();
            //image.UriSource = new Uri(@"/Resources/Grisha/");
            //image.EndInit();
            //img_Player.Source = image;
        }

        private void Scissors_Click(object sender, RoutedEventArgs e)
        {
            //BitmapImage image = new BitmapImage();
            //image.BeginInit();
            //image.UriSource = new Uri(@"/Resources/Grisha/");
            //image.EndInit();
            //img_Player.Source = image; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }




    }    
}