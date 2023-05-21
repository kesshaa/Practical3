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

namespace Zadanie7Dop
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
            if (number >= 1 && number <= 999)
            {
                if (number % 2 == 0)
                {
                    if (number >= 10 && number <= 99)
                    {
                        TextBlockAnswer.Text="Четное двузначное число";
                    }
                    else if (number >= 100 && number <= 999)
                    {
                        TextBlockAnswer.Text = "Четное трехзначное число";
                    }
                    else
                    {
                        TextBlockAnswer.Text = "Четное однозначное число";
                    }
                }
                else
                {
                    if (number >= 10 && number <= 99)
                    {
                        TextBlockAnswer.Text = "Нечетное двузначное число";
                    }
                    else if (number >= 100 && number <= 999)
                    {
                        TextBlockAnswer.Text = "Нечетное трехзначное число";
                    }
                    else
                    {
                        TextBlockAnswer.Text = "Нечетное однозначное число";
                    }
                }
            }
            else
            {
                TextBlockAnswer.Text = "Число не входит в диапазон от 1 до 999";
            }
        }
    }
}
