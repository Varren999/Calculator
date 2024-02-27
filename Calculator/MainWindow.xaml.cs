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
            textFields.Text = textFields.Text + "0";
        }

        private void comma_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + ",";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + " 1 ";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + " 2 ";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + " 3 ";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + " + ";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + " 4 ";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + " 5 ";
        }

        private void sex_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + " 6 ";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + " - ";
        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + " 7 ";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + " 8 ";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + " 9 ";
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + " * ";
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text + " / ";
        }

        private void clearDigit_Click(object sender, RoutedEventArgs e)
        {
            textFields.Text = textFields.Text.Remove(textFields.Text.Length - 1);
        }

        private void reset_Click(object sender, RoutedEventArgs e)
        {

        }

        private void clearFields_Click(object sender, RoutedEventArgs e)
        {

        }

        private void equals_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
