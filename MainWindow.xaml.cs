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

namespace ScientificCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double results = 0;
        decimal number1 = 0; decimal number2 = 0;
        String operation = "";
        bool enter_value = false;
        public MainWindow()
        {
            InitializeComponent();
            Display.Text = "0";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Display_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //private void Button_Click1(object sender, RoutedEventArgs e)
        //{
        //    if (operation == "")
        //    {
        //        number1 = (number1 * 10) + 1;
        //        Display.Text = number1.ToString();
        //    }
        //    else
        //    {
        //        number2 = (number2 * 10) + 1;
        //        Display.Text = number2.ToString();
        //    }
        //}

        //private void Button_Click0(object sender, RoutedEventArgs e)
        //{
        //    if (operation == "")
        //    {
        //        number1 = (number1 * 10) + 0;
        //        Display.Text = number1.ToString();
        //    }
        //    else
        //    {
        //        number2 = (number2 * 10) + 0;
        //        Display.Text = number2.ToString();
        //    }
        //}

        //private void Button_Click2(object sender, RoutedEventArgs e)
        //{
        //    if (operation == "")
        //    {
        //        number1 = (number1 * 10) + 2;
        //        Display.Text = number1.ToString();
        //    }
        //    else
        //    {
        //        number2 = (number2 * 10) + 2;
        //        Display.Text = number2.ToString();
        //    }
        //}

        //private void Button_Click3(object sender, RoutedEventArgs e)
        //{
        //    if (operation == "")
        //    {
        //        number1 = (number1 * 10) + 3;
        //        Display.Text = number1.ToString();
        //    }
        //    else
        //    {
        //        number2 = (number2 * 10) + 3;
        //        Display.Text = number2.ToString();
        //    }
        //}

        //private void Button_Click4(object sender, RoutedEventArgs e)
        //{
        //    if (operation == "")
        //    {
        //        number1 = (number1 * 10) + 4;
        //        Display.Text = number1.ToString();
        //    }
        //    else
        //    {
        //        number2 = (number2 * 10) + 4;
        //        Display.Text = number2.ToString();
        //    }
        //}

        //private void Button_Click5(object sender, RoutedEventArgs e)
        //{
        //    if (operation == "")
        //    {
        //        number1 = (number1 * 10) + 5;
        //        Display.Text = number1.ToString();
        //    }
        //    else
        //    {
        //        number2 = (number2 * 10) + 5;
        //        Display.Text = number2.ToString();
        //    }
        //}

        //private void Button_Click6(object sender, RoutedEventArgs e)
        //{
        //    if (operation == "")
        //    {
        //        number1 = (number1 * 10) + 6;
        //        Display.Text = number1.ToString();
        //    }
        //    else
        //    {
        //        number2 = (number2 * 10) + 6;
        //        Display.Text = number2.ToString();
        //    }
        //}

        //private void Button_Click7(object sender, RoutedEventArgs e)
        //{
        //    if (operation == "")
        //    {
        //        number1 = (number1 * 10) + 7;
        //        Display.Text = number1.ToString();
        //    }
        //    else
        //    {
        //        number2 = (number2 * 10) + 7;
        //        Display.Text = number2.ToString();
        //    }
        //}

        //private void Button_Click8(object sender, RoutedEventArgs e)
        //{
        //    if (operation == "")
        //    {
        //        number1 = (number1 * 10) + 8;
        //        Display.Text = number1.ToString();
        //    }
        //    else
        //    {
        //        number2 = (number2 * 10) + 8;
        //        Display.Text = number2.ToString();
        //    }
        //}

        //private void Button_Click9(object sender, RoutedEventArgs e)
        //{
        //    if (operation == "")
        //    {
        //        number1 = (number1 * 10) + 9;
        //        Display.Text = number1.ToString();
        //    }
        //    else
        //    {
        //        number2 = (number2 * 10) + 9;
        //        Display.Text = number2.ToString();
        //    }
        //}

        private void Button_Plus(object sender, RoutedEventArgs e)
        {
            operation = "+";
            number1 = decimal.Parse(Display.Text);
            Display.Text = "0";
        }

        private void Button_Divide(object sender, RoutedEventArgs e)
        {
            number1 = decimal.Parse(Display.Text);
            operation = "/";
            Display.Text = "0";

        }

        private void Button_Multiply(object sender, RoutedEventArgs e)
        {
            number1 = decimal.Parse(Display.Text);
            operation = "*";
            Display.Text = "0";
        }

        private void Button_minus(object sender, RoutedEventArgs e)
        {
            number1 = decimal.Parse(Display.Text);
            operation = "-";
            Display.Text = "0";
        }

        private void Button_Equal(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    number2 = Convert.ToInt64(Display.Text);
                    decimal sum = number1 + number2;
                    Display.Text = sum.ToString();
                    operation = "";
                    //number1 = sum;number2 = 0;
                    break;
                case "-":
                    number2 = Convert.ToInt64(Display.Text);
                    decimal diff = number1 - number2;
                    Display.Text = (diff).ToString();
                    operation = "";
                    //number1 = diff;number2 = 0;
                    break;
                case "*":
                    number2 = Convert.ToInt64(Display.Text);
                    decimal product = number1 * number2;
                    Display.Text = (product).ToString();
                    operation = "";
                    //number1 = product;number2 = 0;
                    break;
                case "/":
                    number2 = Convert.ToInt64(Display.Text);
                    if(number2==0)
                    {
                        Display.Text = "Math Error";
                        operation = "";
                        break;
                    }
                    decimal div = number1 / number2;
                    Display.Text = (div).ToString();
                    break;
                case "%":
                    number2 = Convert.ToInt64(Display.Text);
                    if (number2 == 0)
                    {
                        Display.Text = "Math Error";
                        operation = "";
                        break;
                    }
                    decimal mod = number1 % number2;
                    Display.Text = (mod).ToString();
                    break;
                case "tan":
                    double num = double.Parse(Display.Text);
                    Display.Text = Math.Tan(num).ToString();
                    break;
                case "cos":
                    double cos = double.Parse(Display.Text);
                    Display.Text = Math.Cos(cos).ToString();
                    break;
                case "sin":
                    double sin = double.Parse(Display.Text);
                    Display.Text = Math.Sin(sin).ToString(); 
                    break;
                case "sqrt":
                    double sqrt = double.Parse(Display.Text);
                    Display.Text = Math.Sqrt(sqrt).ToString();
                    break;
                case "cot":
                    double cot = double.Parse(Display.Text);
                    Display.Text = (1/Math.Tan(cot)).ToString();
                    break;
                case "sec":
                    double sec = double.Parse(Display.Text);
                    Display.Text = (1 / Math.Cos(sec)).ToString();
                    break;
                case "cosec":
                    double cosec = double.Parse(Display.Text);
                    Display.Text = (1 / Math.Sin(cosec)).ToString();
                    break;
                case "invsin":
                    double invsin = double.Parse(Display.Text);
                    Display.Text = Math.Atan(invsin / Math.Sqrt(-invsin * invsin + 1)).ToString();
                    break;
                case "invcos":
                    double invcos = double.Parse(Display.Text);
                    Display.Text = (Math.Atan(-invcos / Math.Sqrt(-invcos * invcos + 1)) + 2 * Math.Atan(1)).ToString();
                    break;
                case "invtan":
                    double invtan = double.Parse(Display.Text);
                    Display.Text = (2 * Math.Atan(1) - Math.Atan(invtan)).ToString();
                    break;
                case "log10":
                    double log10 = double.Parse(Display.Text);
                    Display.Text = Math.Log10(log10).ToString();
                    break;
                case "ln":
                    double ln = double.Parse(Display.Text);
                    Display.Text = Math.Log(ln,2).ToString();
                    break;
                case "cuberoot":
                    double cuberoot = double.Parse(Display.Text);
                    Display.Text = Math.Pow(cuberoot,3).ToString();
                    break;
                default:
                    Display.Text = "Invalid Operation";
                    break;
            }
        }

        private void Click_DeleteEntry(object sender, RoutedEventArgs e)
        {
            //if (operation == "")
            //{
            //    number1 = (number1 / 10);
            //    Display.Text = number1.ToString();
            //}
            //else
            //{
            //    number2 = (number2 / 10);
            //    Display.Text = number2.ToString();
            //}
            Display.Text = (Convert.ToInt64(Display.Text) / 10).ToString();
        }

        private void Button_Clear(object sender, RoutedEventArgs e)
        {
            number1 = 0;number2 = 0;operation = "";Display.Text = "0";
        }

        private void Numeric_Buttons(object sender, RoutedEventArgs e)
        {
            if (Display.Text == "0")
            {
                Display.Clear();
               
            }
            Button btn = (Button)sender;
            Display.Text += btn.Content;
        }

        private void Button_mod(object sender, RoutedEventArgs e)
        {
            number1 = decimal.Parse(Display.Text);
            operation = "%";
            Display.Text = "0";
        }

        private void Button_dot(object sender, RoutedEventArgs e)
        {
            if(!Display.Text.Contains('.'))
            {
                Display.Text += ".";
            }
        }

        private void button_pi(object sender, RoutedEventArgs e)
        {
            Display.Text = Math.PI.ToString();
        }

        private void button_tan(object sender, RoutedEventArgs e)
        {
            operation = "tan";
            Display.Text = "0";
        }

        private void button_cos(object sender, RoutedEventArgs e)
        {
            operation = "cos";
            Display.Text = "0";
        }

        private void Button_sin(object sender, RoutedEventArgs e)
        {
            operation = "sin";
            Display.Text = "0";
        }

        private void button_sqrt(object sender, RoutedEventArgs e)
        {
            operation = "sqrt";
            Display.Text = "0";
        }

        private void Button_sec(object sender, RoutedEventArgs e)
        {
            operation = "sec";
            Display.Text = "0";
        }

        private void Button_cot(object sender, RoutedEventArgs e)
        {
            operation = "cot";
            Display.Text = "0";
        }

        private void Button_Cosec(object sender, RoutedEventArgs e)
        {
            operation = "cosec";
            Display.Text = "0";
        }

        private void Button_invSin(object sender, RoutedEventArgs e)
        {
            operation = "invsin";
            Display.Text = "0";
        }

        private void Button_invCos(object sender, RoutedEventArgs e)
        {

            operation = "invcos";
            Display.Text = "0";

        }

        private void Button_invtan(object sender, RoutedEventArgs e)
        {
            operation = "invtan";
            Display.Text = "0";
        }

        private void Button_log10(object sender, RoutedEventArgs e)
        {
            operation = "log10";
            Display.Text = "0";
        }

        private void Button_ln(object sender, RoutedEventArgs e)
        {
            operation = "ln";
            Display.Text = "0";
        }

        private void Button_cuberoot(object sender, RoutedEventArgs e)
        {
            operation = "cuberoot";
            Display.Text = "0";
        }
    }
}