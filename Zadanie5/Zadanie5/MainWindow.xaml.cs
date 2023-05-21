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

namespace Zadanie5
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

            float x = float.Parse(TbNumberA.Text);
            float y = float.Parse(TbNumberB.Text);
            if (x < 0 && x > -15 && y < 0 && y > -15)
                TextBlockAnswer.Text = "вне"; // x = -2 y = -2
            else if (x > 0 || x < -15 || y > 0 || y < -15)
                TextBlockAnswer.Text = "внутри"; // x = 4 y = 8
            else TextBlockAnswer.Text = "на границе"; // x = -15 y = -15
        }
    }
}
