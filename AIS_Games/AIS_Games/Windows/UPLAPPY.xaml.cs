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

        string hod = "krestik";
        string bt1 = "p";
        string bt2 = "p";
        string bt3 = "p";
        string bt4 = "p";
        string bt5 = "p";
        string bt6 = "p";
        string bt7 = "p";
        string bt8 = "p";
        string bt9 = "p";

        public UPLAPPY()
        {
            InitializeComponent();
            
        }

        internal class kletki
        {
            public char Kletka; //k крестик    n нолик    p пустота

        }

        public void b1click(object sender, RoutedEventArgs e)
        { 
            if (bt1 == "p")
            {
                if (hod == "krestik")
                {
                    
                }
            }
        }

        public void b2click(object sender, RoutedEventArgs e)
        {
            if (bt2 == "p")
            {
                if (hod == "krestik")
                { 
                    
                }
            }
        }
    }

}
