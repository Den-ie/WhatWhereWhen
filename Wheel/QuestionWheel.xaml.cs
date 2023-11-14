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
    /// Логика взаимодействия для QuestionWheel.xaml
    /// </summary>
    public partial class QuestionWheel : Window
    {
         List<(string, string)> _vopr = new List<(string, string)> ();
        int _award;
        
        public QuestionWheel(List<(string, string)> Vopr, int award)
        {
            InitializeComponent();
            Quest.Content = Vopr[award].Item1;
            _vopr = Vopr;
            _award = award;
        }

        private void GiveAnswer(object sender, RoutedEventArgs e)
        {
            if (Answer.Text == _vopr[_award].Item2)
                MessageBox.Show("Ответ правильный! \n Зарабатывает Матье балл");
            else MessageBox.Show("Ответ неправильный!");
        }
    }
}
