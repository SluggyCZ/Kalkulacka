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

namespace Kalkulacka
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = ResultTextBlock.Text + "0";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = ResultTextBlock.Text + "1";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = ResultTextBlock.Text + "2";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = ResultTextBlock.Text + "3";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = ResultTextBlock.Text + "4";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = ResultTextBlock.Text + "5";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = ResultTextBlock.Text + "6";
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = ResultTextBlock.Text + "7";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = ResultTextBlock.Text + "8";
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = ResultTextBlock.Text + "9";
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = "";
        }

        private void Button_Click_CE(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = "";
        }
        
        private void Button_Click_clear(object sender, RoutedEventArgs e)
        {
            string hodnota = ResultTextBlock.Text;
            
            
            if (!string.IsNullOrEmpty(hodnota));
            {
                double cislo = double.Parse(ResultTextBlock.Text);
                hodnota = hodnota.Remove(hodnota.Length - 1);
            }
            ResultTextBlock.Text = hodnota;
        }
        
        private void Button_Click_carka(object sender, RoutedEventArgs e)
        {
            string hodnota = ResultTextBlock.Text;
            Boolean Found = false;
                for (int i = 0; i < hodnota.Length; i++)
                {
                    if (hodnota[i] == ',')
                    {
                        Found = true;
                    }
                }
                if (!Found)
                {
                    ResultTextBlock.Text += ",";
                }       
        }
        private void Button_Click_zapor(object sender, RoutedEventArgs e)
        {
            string hodnota = ResultTextBlock.Text;
            double cislo = double.Parse(ResultTextBlock.Text);

            ResultTextBlock.Text = (cislo * (-1)).ToString();    
        }
        private void Button_Click_nadruhou(object sender, RoutedEventArgs e)
        {
            double cislo = double.Parse(ResultTextBlock.Text);
            ResultTextBlock.Text = (cislo*cislo).ToString();
        }

        private void Button_Click_zlomek(object sender, RoutedEventArgs e)
        {
            string hodnota = ResultTextBlock.Text;
            double cislo = double.Parse(ResultTextBlock.Text);
            ResultTextBlock.Text = (1 / cislo).ToString();
        }


    }
}
