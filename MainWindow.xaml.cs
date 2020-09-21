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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1, number2 = 0;
        string operation = "";

        public MainWindow()
        {
            InitializeComponent();
        }
        #region Nums
        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            int num = 0;
            AddNumOnMainNums(num);
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            int num = 1;
            AddNumOnMainNums(num);
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            int num = 2;
            AddNumOnMainNums(num);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            int num = 3;
            AddNumOnMainNums(num);
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            int num = 4;
            AddNumOnMainNums(num);
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            int num = 5;
            AddNumOnMainNums(num);
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            int num = 6;
            AddNumOnMainNums(num);
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            int num = 7;
            AddNumOnMainNums(num);
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            int num = 8;
            AddNumOnMainNums(num);
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            int num = 9;
            AddNumOnMainNums(num);
        }

        public void AddNumOnMainNums(int numValue)
        {
            if (operation == "")
            {
                number1 = (number1 * 10) + numValue;
                txtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 * 10) + numValue;
                txtDisplay.Text = number2.ToString();
            }
        }
        #endregion

        #region Operations

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            txtDisplay.Text = "0";
        }

        private void btnMines_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            txtDisplay.Text = "0";
        }

        private void btnTimes_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            txtDisplay.Text = "0";
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (number1 - number2).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (number1 * number2).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (number1 / number2).ToString();
                    break;
            }
        }

        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            txtDisplay.Text = "0";
        }
        #endregion
    }
}
