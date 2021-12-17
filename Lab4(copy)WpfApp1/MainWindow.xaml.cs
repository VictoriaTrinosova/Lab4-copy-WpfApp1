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

namespace Lab4_copy_WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateDollar1 = Convert.ToDouble(rate1.Text);
            double sumDollar1 = Convert.ToDouble(sum1.Text);
            double resDouble1 = rateDollar1 * sumDollar1;
            resSum1.Text = resDouble1.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateDollar2 = Convert.ToDouble(rate2.Text);
            double sumDollar2 = Convert.ToDouble(sum2.Text);
            double resDouble2 = rateDollar2 * sumDollar2;
            resSum2.Text = resDouble2.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDollar3 = Convert.ToDouble(rate3.Text);
            double sumDollar3 = Convert.ToDouble(sum3.Text);
            double resDouble3 = rateDollar3 * sumDollar3;
            resSum3.Text = resDouble3.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double Inch = Convert.ToDouble(inch.Text);
            double Result = 0.025 * Inch;
            result.Text = Result.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double Inch1 = Convert.ToDouble(inch1.Text);
            double Result1 = 0.3048 * Inch1;
            result1.Text = Result1.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double Inch2 = Convert.ToDouble(inch2.Text);
            double Result2 = 1609.34 * Inch2;
            result2.Text = Result2.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double Inch3 = Convert.ToDouble(inch3.Text);
            double Result3 = 1066.8 * Inch3;
            result3.Text = Result3.ToString();
        }
    }
}
