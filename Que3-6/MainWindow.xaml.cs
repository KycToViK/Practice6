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

namespace Que3_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public static class Fir
    {
        public static double Gipotinuza(double a, double b)
        {
            double a1 = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

            return a1;
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
            double AB = Convert.ToDouble(NumberAA.Text);
            double AC = Convert.ToDouble(NumberBB.Text);
            double DC = Convert.ToDouble(NumberCC.Text);

            

            double P = AB + AC + DC + Fir.Gipotinuza(Fir.Gipotinuza(AB, AC), DC);

            NAnswer.Content = P;
        }
    }
}
