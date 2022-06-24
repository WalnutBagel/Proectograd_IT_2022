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
      
        string Player = "";
        string compucter = "";
        string modeGame = "show";
        List<string> list = (new string[] { "TheRock", "Paper", "chainsaw" }).ToList(); //список




        public Grisha()
        {
            InitializeComponent();

        }

        private void Rock_Click(object sender, RoutedEventArgs e)   //кнопка отвечающая за камень
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("C:/Users/Student/Desktop/Рябов/Proectograd_IT_2022/AIS_Games/AIS_Games/Resources/Grisha/TheRock.jpg");
            image.EndInit();
            img_Player.Source = image;
            EnemyTurn();
        }

        private void Paper_Click(object sender, RoutedEventArgs e)   //кнопка отвечающая за бумагу
        {
           
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("C:/Users/Student/Desktop/Рябов/Proectograd_IT_2022/AIS_Games/AIS_Games/Resources/Grisha/Paper.jpg");
            image.EndInit();
            img_Player.Source = image;
            EnemyTurn();
        }
        private void Scissors_Click(object sender, RoutedEventArgs e)  //кнопка отвечающая за ножницы
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("C:/Users/Student/Desktop/Рябов/Proectograd_IT_2022/AIS_Games/AIS_Games/Resources/Grisha/chainsaw.jpg");
            image.EndInit();
            img_Player.Source = image;
            EnemyTurn();
        }
        private void Button_Click(object sender, RoutedEventArgs e)   //кнопка закрывающая приложение
        {
            Close();
        }

        private void EnemyTurn()  //код отвечающий за действие противника
        {
            Random random = new Random();
            string a = list[new Random().Next(list.Count)];
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri("C:/Users/Student/Desktop/Рябов/Proectograd_IT_2022/AIS_Games/AIS_Games/Resources/Grisha/" + a + ".jpg");
            image.EndInit();
            img_PC.Source = image;
        }

             
    }   
}