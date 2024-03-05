using System;
using System.Windows;
using System.Data;

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string error = "ошибка";
        public MainWindow()
        {
            InitializeComponent();          
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0" || textFields.Text == error)
                textFields.Text = "0";
            else
                textFields.Text = textFields.Text + "0";
        }

        private void comma_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == error)
                textFields.Text = "0";
            else
                textFields.Text = textFields.Text + ".";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            if(textFields.Text == "0" || textFields.Text == error)
                textFields.Text = "1";
            else
                textFields.Text = textFields.Text + "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0" || textFields.Text == error)
                textFields.Text = "2";
            else
                textFields.Text = textFields.Text + "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0" || textFields.Text == error)
                textFields.Text = "3";
            else
                textFields.Text = textFields.Text + "3";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == error)
                textFields.Text = "0";
            else
                textFields.Text = textFields.Text + "+";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0" || textFields.Text == error)
                textFields.Text = "4";
            else
                textFields.Text = textFields.Text + "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0" || textFields.Text == error)
                textFields.Text = "5";
            else
                textFields.Text = textFields.Text + "5";
        }

        private void sex_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0" || textFields.Text == error)
                textFields.Text = "6";
            else
                textFields.Text = textFields.Text + "6";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == error)
                textFields.Text = "0";
            else
                textFields.Text = textFields.Text + "-";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0" || textFields.Text == error)
                textFields.Text = "7";
            else
                textFields.Text = textFields.Text + "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0" || textFields.Text == error)
                textFields.Text = "8";
            else
                textFields.Text = textFields.Text + "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == "0" || textFields.Text == error)
                textFields.Text = "9";
            else
                textFields.Text = textFields.Text + "9";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == error)
                textFields.Text = "0";
            else
                textFields.Text = textFields.Text + "*";
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == error)
                textFields.Text = "0";
            else
                textFields.Text = textFields.Text + "/";
        }

        private void clearDigit_Click(object sender, RoutedEventArgs e)
        {
            if (textFields.Text == error)
                textFields.Text = "0";
            else
            {
                textFields.Text = textFields.Text.Remove(textFields.Text.Length - 1);
                if (textFields.Text.Length == 0)
                    textFields.Text = "0";
            }
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
                string str = new DataTable().Compute(textFields.Text, null).ToString();
                if (str != "∞")
                    textFields.Text = str;
                else
                    throw new Exception();
                //Result rs = new Result(textFields.Text);
                //textFields.Text = rs.outStr;
                

            }
            catch (Exception)
            {
                textFields.Text = error;
            }
        }
    }
}
