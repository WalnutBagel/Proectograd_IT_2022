﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AIS_Games
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Game> games_info = new ObservableCollection<Game>();

        public class Game
        {
            public string GameImage { get; set; }
            public string GameText { get; set; }
            public string GameCreators { get; set; }
        }

        public MainWindow()
        {
            InitializeComponent();
            games_info.Add(new Game
            {
                GameImage = "Resources/TestGame.jpg",
                GameText = "Игра про захват Татарстаном всея мира",
                GameCreators = "Сделали Ваня и Леша))))"
            });
            games_info.Add(new Game
            {
                GameImage = "Resources/IconFlappy.png",
                GameText = "Flappy Bird",
                GameCreators = "Maria Konstantinova"
            });
            games_info.Add(new Game
            {
                GameImage = "Resources/TestGame.jpg",
                GameText = "Игра про захват Татарстаном всея мира",
                GameCreators = "Сделали Ваня и Леша))))"
            });
            games_info.Add(new Game
            {
                GameImage = "Resources/TestGame.jpg",
                GameText = "Игра про захват Татарстаном всея мира",
                GameCreators = "Сделали Ваня и Леша))))"
            });
            games_info.Add(new Game
            {
                GameImage = "Resources/Grisha/images.jpg",
                GameText = "Камень,ножницы,бумага",
                GameCreators = "Сделал Григорий Рябов"
            });
            GamesLV.ItemsSource = games_info;

        }

        private void GamesLV_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.Opacity = 0.3;
            var selectSort = GamesLV.SelectedIndex;
            switch (selectSort)
            {
                case 0:
                    Windows.LeshaVania win0 = new Windows.LeshaVania();
                    win0.ShowDialog();
                    break;

                case 1:
                    Windows.Flappybird win1 = new Windows.Flappybird();
                    win1.ShowDialog();
                    break;

                case 2:
                    Windows.LeshaVania win2 = new Windows.LeshaVania();
                    win2.ShowDialog();
                    break;

                case 3:
                    Windows.LeshaVania win3 = new Windows.LeshaVania();
                    win3.ShowDialog();
                    break;

                case 4:
                    Windows.Grisha win4 = new Windows.Grisha();
                    win4.ShowDialog();
                    break;
                    
                default:
                    break;
            }

            this.Opacity = 1;
            GamesLV.SelectedIndex = -1;
        }
    }
}
