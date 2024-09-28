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

namespace Calculator.Controls
{
    /// <summary>
    /// Interaction logic for CalculatorControl.xaml
    /// </summary>
    public partial class CalculatorControl : UserControl
    {
        public CalculatorControl()
        {
            InitializeComponent();
        }

        private void acButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void positiveOrNegativeButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void percentageButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultsTextBlock.Text == "0")
            {
                resultsTextBlock.Text = string.Empty;
                resultsTextBlock.Text += "7"; 
            }
            else
            {
                resultsTextBlock.Text += "7";
            }
            
        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultsTextBlock.Text == "0")
            {
                resultsTextBlock.Text = string.Empty;
                resultsTextBlock.Text += "8";
            }
            else
            {
                resultsTextBlock.Text += "8";
            }

        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultsTextBlock.Text == "0")
            {
                resultsTextBlock.Text = string.Empty;
                resultsTextBlock.Text += "9";
            }
            else
            {
                resultsTextBlock.Text += "9";
            }
        }

        private void multipliyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultsTextBlock.Text == "0")
            {
                resultsTextBlock.Text = string.Empty;
                resultsTextBlock.Text += "4";
            }
            else
            {
                resultsTextBlock.Text += "4";
            }
        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultsTextBlock.Text == "0")
            {
                resultsTextBlock.Text = string.Empty;
                resultsTextBlock.Text += "5";
            }
            else
            {
                resultsTextBlock.Text += "5";
            }
        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultsTextBlock.Text == "0")
            {
                resultsTextBlock.Text = string.Empty;
                resultsTextBlock.Text += "6";
            }
            else
            {
                resultsTextBlock.Text += "6";
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultsTextBlock.Text == "0")
            {
                resultsTextBlock.Text = string.Empty;
                resultsTextBlock.Text += "1";
            }
            else
            {
                resultsTextBlock.Text += "1";
            }
        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultsTextBlock.Text == "0")
            {
                resultsTextBlock.Text = string.Empty;
                resultsTextBlock.Text += "2";
            }
            else
            {
                resultsTextBlock.Text += "2";
            }
        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultsTextBlock.Text == "0")
            {
                resultsTextBlock.Text = string.Empty;
                resultsTextBlock.Text += "3";
            }
            else
            {
                resultsTextBlock.Text += "3";
            }
        }

        private void subtractButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultsTextBlock.Text == "0")
            {
                resultsTextBlock.Text = string.Empty;
                resultsTextBlock.Text += "0";
            }
            else
            {
                resultsTextBlock.Text += "0";
            }
        }

        private void decimalButton_Click(object sender, RoutedEventArgs e)
        {
            if (resultsTextBlock.Text == "0")
            {
                resultsTextBlock.Text = "0";
                resultsTextBlock.Text += ".";
            }
            else if (resultsTextBlock.Text.Contains("."))
            {

                MessageBox.Show("**** Numbers cannot have more than one decimal place you silly goose! ****");
                resultsTextBlock.Text = "0";
            }
            else
            {
                resultsTextBlock.Text += ".";
            }
        }

        private void equalbutton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
