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

namespace GUIForSimpleCalc
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string var;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void but_1_Click(object sender, RoutedEventArgs e)
        {
            //Assign nomor pada button
            var = var + "1";
            Output.Content = var;
        }

        private void but_2_Click(object sender, RoutedEventArgs e)
        {
            var = var + "2";
            Output.Content = var;
        }

        private void but_3_Click(object sender, RoutedEventArgs e)
        {
            var = var + "3";
            Output.Content = var;
        }

        private void but_4_Click(object sender, RoutedEventArgs e)
        {
            var = var + "4";
            Output.Content = var;
        }

        private void but_plus_Click(object sender, RoutedEventArgs e)
        {
            var = var + "+";
            Output.Content = var;
        }
        // Calculation Logic
        private void but_equal_Click(object sender, RoutedEventArgs e)
        {
            int i = 1;
            int num2 = -00001;
            string op = "!";
            int calc = int.Parse(var.Substring(0 , 1));
            /*
            num1 = Convert.ToInt32(var.Substring(0,1));
            num2 = Convert.ToInt32(var.Substring(2, 1));
            Output.Content = num1 + num2;
            */
            while (i < var.Length)
            {
                if (op == "!" || num2 == -00001)
                {
                    if (op == "!")
                    {
                        if (var.Substring(i, 1) == "+")
                        {
                            op = "+";
                        }
                    }
                    if (num2 == -00001)
                    {
                        if (var.Substring(i , 1) != "+")
                        {
                            string h = var.Substring(i , 1);
                            num2 = int.Parse(h);
                        }
                    }
                }
                if(op != "!" && num2 != -00001)
                {
                    calc = calc + num2;
                    op = "!";
                    num2 = -00001;
                }
                i++;
            }
            Output.Content = Convert.ToString(calc);
            var = "";
        }

        private void but_5_Click(object sender, RoutedEventArgs e)
        {
            var = var + "5";
            Output.Content = var;
        }

        private void but_6_Click(object sender, RoutedEventArgs e)
        {
            var = var + "6";
            Output.Content = var;
        }

        private void but_7_Click(object sender, RoutedEventArgs e)
        {
            var = var + "7";
            Output.Content = var;
        }

        private void but_8_Click(object sender, RoutedEventArgs e)
        {
            var = var + "8";
            Output.Content = var;
        }

        private void but_9_Click(object sender, RoutedEventArgs e)
        {
            var = var + "9";
            Output.Content = var;
        }

        private void but_0_Click(object sender, RoutedEventArgs e)
        {
            var = var + "0";
            Output.Content = var;
        }
    }
}
