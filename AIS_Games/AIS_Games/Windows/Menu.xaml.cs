using System.Windows;

namespace AIS_Games.Windows
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Pupsik difficult = new Pupsik();
            difficult.ViewModel = "Good Luck";
            difficult.Show();

            difficult.ShowViewModel();
        }
    }
}
