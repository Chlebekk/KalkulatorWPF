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
                OBW.Text =""+result*4;
                POL.Text= ""+result*result;
            }
            else
            {
                kom.Text="Wpisz poprawną wartość";
            }
        }

        private void bokTXT_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(bokTXT.Text, out double result))
            {
                KWA.Height = result;
                KWA.Width = result;
            }
        }
    }
}
