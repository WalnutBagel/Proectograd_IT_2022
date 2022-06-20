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

        public UPLAPPY()
        {
            InitializeComponent();

            int[,] field = new int[8, 8];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == 0 && j == 0)
                    {

                    }
                    else if (i == 0 && j == 2)
                    {

                    }
                    else if (i == 0 && j == 4)
                    {

                    }
                    else if (i == 0 && j == 6)
                    { 
                    
                    }
                    else if (i == 1 && j == 1)
                    {

                    }
                    else if (i == 1 && j == 3)
                    {

                    }
                    else if (i == 1 && j == 5)
                    {

                    }
                    else if (i == 1 && j == 7)
                    {

                    }
                    else if (i == 2 && j == 0)
                    {

                    }
                    else if (i == 2 && j == 2)
                    {

                    }
                    else if (i == 2 && j == 4)
                    {

                    }
                    else if (i == 2 && j == 6)
                    {

                    }
                    else if (i == 5 && j == 1)
                    {

                    }
                    else if (i == 5 && j == 3)
                    {

                    }
                    else if (i == 5 && j == 5)
                    {

                    }
                    else if (i == 5 && j == 7)
                    {

                    }
                    else if (i == 6 && j == 0)
                    {

                    }
                    else if (i == 6 && j == 2)
                    {

                    }
                    else if (i == 6 && j == 4)
                    {

                    }
                    else if (i == 6 && j == 6)
                    {

                    }
                    else if (i == 7 && j == 1)
                    {

                    }
                    else if (i == 7 && j == 3)
                    {

                    }
                    else if (i == 7 && j == 5)
                    {

                    }
                    else if (i == 7 && j == 7)
                    {

                    }
                    
                    field[i, j] = i;
                }
            }
        }

        internal class shashki
        {
            public bool tsv_sh;
            public bool sh;
        }


        


        
    }
}
