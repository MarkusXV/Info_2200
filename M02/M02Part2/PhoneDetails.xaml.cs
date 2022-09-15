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
using System.Windows.Shapes;

namespace M02Part2
{
    /// <summary>
    /// Interaction logic for PhoneDetails.xaml
    /// </summary>
    public partial class PhoneDetails : Window
    {
        public PhoneDetails()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        public void UpdateGUI(Phone selectedPhone)
        {
            LblMake.Content = selectedPhone.Make;
            LblModel.Content = selectedPhone.Model;
            LblDisplay.Content = selectedPhone.Display;
            LblStorage.Content = selectedPhone.Storage;
            LblPrice.Content = selectedPhone.Price;
        }

    }
}
