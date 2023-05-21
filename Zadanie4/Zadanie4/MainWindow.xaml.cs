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

namespace Zadanie4
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
            double x = double.Parse(TbNumberA.Text);
            double k = double.Parse(TbNumberB.Text);
            
            double y;
            if (k == 3)
            {
                y = Math.Sin(x) + 2;
            }
            else if (k == 10 || k == 15)
            {
                y = Math.Tan(x) + Math.Sin(x);
            }
            else if (k == 20)
            {
                y = Math.Cos(x * x);
            }
            else
            {
                TextBlockAnswer.Text = $"Значение y не определено";
                return;
            }
            TextBlockAnswer.Text=$"Значение функции равно {y:f2}";
        }
    }
}
