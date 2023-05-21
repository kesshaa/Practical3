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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Zadanie6Dop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            int number = int.Parse(TbNumberA.Text);
            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    TextBlockAnswer.Text="Положительное четное число";
                }
                else
                {
                    TextBlockAnswer.Text = "Положительное нечетное число";
                }
            }
            else if (number < 0)
            {
                if (number % 2 == 0)
                {
                    TextBlockAnswer.Text = "Отрицательное четное число";
                }
                else
                {
                    TextBlockAnswer.Text = "Отрицательное нечетное число";
                }
            }
            else
            {
                TextBlockAnswer.Text = "Нулевое число";
            }

        }
    }
}
