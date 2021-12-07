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

namespace Calculator_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double resultValue = 0;
        string operatorPerformed = "";
        bool isOperationPerformed = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberClickEvent(object sender, RoutedEventArgs e)
        {
            if (textBox.Text == "0" || isOperationPerformed)
                textBox.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Content.Equals("."))
            {
                if(!textBox.Text.Contains("."))
                    textBox.Text = textBox.Text + button.Content;
            }
            else
            {
                textBox.Text = textBox.Text + button.Content;
            }
            
        }

        private void OperatorClickEvent(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                resultButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
                operatorPerformed = (string)button.Content;
                labelPerformed.Content = textBox.Text + " " + operatorPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operatorPerformed = (string)button.Content;
                labelPerformed.Content = textBox.Text + " " + operatorPerformed;
                resultValue = double.Parse(textBox.Text);
                isOperationPerformed = true;
            }
            
        }

        private void ClearScreen(object sender, RoutedEventArgs e)
        {
            textBox.Text = "0";
        }

        private void ClearAll(object sender, RoutedEventArgs e)
        {
            textBox.Text = "0";
            resultValue = 0;
            labelPerformed.Content = "";
        }

        private void ResultClickEvent(object sender, RoutedEventArgs e)
        {
            switch (operatorPerformed)
            {
                case "+":
                    textBox.Text = (resultValue + double.Parse(textBox.Text)).ToString();
                    break;
                case "-":
                    textBox.Text = (resultValue - double.Parse(textBox.Text)).ToString();
                    break;
                case "*":
                    textBox.Text = (resultValue * double.Parse(textBox.Text)).ToString();
                    break;
                case "/":
                    textBox.Text = (resultValue / double.Parse(textBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(textBox.Text);
            labelPerformed.Content = "";
        }
    }
}


