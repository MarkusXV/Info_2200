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
        public PhoneDetails() //Creates the GUI
        {
            InitializeComponent(); //Initializes the Components of the GUI so that we can show it in the MainWindow backend code
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e) //When the close button is clicked on the Phone Details window
        {
            Close(); //Closes the window
        }

        public void UpdateGUI(Phone selectedPhone) //Updates the Window's phone details when they change the phone in the combo box
        {
            LblMake.Content = selectedPhone.Make;
            LblModel.Content = selectedPhone.Model;
            LblDisplay.Content = selectedPhone.Display;
            LblStorage.Content = selectedPhone.Storage;
            LblPrice.Content = selectedPhone.Price;
        }

    }
}
