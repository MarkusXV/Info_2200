using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace KeyPad
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int counter = 0;
        public MainWindow()
        {
            InitializeComponent();
            LblNumber.Content = "";
            
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (counter < 10)
            {
                LblNumber.Content += button.Content.ToString();
                counter++;
            }
            else
            {
                LblNumber.Content = "";
                LblNumber.Content += button.Content.ToString();
                counter = 0;
            }
                
        }
    }
}
