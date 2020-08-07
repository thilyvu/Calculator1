using System;
using System.Collections.Generic;
using System.Globalization;
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

namespace Caculator11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TB.Text = "0";
        }

        public static class myglobal
        {
            public const string defaut = "0";
            public static double current = 0;
            public static int pheptinh = 4;
        }

        public static Boolean IsNumeric(Object Expression)
        {
            if (Expression == null || Expression is DateTime)
                return false;

            if (Expression is Int16 || Expression is Int32 || Expression is Int64 || Expression is Decimal
            || Expression is Single || Expression is Double || Expression is Boolean)
                return true;

            try
            {
                if (Expression is string)
                    Double.Parse(Expression as string);
                else
                    Double.Parse(Expression.ToString());
                return true;
            }
            catch { }
            return false;
        }
        private void AC_Click(object sender, RoutedEventArgs e)
        {
            TB.Text = "0";
            TBlock.Text = "AC";
        }
        private void ____Click(object sender, RoutedEventArgs e)
        {
            TBlock.Text = "+/-";
            try
            {
                if (IsNumeric(TB.Text))
                {
                    double a = Convert.ToDouble(TB.Text);
                    double b = -a;
                    this.TB.Text = b.ToString();
                }
                else
                    TB.Text = "0";
            }
            catch
            {

            }
        }

        private void ___Click(object sender, RoutedEventArgs e)
        {
            TBlock.Text = "%";
            try
            {
                if (IsNumeric(TB.Text))
                {
                    double a = Convert.ToDouble(TB.Text);
                    double b = a / 100;
                    this.TB.Text = b.ToString();
                }
                else
                    TB.Text = "0";
            }
            catch
            {

            }
        }

        private void __1_Click(object sender, RoutedEventArgs e)
        {
            TBlock.Text = "/";
            try
            {
                if (IsNumeric(TB.Text))
                {
                    double a = Convert.ToDouble(TB.Text);
                    myglobal.current = a;
                    myglobal.pheptinh = 0;
                    this.TB.Text = "0";
                }
                else
                    TB.Text = "0";
                //TB.Text += "/";
            }
            catch
            {

            }
        }

        private void _7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TB.Text == "0")
                {
                    TB.Text = "7";
                }
                else
                    TB.Text += "7";
            }
            catch
            {

            }
        }

        private void _8_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TB.Text == "0")
                {
                    TB.Text = "8";
                }
                else
                    TB.Text += "8";
            }
            catch
            {

            }
        }

        private void _9_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TB.Text == "0")
                {
                    TB.Text = "9";
                }
                else
                    TB.Text += "9";
            }
            catch
            {

            }
        }

        private void x_Click(object sender, RoutedEventArgs e)
        {
            TBlock.Text = "x";
            try
            {
                if (IsNumeric(TB.Text))
                {

                    double a = Convert.ToDouble(TB.Text);
                    myglobal.current = a;
                    myglobal.pheptinh = 1;
                    this.TB.Text = "0";
                }
                else
                    TB.Text = "0";
                //TB.Text += "x";
            }
            catch
            {

            }
        }

        private void _4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TB.Text == "0")
                {
                    TB.Text = "4";
                }
                else
                    TB.Text += "4";
            }
            catch
            {

            }
        }

        private void _5_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TB.Text == "0")
                {
                    TB.Text = "5";
                }
                else
                    TB.Text += "5";
            }
            catch
            {

            }
        }

        private void _6_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TB.Text == "0")
                {
                    TB.Text = "6";
                }
                else
                    TB.Text += "6";
            }
            catch
            {

            }
        }

        private void __2_Click(object sender, RoutedEventArgs e)
        {
            TBlock.Text = "-";
            try
            {
                if (IsNumeric(TB.Text))
                {
                    double a = Convert.ToDouble(TB.Text);
                    myglobal.current = a;
                    myglobal.pheptinh = 2;
                    this.TB.Text = "0";
                }
                else
                    TB.Text = "0";
                //TB.Text += "-";
            }
            catch
            {

            }
        }

        private void _1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TB.Text == "0")
                {
                    TB.Text = "1";
                }
                else
                    TB.Text += "1";
            }
            catch
            {

            }
        }

        private void _2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TB.Text == "0")
                {
                    TB.Text = "2";
                }
                else
                    TB.Text += "2";
            }
            catch
            {

            }
        }

        private void _3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TB.Text == "0")
                {
                    TB.Text = "3";
                }
                else
                    TB.Text += "3";
            }
            catch
            {

            }
        }

        private void __3_Click(object sender, RoutedEventArgs e)
        {
            TBlock.Text = "+";
            if (IsNumeric(TB.Text))
            {
                double a = Convert.ToDouble(TB.Text);
                myglobal.current = a;
                myglobal.pheptinh = 3;
                this.TB.Text = "0";
            }
            else
                TB.Text = "0";
           // TB.Text += "+";
        }

        private void _0_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TB.Text == "0")
                {
                    TB.Text = "0";
                }
                TB.Text += "0";
            }
            catch
            {

            }
        }

        private void __4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TB.Text += ".";
            }
            catch
            {

            }
            
        }

        private void __5_Click(object sender, RoutedEventArgs e)
        {
            TBlock.Text = "=";
            try
            {
                if (IsNumeric(TB.Text))
                {
                    double a = Convert.ToDouble(TB.Text);
                    double b;
                    switch (myglobal.pheptinh)
                    {
                        case 0:
                            b = myglobal.current / a;
                            break;
                        case 1:
                            b = myglobal.current * a;
                            break;
                        case 2:
                            b = myglobal.current - a;
                            break;
                        case 3:
                            b = myglobal.current + a;
                            break;
                        default:
                            b = a;
                            break;
                    }

                    TB.Text = b.ToString();
                }
                else
                    TB.Text = "0";
            }
            catch
            {
                MessageBox.Show("error");
            }
        }
    }
}
