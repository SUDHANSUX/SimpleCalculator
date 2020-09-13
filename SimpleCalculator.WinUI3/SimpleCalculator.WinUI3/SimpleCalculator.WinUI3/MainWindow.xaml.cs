using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SimpleCalculator.WinUI3
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        
        private decimal FirstNo;
        private decimal SecondNo;
        private decimal Result;

        public MainWindow()
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
            if( Decimal.TryParse(TxtFirstNo.Text, out FirstNo) && Decimal.TryParse(TxtSecondNo.Text, out SecondNo))
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
