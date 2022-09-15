using System;
using System.Collections.Generic;
using System.IO;
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

namespace M02Part2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, Phone> phoneDict = new Dictionary<string, Phone>();

        public MainWindow()
        {
            InitializeComponent();
            LoadPhones();
        }

        private void LoadPhones()
        {
            StreamReader inputfile;
            try
            {
                inputfile = File.OpenText("phones.txt");

                while (!inputfile.EndOfStream)
                {
                    string[] tempphone = inputfile.ReadLine().Split(',');
                    phoneDict.Add(tempphone[1], new Phone(tempphone));
                    CbPhones.Items.Add(tempphone[1]);

                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Button to show the Details window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowPhoneDetails_Click(object sender, RoutedEventArgs e)
        {
            PhoneDetails pdw = new PhoneDetails();

            if (CbPhones.SelectedIndex == -1) //Nothing Selected
            {
                MessageBox.Show("Please select a phone first");
            }
            else //A phone is selected
            {
                if (phoneDict.TryGetValue(CbPhones.SelectedItem.ToString(), out Phone selectedPhone))
                {
                    pdw.UpdateGUI(selectedPhone);

                    pdw.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Couldn't find {CbPhones.SelectedItem} in the database");
                }
            }
        }
    }
}
