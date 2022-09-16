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

        /// <summary>
        /// Initializes the GUI and calls the LoadPhones method
        /// </summary>
        public MainWindow()
        {
            InitializeComponent(); //Create the GUI
            LoadPhones(); //Calls the LoadPhones method
        }

        /// <summary>
        /// Takes the text file and puts it in the dictionary
        /// </summary>
        private void LoadPhones()
        {
            StreamReader inputfile; //Calls the StreamReader Class from System.io so we can read the text
            try //Tries to read the file and displays error message if it can't
            {
                inputfile = File.OpenText("phones.txt"); //Opens the text file phones and puts it into the StreamReader (inputfile) so we can read it

                while (!inputfile.EndOfStream) //For every line of text until there's no text left
                {
                    string[] tempphone = inputfile.ReadLine().Split(','); //Reads each line of text and splits it by the comma. Then adds each seperated item into a tempphone array.
                    phoneDict.Add(tempphone[1], new Phone(tempphone)); //Adds each item with the Model (tempphone[1]) as the key, and the array as the values (set to Make, Model, etc) to the dictionary
                    CbPhones.Items.Add(tempphone[1]); //Adds the model to the combobox

                }
                inputfile.Close(); //Closes the text file
            }
            catch (Exception ex) //If it can't read the text
            {
                MessageBox.Show(ex.Message); //Displays the error message in a MessageBox
            }
        }

        /// <summary>
        /// Button to show the Details window
        /// </summary>
        private void BtnShowPhoneDetails_Click(object sender, RoutedEventArgs e) //When the Show details button is clicked
        {
            PhoneDetails pdw = new PhoneDetails(); //Puts the new PhoneDetails window into memory

            if (CbPhones.SelectedIndex == -1) //No phone is Selected in combo box
            {
                MessageBox.Show("Please select a phone first"); //Display error message
            }
            else //A phone is selected in combo box
            {
                if (phoneDict.TryGetValue(CbPhones.SelectedItem.ToString(), out Phone selectedPhone)) //Tries to get the value from the dictionary from the combo box entry and puts it into the selectedPhone array
                {
                    pdw.UpdateGUI(selectedPhone); //Updates the GUI with the selected phone details just gathered

                    pdw.Show(); //Displays the window
                }
                else
                {
                    MessageBox.Show($"Couldn't find {CbPhones.SelectedItem} in the database"); //Displays an error if it couldn't find the selected phone in the dictionary (almost impossible)
                }
            }
        }
    }
}
