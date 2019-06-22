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

namespace _32_WPF_MultiBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string str, simb, msg;
        double x, y;
        private void button0_Click(object sender, RoutedEventArgs e)
        {
            if (str != "0")
            {
                str += "0";
                msg += "0";
                textBlock_1.Text = str;
                textBlock.Text = msg;
            }
            else
            {
                textBlock_1.Text = "0";
                textBlock.Text = "0";
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (str == "0")
                str = "1";
            else
                str += "1";
            if (msg == "0")
                msg = "1";
            else
                msg += "1";
            textBlock_1.Text = str;
            textBlock.Text = msg;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (str == "0")
                str = "2";
            else
                str += "2";
            if (msg == "0")
                msg = "2";
            else
                msg += "2";
            textBlock_1.Text = str;
            textBlock.Text = msg;
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (str == "0")
                str = "3";
            else
                str += "3";
            if (msg == "0")
                msg = "3";
            else
                msg += "3";
            textBlock_1.Text = str;
            textBlock.Text = msg;
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (str == "0")
                str = "4";
            else
                str += "4";
            if (msg == "0")
                msg = "4";
            else
                msg += "4";
            textBlock_1.Text = str;
            textBlock.Text = msg;
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (str == "0")
                str = "5";
            else
                str += "5";
            if (msg == "0")
                msg = "5";
            else
                msg += "5";
            textBlock_1.Text = str;
            textBlock.Text = msg;
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (str == "0")
                str = "6";
            else
                str += "6";
            if (msg == "0")
                msg = "6";
            else
                msg += "6";
            textBlock_1.Text = str;
            textBlock.Text = msg;
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (str == "0")
                str = "7";
            else
                str += "7";
            if (msg == "0")
                msg = "7";
            else
                msg += "7";
            textBlock_1.Text = str;
            textBlock.Text = msg;
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (str == "0")
                str = "8";
            else
                str += "8";
            if (msg == "0")
                msg = "8";
            else
                msg += "8";
            textBlock_1.Text = str;
            textBlock.Text = msg;
        }

        private void buttonPnt_Click(object sender, RoutedEventArgs e)
        {
            if (!str.Contains(","))
            {
                str += ",";
                msg += ",";
            }
            textBlock_1.Text = str;
            textBlock.Text = msg;
        }

        private void buttonPls_Click(object sender, RoutedEventArgs e)
        {
            x = double.Parse(textBlock_1.Text);
            str = "0";
            simb = "+";
            if (msg != "0")
                msg += " + ";
            textBlock.Text = msg;
        }

        private void buttonEql_Click(object sender, RoutedEventArgs e)
        {
            y = double.Parse(textBlock_1.Text);
            switch (simb)
            {
                case "+": { textBlock_1.Text = (x + y).ToString(); str = "0"; simb = ""; msg += $" = {x + y}"; textBlock.Text = msg; } break;
                case "-": { textBlock_1.Text = (x - y).ToString(); str = "0"; simb = ""; msg += $" = {x - y}"; textBlock.Text = msg; } break;
                case "*": { textBlock_1.Text = (x * y).ToString(); str = "0"; simb = ""; msg += $" = {x * y}"; textBlock.Text = msg; } break;
                case "/": { if (y != 0) { textBlock_1.Text = (x / y).ToString(); str = "0"; simb = ""; msg += $" = {x / y}"; textBlock.Text = msg; } } break;
            }
        }

        private void buttonMns_Click(object sender, RoutedEventArgs e)
        {
            x = double.Parse(textBlock_1.Text);
            str = "0";
            simb = "-";
            if (msg != "0")
                msg += " - ";
            textBlock.Text = msg;
        }

        private void buttonMlt_Click(object sender, RoutedEventArgs e)
        {
            x = double.Parse(textBlock_1.Text);
            str = "0";
            simb = "*";
            if (msg != "0")
                msg += " * ";
            textBlock.Text = msg;
        }

        private void buttonDvd_Click(object sender, RoutedEventArgs e)
        {
            x = double.Parse(textBlock_1.Text);
            str = "0";
            simb = "/";
            if (msg != "0")
                msg += " / ";
            textBlock.Text = msg;
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            str = "0";
            simb = "";
            msg = "0";
            x = 0;
            y = 0;
            textBlock.Text = msg;
            textBlock_1.Text = "0";
        }

        private void buttonBS_Click(object sender, RoutedEventArgs e)
        {
            if (textBlock_1.Text.Length > 1)
            {
                int i = textBlock_1.Text.Length;
                int j = textBlock.Text.Length;
                msg = textBlock.Text;
                str = textBlock_1.Text;
                msg = msg.Remove(j - 1, 1);
                str = str.Remove(i - 1, 1);
                textBlock_1.Text = str;
                textBlock.Text = msg;
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (str == "0")
                str = "9";
            else
                str += "9";
            if (msg == "0")
                msg = "9";
            else
                msg += "9";
            textBlock_1.Text = str;
            textBlock.Text = msg;
        }

        public MainWindow()
        {
            InitializeComponent();
            str = "0";
            msg = "0";
            simb = "";
            textBlock_1.Text = str;
            textBlock.Text = msg;
            List<string> styles = new List<string> { "light", "dark" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "light";
        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
    }
}
