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

namespace Wheel
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


        private void PlayWheel(object sender, RoutedEventArgs e)
        {
            MainWindow wheel = new MainWindow();
            Questions.ExpertPoints = 0;
            Questions.ViewerPoints = 0;
            wheel.ShowDialog();
        }

        private void RulesOpen(object sender, RoutedEventArgs e)
        {
            Rules rule = new Rules();
            rule.ShowDialog();
        }

        private void ExitGame(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Are you sure?", "Exit");
            this.Close();
        }
    }
}
