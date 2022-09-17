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

namespace Assignment2_Nutrition
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, Food> foodDict = new Dictionary<string, Food>();
        
        /// <summary>
        /// Initializes the GUI and calls the LoadFood method
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            LoadFood();
        }

        /// <summary>
        /// Takes the txt file and puts it into the directory and combobox
        /// </summary>
        private void LoadFood()
        {
            StreamReader inputfile; //Calls the StreamReader Class so we can read the text file
            try //Tries to read the file and siplays error message if it can't
            {
                inputfile = File.OpenText("nutrition.txt"); //Opens the text file nutrition and puts it into the StreamReader (inputfile) so we can read it

                string line = inputfile.ReadLine(); //Reads the first line of the text file since it only includes headers
                while (!inputfile.EndOfStream) //While we're not at the end of the text file
                {
                    string[] tempfood = inputfile.ReadLine().Split('\t'); //Takes the current line, splits it by tabs, and puts each item into the tempfood array
                    foodDict.Add(tempfood[0], new Food(tempfood)); //Adds each line to the dictionary using the first array item (Food) as the key
                    cbFoods.Items.Add(tempfood[0]); //Adds each Food to the ComboBox
                }
                inputfile.Close(); //Closes the text file from being read
            }
            catch (Exception ex) //If there's an error reading the file
            {
                MessageBox.Show(ex.Message); //Display the error message from reading the file
            }

        }

        /// <summary>
        /// When the selection of the combobox changes, we'll show the Food details of the selected Food
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Foods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DetailWindow fdw = new DetailWindow(); //Creates a new instance of the DetailWindow called fdw in memory

            if (cbFoods.SelectedIndex == -1) //If the selected Food is empty
            {
                MessageBox.Show("Please select a food item first"); //Show the error message (most likely won't happen with the SelectionChanged event
            }
            else //If the selected Food isn't empty
            {
                if (foodDict.TryGetValue(cbFoods.SelectedItem.ToString(), out Food selectedFood)) //Tries to get the Food key's associated values from the dictionary and outputs an array called selectedFood
                {
                    fdw.UpdateGUI(selectedFood); //Updates the DetailWindow Gui using the UpdateGUI method in the DetailWindow.xaml.cs

                    fdw.ShowDialog(); //Shows the new Food Details window as modal
                }
                else //If the Food wasn't found in the Dictionary (highly unlikely)
                {
                    MessageBox.Show($"Couldn't find {cbFoods.SelectedItem} in the database)"); //Displays the error message
                }


            }



        }
    }
}
