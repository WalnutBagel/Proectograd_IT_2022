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

using System.Windows.Threading;

namespace AIS_Games.Windows
{
    /// <summary>
    /// Логика взаимодействия для Flappybird.xaml
    /// </summary>
    public partial class Flappybird : Window
    {
        DispatcherTimer gameTimer = new DispatcherTimer(); // создание экземпляра класса таймера


        double score;
        int gravity = -1;
        int speed = -10;
        bool gameOver;
        Rect flappyBirdHitBox;

        public Flappybird() // запуск игры при нажатии эконки
        {
            InitializeComponent();

            gameTimer.Tick += MainEventTimer;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
        }
        private void MainEventTimer(object sender, EventArgs e)
        {
            txtScore.Content = score;

            flappyBirdHitBox = new Rect(Canvas.GetLeft(flappyBird), Canvas.GetTop(flappyBird), flappyBird.Width - 20, flappyBird.Height - 2);

            Canvas.SetTop(flappyBird, Canvas.GetTop(flappyBird) + speed);
            speed -= gravity;

            if (Canvas.GetTop(flappyBird) < -30 || Canvas.GetTop(flappyBird) + flappyBird.Height > 570)
            {
                EndGame();
            }


            foreach (var x in MyCanvas.Children.OfType<Image>())
            {
                if ((string)x.Tag == "obs1" || (string)x.Tag == "obs2" || (string)x.Tag == "obs3" || (string)x.Tag == "obs4" || (string)x.Tag == "obs5")
                {
                    Canvas.SetLeft(x, Canvas.GetLeft(x) - 5);

                    if (Canvas.GetLeft(x) < -100)
                    {
                        Canvas.SetLeft(x, 1400);
                        Random rnd = new Random();
                        int rand = rnd.Next(-310, 0);
                        Canvas.SetTop(x, rand);
                        if ((string)x.Name == "a" || (string)x.Name == "b" || (string)x.Name == "c" || (string)x.Name == "d" || (string)x.Name == "e")
                        {
                            Canvas.SetTop(x, rand + 506);
                            rand = 0;
                        }


                            score += 0.5;
                    }

                    Rect PillarHitBox = new Rect(Canvas.GetLeft(x), Canvas.GetTop(x), x.Width, x.Height);

                    if (flappyBirdHitBox.IntersectsWith(PillarHitBox))
                    {
                        EndGame();
                    }
                }

                //if ((string)x.Tag == "clouds")
                //{
                //    Canvas.SetLeft(x, Canvas.GetLeft(x) - 1);

                //    if (Canvas.GetLeft(x) < -250)
                //    {
                //        Canvas.SetLeft(x, 550);
                //    }

                //}


            }


        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                flappyBird.RenderTransform = new RotateTransform(-20, flappyBird.Width / 2, flappyBird.Height / 2);
                speed = -10;
            }

            if (e.Key == Key.Enter && gameOver == true)
            {
                StartGame();
                Startp.IsEnabled = false;
                Startp.Visibility = Visibility.Hidden;
                Exitp.Visibility = Visibility.Hidden;
                EendScore.Visibility = Visibility.Hidden;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            flappyBird.RenderTransform = new RotateTransform(5, flappyBird.Width / 2, flappyBird.Height / 2);
            
        }

        private void StartGame()
        {
            MyCanvas.Focus();

            speed = -10;

            score = 0;

            gameOver = false;

            Canvas.SetTop(flappyBird, 190);

            foreach (var x in MyCanvas.Children.OfType<Image>())
            {
                if ((string)x.Tag == "obs1")
                {
                    Canvas.SetLeft(x, 500);
                }
                if ((string)x.Tag == "obs2")
                {
                    Canvas.SetLeft(x, 800);
                }
                if ((string)x.Tag == "obs3")
                {
                    Canvas.SetLeft(x, 1100);
                }
                if ((string)x.Tag == "obs4")
                {
                    Canvas.SetLeft(x, 1400);
                }
                if ((string)x.Tag == "obs5")
                {
                    Canvas.SetLeft(x, 1700);
                }

                //if ((string)x.Tag == "clouds")
                //{
                //    Canvas.SetLeft(x, 300 + temp);
                //    temp = 800;
                //}
            }

            gameTimer.Start();
        }

        private void EndGame()
        {
            speed = -10;
            gameTimer.Stop();
            gameOver = true;
            Startp.IsEnabled = true;
            Startp.Visibility = Visibility.Visible;
            Exitp.Visibility = Visibility.Visible;
            EendScore.Text = "Your score:" + score;
            EendScore.Visibility = Visibility.Visible;

        }

        private void Startp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StartGame();
            Startp.IsEnabled = false;
            Startp.Visibility = Visibility.Hidden;
            Exitp.Visibility = Visibility.Hidden;
            Title.Visibility = Visibility.Hidden;
            EendScore.Visibility = Visibility.Hidden;
        }

        private void Exitp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Skin_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Windows.SkinChange win1 = new Windows.SkinChange();
            win1.ShowDialog();
        }
    }
}
