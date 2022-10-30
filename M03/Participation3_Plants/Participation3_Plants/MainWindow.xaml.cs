using System;
using System.Collections.Generic;
using System.IO.Packaging;
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

namespace Participation3_Plants
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    Dictionary<string, Plant> allPlantsDict = new Dictionary<string, Plant>();

    public MainWindow()
    {
      InitializeComponent();
      LoadValues();
    }

    /// <summary>
    /// Loads the combo boxes with the values to select
    /// </summary>
    private void LoadValues()
    {
      cbEnvironment.Items.Add("Desert"); //Adds Desert to the environment
      cbEnvironment.Items.Add("Forest"); //Adds Forest to the environment
      cbEnvironment.Items.Add("Tropical"); //Adds Tropical to the environment

      cbType.Items.Add("Flower"); //Adds flower to the Type
      cbType.Items.Add("Shrub"); //Adds Shrub to the Type
      cbType.Items.Add("Tree"); //Adds Tree to the type
    }

    /// <summary>
    /// Validates the entries to make sure that they have all three parameters given
    /// </summary>
    /// <returns></returns>
    private bool ValidateEntries()
    {

      string errorMessage = ""; //Sets the error message to an empty string
      if (TxtBoxName.Text == "") errorMessage += "Please enter a plant name."; //If the text box is empty, add the error message text
      if (cbEnvironment.SelectedIndex == -1) errorMessage += "\nPlease select an environment."; //If the Environment combo box is empty, add the error message text
      if (cbType.SelectedIndex == -1) errorMessage += "\nPlease select a plant type."; //If the Type combo box is empty, add the error message text

      if (errorMessage != "") //If there's an error message from before, display it
      {
        MessageBox.Show(errorMessage, "Invalid Input"); //Displays the error message
        return false; //Returns false so we don't add the plant
      }
      return true; //Returns true since the entries are valid (no error messages)
    }

    /// <summary>
    /// Adds the plant to the dictionary and the listbox when we click the button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnAddPlant_Click(object sender, RoutedEventArgs e)
    {
      if (ValidateEntries()) //Calls the ValidateEntries method to check and see if they're valid
      {
        Plant plant = null; //Set the new plant to null for now

        switch (cbType.SelectedItem.ToString()) //Switch case based on the Type Combo Box
        {
          case "Flower": //If flower
            plant = new Flower(TxtBoxName.Text, cbEnvironment.SelectedItem.ToString(), cbType.SelectedItem.ToString()); //Add a flower child class instance to plant
            break; //Exits the switch case
          case "Tree": //If tree
            plant = new Tree(TxtBoxName.Text, cbEnvironment.SelectedItem.ToString(), cbType.SelectedItem.ToString()); //Add a Tree child class instance to plant
            break; //Exits the switch case
          case "Shrub": //If Shrub
            plant = new Shrub(TxtBoxName.Text, cbEnvironment.SelectedItem.ToString(), cbType.SelectedItem.ToString()); //Add a Shrub child class instance to plant
            break; //Exits the switch case

          default: //If it doesn't make the top ones, list the error
            MessageBox.Show("This is an error"); //Display error
            break; //Exits the switch case
        }

        if (plant != null) //If the plant has something in it, add it to the dictionary and the listbox
        {
          allPlantsDict.Add(plant.Name, plant); //Adds it to the dictionary
          LstBoxPlant.Items.Add(plant.Name); //Adds it to the listbox

          TxtBoxName.Text = ""; //Resets the Name Text box
          cbEnvironment.SelectedIndex = -1; //Resets the Environment combo box
          cbType.SelectedIndex = -1; //Resets the Type combo box
        }

      }
    }

    /// <summary>
    /// Shows the Details window when we click on the button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnShowDetails_Click(object sender, RoutedEventArgs e)
    {
      if (LstBoxPlant.SelectedIndex > -1) //If there's a plant selected in the listbox
      {
        if (allPlantsDict.TryGetValue(LstBoxPlant.SelectedItem.ToString(), out Plant slPlant)) //If we're able to get that selected plant from the dictionary
        {
          DetailsWindow pdw = new DetailsWindow(); //Create the DetailsWindow in memory
          pdw.LblNameResults.Content = slPlant.Name; //Changes the labels of the window to match the selected plant
          pdw.LblTypeResults.Content = slPlant.Type; //Changes the labels of the window to match the selected plant
          pdw.LblEnvResults.Content = slPlant.Environment; //Changes the labels of the window to match the selected plant
          pdw.LblPriceResults.Content = slPlant.Price(); //Changes the labels of the window to match the selected plant
          pdw.SelectedPlant = slPlant; //Puts the selected plant into the SelectedPlant variable in the Details Window back end code

          pdw.Show(); //Shows the new details window modeless
        }
        else //If it couldn't find it in the database
        {
          MessageBox.Show("Couldn't find that plant in the database."); //Display the error message
        }
      }
    }

    /// <summary>
    /// Changes the image when they select a new combo box entry
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void cbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      if (cbType.SelectedIndex > -1) //If there's something selected
      {
        switch (cbType.SelectedItem.ToString()) //Switch case for which one is selected to change to the correct image
        {
          case "Flower": //If flower
            ImgType.Source = new BitmapImage(new Uri("/Images/rose.png", UriKind.Relative)); //change it to the Flower picture
            break;
          case "Tree": //If tree
            ImgType.Source = new BitmapImage(new Uri("/Images/tree.jpg", UriKind.Relative)); //change it to the Tree picture
            break;
          case "Shrub": //If shrub
            ImgType.Source = new BitmapImage(new Uri("/Images/shrub.png", UriKind.Relative)); //change it to the Shrub picture
            break;

          default: //If it's not any of the cases
            MessageBox.Show("An unexpected error has occurred"); //display the error message
            break;
        }
      }
      else //There's nothing selected
      {
        ImgType.Source = new BitmapImage(new Uri("/Images/blank.jpg", UriKind.Relative)); //Set the image to a blank one
      }
    }

/// <summary>
/// Changes the image when they select a new combo box entry
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
    private void cbEnvironment_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

      if (cbEnvironment.SelectedIndex > -1)  //If there's something selected
      {
        switch (cbEnvironment.SelectedItem.ToString()) //switch case for which one is selected to change to the correct image
        {
          case "Forest": //If forest
            ImgEnvironment.Source = new BitmapImage(new Uri("/Images/forest.png", UriKind.Relative)); //change it to the Forest picture
            break;
          case "Tropical": //If tropical
            ImgEnvironment.Source = new BitmapImage(new Uri("/Images/tropical.jpg", UriKind.Relative)); //change it to the Tropical picture
            break;
          case "Desert": //If desert
            ImgEnvironment.Source = new BitmapImage(new Uri("/Images/desert.png", UriKind.Relative)); //change it to the Desert picture
            break;

          default: //If it's not any of the cases
            MessageBox.Show("An unexpected error has occurred"); //display the error message
            break;
        }
      }
      else //There's nothing selected
      {
        ImgEnvironment.Source = new BitmapImage(new Uri("/Images/blank.jpg", UriKind.Relative)); //Set the image to a blank one
      }  
    }



    /// <summary>
    /// Extra code where it will change the images based on the selected plant in the listbox
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void LstBoxPlant_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      string slLst = LstBoxPlant.SelectedItem.ToString(); //Creates a variabel slLst that's the selected item in the listbox as a string
      
      allPlantsDict.TryGetValue(slLst, out Plant slPlant); //Gets the values from the dictionary from what's selected

      ///
      ///Switch case to see which Image to change it to for both of the images, based on what's stored in the dictionary for .Environment and .Type
      ///      

      switch (slPlant.Environment)
      {
        case "Forest": //If forest
          ImgEnvironment.Source = new BitmapImage(new Uri("/Images/forest.png", UriKind.Relative)); //change it to the Forest picture
          break;
        case "Tropical": //If tropical
          ImgEnvironment.Source = new BitmapImage(new Uri("/Images/tropical.jpg", UriKind.Relative)); //change it to the Tropical picture
          break;
        case "Desert": //If desert
          ImgEnvironment.Source = new BitmapImage(new Uri("/Images/desert.png", UriKind.Relative)); //change it to the Desert picture
          break;
      }

      switch (slPlant.Type)
      {
        case "Flower": //If flower
          ImgType.Source = new BitmapImage(new Uri("/Images/rose.png", UriKind.Relative)); //change it to the Flower picture
          break;
        case "Tree": //If tree
          ImgType.Source = new BitmapImage(new Uri("/Images/tree.jpg", UriKind.Relative)); //change it to the Tree picture
          break;
        case "Shrub": //If shrub
          ImgType.Source = new BitmapImage(new Uri("/Images/shrub.png", UriKind.Relative)); //change it to the Shrub picture
          break;

        default: //If it's not any of the cases
          break; //Break the switch case and do nothing
      }
    }
  }
}

