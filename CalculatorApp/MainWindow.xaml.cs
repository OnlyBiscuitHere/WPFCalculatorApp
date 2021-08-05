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
using CalculatorModel;

namespace CalculatorApp
{
    public partial class MainWindow : Window
    {
        private Calculator _calculator;
        private string _number;
        private string operation;
        public MainWindow()
        {
            InitializeComponent();
            _calculator = new Calculator();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            tbxOp.Text = "+";
            operation = "+";
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            tbxOp.Text = "-";
            operation = "-";
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            tbxOp.Text = "X";
            operation = "X";
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            tbxOp.Text = "/";
            operation = "/";
        }

        private void tbxNum1_TextChanged(object sender, TextChangedEventArgs e)
        {
            var success = double.TryParse(tbxNum1.Text, out double num1);
            if (success)
            {
                _calculator.Num1 = num1;
            }
            else
            {
                lblResult.Content = "Invalid input!";
            }
        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            _number = "1";
            if (tbxOp.Text == "")
            {
                tbxNum1.Text += "1";
            }
            else
            {
                tbxNum2.Text += "1";
            }
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            _number = "2";
            if (tbxOp.Text == "")
            {
                tbxNum1.Text += "2";
            }
            else
            {
                tbxNum2.Text += "2";
            }
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            _number = "3";
            if (tbxOp.Text == "")
            {
                tbxNum1.Text += "3";
            }
            else
            {
                tbxNum2.Text += "3";
            }
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            _number = "4";
            if (tbxOp.Text == "")
            {
                tbxNum1.Text += "4";
            }
            else
            {
                tbxNum2.Text += "4";
            }
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            _number = "5";
            if (tbxOp.Text == "")
            {
                tbxNum1.Text += "5";
            }
            else
            {
                tbxNum2.Text += "5";
            }
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            _number = "6";
            if (tbxOp.Text == "")
            {
                tbxNum1.Text += "6";
            }
            else
            {
                tbxNum2.Text += "6";
            }
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            _number = "7";
            if (tbxOp.Text == "")
            {
                tbxNum1.Text += "7";
            }
            else
            {
                tbxNum2.Text += "7";
            }
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            _number = "8";
            if (tbxOp.Text == "")
            {
                tbxNum1.Text += "8";
            }
            else
            {
                tbxNum2.Text += "8";
            }
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            _number = "9";
            if (tbxOp.Text == "")
            {
                tbxNum1.Text += "9";
            }
            else
            {
                tbxNum2.Text += "9";
            }
        }

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            _number = "0";
            if (tbxOp.Text == "")
            {
                tbxNum1.Text += "0";
            }
            else
            {
                tbxNum2.Text += "0";
            }
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            var firstValue = double.TryParse(tbxNum1.Text, out double num1);
            var secondValue = double.TryParse(tbxNum2.Text, out double num2);
            try
            {
                if (firstValue)
                {
                    _calculator.Num1 = num1;
                    if (secondValue)
                    {
                        _calculator.Num2 = num2;
                        switch (operation)
                        {
                            case "+":
                                lblResult.Content = _calculator.Add();
                                break;
                            case "-":
                                lblResult.Content = _calculator.Subtract();
                                break;
                            case "X":
                                lblResult.Content = _calculator.Multiply();
                                break;
                            case "/":
                                lblResult.Content = _calculator.Divide();
                                break;
                            case "%":
                                lblResult.Content = _calculator.Modulus();
                                break;
                        }
                    }
                    else
                    {
                        lblResult.Content = "Invalid input!";
                    }
                }
                else
                {
                    lblResult.Content = "Invalid input!";
                }
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void Decimal_Click(object sender, RoutedEventArgs e)
        {
            _number = ".";
            if (tbxOp.Text == "")
            {
                tbxNum1.Text += ".";
            }
            else
            {
                tbxNum2.Text += ".";
            }
        }

        private void tbxNum2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxNum3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxOp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxNum2_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void tbxNum2_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (tbxOp.Text == "")
            {
                tbxNum1.Text.Remove(tbxNum1.Text.Length - 1, 1);
            }
            else
            {
                tbxNum2.Text.Remove(tbxNum1.Text.Length - 1, 1);
            }
        }

        private void CEntry_Click(object sender, RoutedEventArgs e)
        {
            if (tbxOp.Text == "")
            {
                tbxNum1.Text = "";
            }
            else
            {
                tbxNum2.Text = "";
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            tbxNum1.Text = "";
            tbxNum2.Text = "";
            tbxOp.Text = "";
        }

        private void btnMod_Click(object sender, RoutedEventArgs e)
        {
            tbxOp.Text = "%";
            operation = "%";
        }
    }
}
