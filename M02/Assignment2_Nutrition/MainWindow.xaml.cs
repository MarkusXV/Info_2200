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
        
        public MainWindow()
        {
            InitializeComponent();
            LoadFood();
        }

        private void LoadFood()
        {
            StreamReader inputfile;
            try
            {
                inputfile = File.OpenText("nutrition.txt");

                string line = inputfile.ReadLine();
                while (!inputfile.EndOfStream)
                {
                    string[] tempfood = inputfile.ReadLine().Split('\t');
                    foodDict.Add(tempfood[0], new Food(tempfood));
                    cbFoods.Items.Add(tempfood[0]);
                }
                inputfile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Foods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DetailWindow fdw = new DetailWindow();

            if (cbFoods.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a food item first");
            }
            else
            {
                if (foodDict.TryGetValue(cbFoods.SelectedItem.ToString(), out Food selectedFood))
                {
                    fdw.UpdateGUI(selectedFood);

                    fdw.ShowDialog();
                }
                else
                {
                    MessageBox.Show($"Couldn't find {cbFoods.SelectedItem} in the database)");
                }


            }



        }
    }
}
