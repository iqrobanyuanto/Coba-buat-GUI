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
        public MainWindow()
        {
            InitializeComponent();
        }
        string var;
        int max = 0;

        private void but_1_Click(object sender, RoutedEventArgs e)
        {
            var = var + "1";
            Output.Content = var;
            max++;
        }

        private void but_2_Click(object sender, RoutedEventArgs e)
        {
            var = var + "2";
            Output.Content = var;
            max++;
        }

        private void but_3_Click(object sender, RoutedEventArgs e)
        {
            var = var + "3";
            Output.Content = var;
            max++;
        }

        private void but_4_Click(object sender, RoutedEventArgs e)
        {
            var = var + "4";
            Output.Content = var;
            max++;
        }

        private void but_plus_Click(object sender, RoutedEventArgs e)
        {
            var = var + "+";
            Output.Content = var;
            max++;
        }

        private void but_equal_Click(object sender, RoutedEventArgs e)
        {
            int num1;
            int num2 = -00001;
            int calc;
            string op = "!";
            int i = 0;
            num1 = Convert.ToInt32(var.Substring(0,1));
            num2 = Convert.ToInt32(var.Substring(2, 1));
            Output.Content = num1 + num2;
            /*
            while (i < max)
            {
                if (num2 == -00001 || op == "!")
                {
        
                i++;
            }
            */
        }

    }
}