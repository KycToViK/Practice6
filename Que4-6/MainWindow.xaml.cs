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

namespace Que4_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public static class Fit
    {
        public static double Fito(int x1)
        {
            if (x1 <= 5)
                return (Math.Pow(x1, 2) + 5);
            else if (x1 > 5 && x1 < 20)
                return 0;
            else
                return 1;
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
            List.Items.Clear();

            int a = Convert.ToInt32(NumberAA.Text);
            int b = Convert.ToInt32(NumberBB.Text);
            int h = Convert.ToInt32(NumberCC.Text);
            int ab = b - a;

            

            for (int x = 0; ab - h >= 0; x++)
            {
                List.Items.Add(Fit.Fito(x));
                ab -= h;
            }

        }
    }
}
