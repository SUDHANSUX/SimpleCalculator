using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimpleCalculator.WPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        private decimal FirstNo;
        private decimal SecondNo;
        private decimal Result;
        
        public Window1()
        {
            InitializeComponent();

            BtnClear.Click += BtnClear_Click;
            BtnAdd.Click += BtnAdd_Click;
            BtnSub.Click += BtnSub_Click;
            BtnMul.Click += BtnMul_Click;
            BtnDiv.Click += BtnDiv_Click; 
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            TxtFirstNo.Text = "";
            TxtSecondNo.Text = "";
            TxtResult.Text = "";
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (Decimal.TryParse(TxtFirstNo.Text, out FirstNo) && Decimal.TryParse(TxtSecondNo.Text, out SecondNo))
            {
                Result = FirstNo + SecondNo;
                TxtResult.Text = Result.ToString();
            }
            else
            {
                TxtResult.Text = "Error: Invalid Input.";
            }
        }

        private void BtnSub_Click(object sender, RoutedEventArgs e)
        {
            if (Decimal.TryParse(TxtFirstNo.Text, out FirstNo) && Decimal.TryParse(TxtSecondNo.Text, out SecondNo))
            {
                Result = FirstNo - SecondNo;
                TxtResult.Text = Result.ToString();
            }
            else
            {
                TxtResult.Text = "Error: Invalid Input.";
            }
        }

        private void BtnMul_Click(object sender, RoutedEventArgs e)
        {
            if (Decimal.TryParse(TxtFirstNo.Text, out FirstNo) && Decimal.TryParse(TxtSecondNo.Text, out SecondNo))
            {
                Result = FirstNo * SecondNo;
                TxtResult.Text = Result.ToString();
            }
            else
            {
                TxtResult.Text = "Error: Invalid Input.";
            }
        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (Decimal.TryParse(TxtFirstNo.Text, out FirstNo) && Decimal.TryParse(TxtSecondNo.Text, out SecondNo))
            {
                if (SecondNo == 0)
                {
                    TxtResult.Text = "Error: Divide By Zero.";
                }
                else
                {
                    Result = FirstNo / SecondNo;
                    TxtResult.Text = Result.ToString();
                }
            }
            else
            {
                TxtResult.Text = "Error: Invalid Input.";
            }
        }
    }
}
