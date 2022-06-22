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
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;

namespace AIS_Games.Windows
{

    public partial class Pupsik : Window
    { 
        public string ViewModel { get; set ; }
        public Pupsik()
        {
            InitializeComponent();
        }

        public void ShowViewModel()
        {
                MessageBox.Show(ViewModel);
        }

        private void Grid_MouseDown_Translate(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            double duration = 0.5;
            // Начало движения каждого элемента задерживается на данную величину.
            double begin = 0.3;
            int count = 0;
            AnimationBorder(border1, duration, begin * count++);
            AnimationBorder(border2, duration, begin * count++);
            AnimationBorder(border3, duration, begin * count++);
            AnimationBorder(border4, duration, begin * count++);
        }

        private void AnimationBorder(Border border, double duration, double begin)
        {
            border.RenderTransform = new TranslateTransform();

            var daTranslateX = new DoubleAnimation
            {
                From = 0,
                // По оси X перемещение до середины.
                To = 0,
                Duration = TimeSpan.FromSeconds(duration),
                // Этой строчкой можно разнообразить эффекты перемещения.
                //AutoReverse = true,
                BeginTime = TimeSpan.FromSeconds(begin),
            };
            ((TranslateTransform)border.RenderTransform).
                BeginAnimation(TranslateTransform.XProperty, daTranslateX);

            var daTranslateY = new DoubleAnimation
            {
                From = border.Margin.Top,
                // По оси Y перемещение до нижнего края.
                To = ((Grid)border.Parent).ActualHeight - border.Height,
                Duration = TimeSpan.FromSeconds(duration),
                // Этой строчкой можно разнообразить эффекты перемещения.
                //AutoReverse = true,
                BeginTime = TimeSpan.FromSeconds(begin),
            };
            ((TranslateTransform)border.RenderTransform).
                BeginAnimation(TranslateTransform.YProperty, daTranslateY);
        }

    }
}

