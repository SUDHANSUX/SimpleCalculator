using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SimpleCalculator.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private decimal FirstNo;
        private decimal SecondNo;
        private decimal Result;

        public MainPage()
        {
            this.InitializeComponent();

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
