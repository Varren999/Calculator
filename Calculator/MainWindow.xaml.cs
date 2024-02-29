using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();          
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0")
                textFields.Text = "0";
            else
                textFields.Text = textFields.Text + "0";
        }

        private void comma_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + ".";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if(textFields.Text == "0")
                textFields.Text = "1";
            else
                textFields.Text = textFields.Text + "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0")
                textFields.Text = "2";
            else
                textFields.Text = textFields.Text + "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0")
                textFields.Text = "3";
            else
                textFields.Text = textFields.Text + "3";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
             textFields.Text = textFields.Text + "+";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0")
                textFields.Text = "4";
            else
                textFields.Text = textFields.Text + "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0")
                textFields.Text = "5";
            else
                textFields.Text = textFields.Text + "5";
        }

        private void sex_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0")
                textFields.Text = "6";
            else
                textFields.Text = textFields.Text + "6";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {         
            textFields.Text = textFields.Text + "-";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0")
                textFields.Text = "7";
            else
                textFields.Text = textFields.Text + "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0")
                textFields.Text = "8";
            else
                textFields.Text = textFields.Text + "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0")
                textFields.Text = "9";
            else
                textFields.Text = textFields.Text + "9";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + "*";
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + "/";
        }

        private void clearDigit_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text.Remove(textFields.Text.Length - 1);
            if (textFields.Text.Length == 0)              
                textFields.Text = "0";
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = "0";
            Label.Text = "";
        }

        private void clearFields_Click(object sender, RoutedEventArgs e)
        {
            Label.Text = textFields.Text;
            textFields.Text = "0";
        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Label.Text = textFields.Text;
                textFields.Text = new DataTable().Compute(textFields.Text, null).ToString();
                //Result rs = new Result(textFields.Text);
                //textFields.Text = rs.outStr;
            }
            catch(Exception)
            {
                textFields.Text = "ошибка";
            }
        }
    }
}
