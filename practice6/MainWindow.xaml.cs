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

namespace practice6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    
    public static class Fix
    {
        public static double Fixo(double n1)
        {
            double n11 = Math.Cos(2 * n1) + Math.Sin(n1 - 3);

            return n11;
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
            double a = Convert.ToDouble(NumberAA.Text);
            double b = Convert.ToDouble(NumberBB.Text);
             
            

            if (Fix.Fixo(a) < Fix.Fixo(b))
            {
                NAnswer.Content = a + " = " + Fix.Fixo(a);
            }
            else if (Fix.Fixo(a) > Fix.Fixo(b))
            {
                NAnswer.Content = b + " = " + Fix.Fixo(b);
            }
            else
            {
                NAnswer.Content = Fix.Fixo(a) + " == " + Fix.Fixo(b);
            }
        }
    }
}
