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

namespace Lab06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double firstNum { get; private set; }
        public int pos { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            if (this.txtNumberDisplay.Text.Length == 1)
                this.txtNumberDisplay.Text = "0";
            else
                this.txtNumberDisplay.Text = txtNumberDisplay.Text.Remove(this.txtNumberDisplay.Text.Length - 1, 1);
        }

        private void ButtonNumber_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            SetNumberDisplay(btn.Content.ToString());
        }

        private void SetNumberDisplay(string textNumber)
        {
            if (this.txtNumberDisplay.Text == "0" || this.txtNumberDisplay.Text == "+")
            {
                this.txtNumberDisplay.Text = textNumber;
            }
            else
                this.txtNumberDisplay.Text += textNumber;
        }

        private void ButtonClearAll_Click(object sender, RoutedEventArgs e)
        {
            txtNumberDisplay.Text = "0";
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            this.firstNum = double.Parse(txtNumberDisplay.Text);
            this.pos = txtNumberDisplay.Text.Length;
            txtNumberDisplay.Text += "+";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            this.firstNum = double.Parse(txtNumberDisplay.Text);
            this.pos = txtNumberDisplay.Text.Length;
            txtNumberDisplay.Text += "-";
        }

        private void ButtonTimes_Click(object sender, RoutedEventArgs e)
        {
            this.firstNum = double.Parse(txtNumberDisplay.Text);
            this.pos = txtNumberDisplay.Text.Length;
            txtNumberDisplay.Text += "*";
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            
            this.firstNum = double.Parse(txtNumberDisplay.Text);
            this.pos = txtNumberDisplay.Text.Length;
            txtNumberDisplay.Text += "/";
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            var sn = "";
            for (var i = pos + 1; i < txtNumberDisplay.Text.Length; i++)
            {
                sn += txtNumberDisplay.Text[i];
            }
            var secondNum = double.Parse(sn);
            if (txtNumberDisplay.Text.Contains("+"))
            {
                txtNumberDisplay.Text = (this.firstNum + secondNum).ToString();
            }
            else if (txtNumberDisplay.Text.Contains("-"))
            {
                txtNumberDisplay.Text = (this.firstNum - secondNum).ToString();
            }
            else if (txtNumberDisplay.Text.Contains("*"))
            {
                txtNumberDisplay.Text = (this.firstNum * secondNum).ToString();
            }
            else
            {
                txtNumberDisplay.Text = (this.firstNum / secondNum).ToString();
            }
            this.firstNum = 0;
        }
    }
}
