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
    /// Логика взаимодействия для UPLAPPY.xaml
    /// </summary>
    public partial class UPLAPPY : Window
    {

        public string hod = "krestik";
        public string final = " ";
        public string bt1 = "p";
        public string bt2 = "p";
        public string bt3 = "p";
        public string bt4 = "p";
        public string bt5 = "p";
        public string bt6 = "p";
        public string bt7 = "p";
        public string bt8 = "p";
        public string bt9 = "p";


        public UPLAPPY()
        {
            InitializeComponent();

        }

        public void proverka()
        {
            if (bt1 == "k" && bt4 == "k" && bt7 == "k")
            {
                string final = "krestik";
                Windows.final win_k = new Windows.final();
                Close();
                win_k.ShowDialog();
            }
            else if (bt1 == "n" && bt4 == "n" && bt7 == "n")
            {
                string final = "nolik";
                Windows.final win_n = new Windows.final();
                Close();
                win_n.ShowDialog();
            }
            else if (bt2 == "k" && bt5 == "k" && bt8 == "k")
            {
                string final = "krestik";
                Windows.final win_k = new Windows.final();
                Close();
                win_k.ShowDialog();
            }
            else if (bt2 == "n" && bt5 == "n" && bt8 == "n")
            {
                string final = "nolik";
                Windows.final win_n = new Windows.final();
                Close();
                win_n.ShowDialog();
            }
            else if (bt3 == "k" && bt6 == "k" && bt9 == "k")
            {
                string final = "krestik";
                Windows.final win_k = new Windows.final();
                Close();
                win_k.ShowDialog();
            }
            else if (bt3 == "n" && bt6 == "n" && bt9 == "n")
            {
                string final = "nolik";
                Windows.final win_n = new Windows.final();
                Close();
                win_n.ShowDialog();
            }
            else if (bt1 == "k" && bt2 == "k" && bt3 == "k")
            {
                string final = "krestik";
                Windows.final win_k = new Windows.final();
                Close();
                win_k.ShowDialog();
            }
            else if (bt1 == "n" && bt2 == "n" && bt3 == "n")
            {
                string final = "nolik";
                Windows.final win_n = new Windows.final();
                Close();
                win_n.ShowDialog();
            }
            else if (bt4 == "k" && bt5 == "k" && bt6 == "k")
            {
                string final = "krestik";
                Windows.final win_k = new Windows.final();
                Close();
                win_k.ShowDialog();
            }
            else if (bt4 == "n" && bt5 == "n" && bt6 == "n")
            {
                string final = "nolik";
                Windows.final win_n = new Windows.final();
                Close();
                win_n.ShowDialog();
            }
            else if (bt7 == "k" && bt8 == "k" && bt9 == "k")
            {
                string final = "krestik";
                Windows.final win_k = new Windows.final();
                Close();
                win_k.ShowDialog();
            }
            else if (bt7 == "n" && bt8 == "n" && bt9 == "n")
            {
                string final = "nolik";
                Windows.final win_n = new Windows.final();
                Close();
                win_n.ShowDialog();
            }
            else if (bt1 == "k" && bt5 == "k" && bt9 == "k")
            {
                string final = "krestik";
                Windows.final win_k = new Windows.final();
                Close();
                win_k.ShowDialog();
            }
            else if (bt1 == "n" && bt5 == "n" && bt9 == "n")
            {
                string final = "nolik";
                Windows.final win_k = new Windows.final();
                Close();
                win_k.ShowDialog();
            }
            else if (bt3 == "k" && bt5 == "k" && bt7 == "k")
            {
                string final = "krestik";
                Windows.final win_k = new Windows.final();
                Close();
                win_k.ShowDialog();
            }
            else if (bt3 == "n" && bt5 == "n" && bt7 == "n")
            {
                string final = "nolik";
                Windows.final win_n = new Windows.final();
                Close();
                win_n.ShowDialog();
            }
        }

        public void b1click(object sender, RoutedEventArgs e)
        {
            if (bt1 == "p")
            {
                if (hod == "krestik")
                {
                    bt1 = "k";
                    hod = "nolik";
                    //but1.ImageSource = new BitmapImage(new Uri("/Resources/UPLAPPY/крестик.png", UriKind.RelativeOrAbsolute));
                    proverka();
                }
                else if (hod == "nolik")
                {
                    bt1 = "n";
                    hod = "krestik";
                    proverka();
                }
            }
        }
        public void b2click(object sender, RoutedEventArgs e)
        {
            if (bt2 == "p")
            {
                if (hod == "krestik")
                {
                    bt2 = "k";
                    hod = "nolik";

                    proverka();
                }
                else if (hod == "nolik")
                {
                    bt2 = "n";
                    hod = "krestik";
                    proverka();
                }
            }
        }

        public void b3click(object sender, RoutedEventArgs e)
        {
            if (bt3 == "p")
            {
                if (hod == "krestik")
                {
                    bt3 = "k";
                    hod = "nolik";
                    proverka();
                }
                else if (hod == "nolik")
                {
                    bt3 = "n";
                    hod = "krestik";
                    proverka();
                }
            }
        }
        public void b4click(object sender, RoutedEventArgs e)
        {
            if (bt4 == "p")
            {
                if (hod == "krestik")
                {
                    bt4 = "k";
                    hod = "nolik";
                    proverka();
                }
                else if (hod == "nolik")
                {
                    bt4 = "n";
                    hod = "krestik";
                    proverka();
                }
            }
        }
        public void b5click(object sender, RoutedEventArgs e)
        {
            if (bt5 == "p")
            {
                if (hod == "krestik")
                {
                    bt5 = "k";
                    hod = "nolik";
                    proverka();
                }
                else if (hod == "nolik")
                {
                    bt5 = "n";
                    hod = "krestik";
                    proverka();
                }
            }
        }
        public void b6click(object sender, RoutedEventArgs e)
        {
            if (bt6 == "p")
            {
                if (hod == "krestik")
                {
                    bt6 = "k";
                    hod = "nolik";
                    proverka();
                }
                else if (hod == "nolik")
                {
                    bt6 = "n";
                    hod = "krestik";
                    proverka();
                }
            }
        }
        public void b7click(object sender, RoutedEventArgs e)
        {
            if (bt7 == "p")
            {
                if (hod == "krestik")
                {
                    bt7 = "k";
                    hod = "nolik";
                    proverka();
                }
                else if (hod == "nolik")
                {
                    bt7 = "n";
                    hod = "krestik";
                    proverka();
                }
            }
        }
        public void b8click(object sender, RoutedEventArgs e)
        {
            if (bt8 == "p")
            {
                if (hod == "krestik")
                {
                    bt8 = "k";
                    hod = "nolik";
                    proverka();
                }
                else if (hod == "nolik")
                {
                    bt8 = "n";
                    hod = "krestik";
                    proverka();
                }
            }
        }
        public void b9click(object sender, RoutedEventArgs e)
        {
            if (bt9 == "p")
            {
                if (hod == "krestik")
                {
                    bt9 = "k";
                    hod = "nolik";
                    proverka();
                }
                else if (hod == "nolik")
                {
                    bt9 = "n";
                    hod = "krestik";
                    proverka();
                }
            }
        }


    }
}
