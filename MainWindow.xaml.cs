using System;
using System.Collections.Generic;
using System.Drawing;
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
using Color = System.Windows.Media.Color;

namespace WpfAppForms
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
            if (double.TryParse(bokTXT.Text, out double result))
            {
                OBW.Text = "" + result * 4;
                POL.Text = "" + result * result;
            }
            else
            {
                kom.Text = "Wpisz poprawną wartość";
            }
        }

        private void bokTXT_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(bokTXT.Text, out double result) && result <= 200)
            {
                SolidColorBrush color = (SolidColorBrush)
                    new BrushConverter().ConvertFromString(kCMB.Text);
                KWA.Fill = color;
                KWA.Height = result;
                KWA.Width = result;
            }
                
        }

        private void CBX_Checked(object sender, RoutedEventArgs e)
        { 
              KWA.Opacity = 0.5;
        }
        private void CBX_Unchecked(object sender, RoutedEventArgs e)
        {
            KWA.Opacity = 1;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            sillyCar.Visibility = Visibility.Visible;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            sillyCar.Visibility = Visibility.Hidden;
        }
    }
}
