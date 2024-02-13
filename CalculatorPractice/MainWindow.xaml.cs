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

namespace CalculatorPractice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string a = "";
        string b = "";
        string operatorString = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            if (operatorString == "")
                a += (sender as Button).Content;
            else
                b += (sender as Button).Content;
            ResultTb.Text = a + operatorString + b;
        }

        private void OperatorButton_Click(object sender, RoutedEventArgs e)
        {
            if(a != "" && b == "")
                operatorString = (sender as Button).Content.ToString();
            ResultTb.Text = a + operatorString + b;
        }

        private void CleareBtn_Click(object sender, RoutedEventArgs e)
        {
            a = "";
            b = "";
            operatorString = "";
            ResultTb.Text = "";
        }

        private void CalculateBtn_Click(object sender, RoutedEventArgs e)
        {
            //if (a == "" || b == "")
            //    return;
            double x = double.Parse(a);
            double y = double.Parse(b);
            switch (operatorString)
            {
                case "+":
                    a = (x + y).ToString();
                    break;
                case "-":
                    a = (x - y).ToString();
                    break;
                case "*":
                    a = (x * y).ToString();
                    break;
                case "/":
                    a = (x / y).ToString();
                    break;
                case "^":
                    a = Math.Pow(x, y).ToString();
                    break;
            }
            operatorString = "";
            b = "";
            ResultTb.Text = a + operatorString + b;
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (operatorString == "")
                a = a.Remove(a.Length - 1);
            else if (b == "")
                operatorString = "";
            else
                b = b.Remove(b.Length - 1);
            ResultTb.Text = a + operatorString + b;
        }

        private void InverseBtn_Click(object sender, RoutedEventArgs e)
        {
            b = a;
            a = "1";
            operatorString = "/";
            CalculateBtn_Click(sender, e);
        }

        private void NegateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (a != "" && operatorString == "")
                a = (double.Parse(a) * -1).ToString();
            else if (b != "")
                b = (double.Parse(b) * -1).ToString();
            ResultTb.Text = a + operatorString + b;
        }

        private void SqrtBtn_Click(object sender, RoutedEventArgs e)
        {
            if (a == "")
                return;
            b = ((double)1/2).ToString();
            operatorString = "^";
            CalculateBtn_Click(sender, e);
        }

        private void SqBtn_Click(object sender, RoutedEventArgs e)
        {
            if (a == "")
                return;
            b = "2";
            operatorString = "^";
            CalculateBtn_Click(sender, e);
        }

        private void CubeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (a == "")
                return;
            b = "3";
            operatorString = "^";
            CalculateBtn_Click(sender, e);
        }

        private void PowBtn_Click(object sender, RoutedEventArgs e)
        {
            if (a != "" && b == "")
                operatorString = "^";
            ResultTb.Text = a + operatorString + b;
        }

        private void CommaBtn_Click(object sender, RoutedEventArgs e)
        {
            if (a != "" && !a.Contains(",") && operatorString == "")
                a += ",";
            else if (b != "" && !b.Contains(","))
                b += ",";
            ResultTb.Text = a + operatorString + b;
        }

        private void FactorialBtn_Click(object sender, RoutedEventArgs e)
        {
            if (a == "")
                return;
            operatorString = "";
            b = "";
            double factorial = 1;
            for (int i = 2; i <= double.Parse(a); i++)
                factorial *= i;
            a = factorial.ToString();
            ResultTb.Text = a;
        }

        private void SinBtn_Click(object sender, RoutedEventArgs e)
        {
            operatorString = "";
            b = "";
            a = Math.Sin(double.Parse(a)).ToString();
            ResultTb.Text = a;
        }

        private void CosBtn_Click(object sender, RoutedEventArgs e)
        {
            operatorString = "";
            b = "";
            a = Math.Cos(double.Parse(a)).ToString();
            ResultTb.Text = a;
        }

        private void TanBtn_Click(object sender, RoutedEventArgs e)
        {
            operatorString = "";
            b = "";
            a = Math.Tan(double.Parse(a)).ToString();
            ResultTb.Text = a;
        }

        private void CubertBtn_Click(object sender, RoutedEventArgs e)
        {
            operatorString = "";
            b = "";
            a = Math.Pow(double.Parse(a), (double)1/3).ToString();
            ResultTb.Text = a;
        }

        private void LnBtn_Click(object sender, RoutedEventArgs e)
        {
            operatorString = "";
            b = "";
            a = Math.Log(double.Parse(a)).ToString();
            ResultTb.Text = a;
        }

        private void CtgBtn_Click(object sender, RoutedEventArgs e)
        {
            operatorString = "";
            b = "";
            a = (Math.Cos(double.Parse(a))/Math.Sin(double.Parse(a))).ToString();
            ResultTb.Text = a;
        }
    }
}
