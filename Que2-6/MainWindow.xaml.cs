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

namespace Que2_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public static class Fig
    {
        public static double Figo(int x)
        {
            int da;
            if (x % 2 == 0)
            {
                da = x / 2;
            }
            else
            {
                da = 0;
            }

            return da;
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnZ_Click(object sender, RoutedEventArgs e)
        {
            NAnswer.Content = Fig.Figo(Convert.ToInt32(NumberAA.Text));
        }
    }
}
