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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Assignment3_Animals
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public Animal animal;
    public MainWindow() 
    {
      InitializeComponent(); //inilializes the components of the GUI


    }

    /// <summary>
    /// Radio Button Methods that are called when the selection changes for Manticore
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void RBtnManticore_Checked(object sender, RoutedEventArgs e)
    {
      animal = new Manticore("Rough", "Meaty things"); //Initiates the child class based on the animal class
      ImgAnimal.Source = new BitmapImage(new Uri("/Images/Manticore.jpg", UriKind.Relative)); //Sets the image based on the new child class

      LblAttributes.Content = "(Attribute)"; //Sets the labels back to the default
      LblActions.Content = "(Action)"; //Sets the labels back to the default
      LblUnique.Content = "(Unique)"; //Sets the labels back to the default
    }

    /// <summary>
    /// Radio Button Methods that are called when the selection changes for Dragon
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RBtnDragon_Checked(object sender, RoutedEventArgs e)
    {
      animal = new Dragon("Scaly", "Humans"); //Initiates the child class based on the animal class
      ImgAnimal.Source = new BitmapImage(new Uri("/Images/Dragon.jpg", UriKind.Relative)); //Sets the image based on the new child class

      LblAttributes.Content = "(Attribute)"; //Sets the labels back to the default
      LblActions.Content = "(Action)"; //Sets the labels back to the default
      LblUnique.Content = "(Unique)"; //Sets the labels back to the default
    }

    /// <summary>
    /// Radio Button Methods that are called when the selection changes for Griffin
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RBtnGriffin_Checked(object sender, RoutedEventArgs e)
    {
      animal = new Griffin("Fluffy", "All sorts of stuff"); //Initiates the child class based on the animal class
      ImgAnimal.Source = new BitmapImage(new Uri("/Images/Griffin.jpg", UriKind.Relative));  //Sets the image based on the new child class

      LblAttributes.Content = "(Attribute)"; //Sets the labels back to the default
      LblActions.Content = "(Action)"; //Sets the labels back to the default
      LblUnique.Content = "(Unique)"; //Sets the labels back to the default
    }

    //Button Methods

    /// <summary>
    /// Checks to see if there is a radio button selected and sends an error message if there isn't one
    /// </summary>
    /// <returns></returns>
    public bool CheckRadioStatus()
    {
      if (RBtnManticore.IsChecked == false && RBtnDragon.IsChecked == false && RBtnGriffin.IsChecked == false) //If none are selected
      {
        MessageBox.Show("Select an Animal First"); //Displays the error message and returns false
        return false;
      }
      else //if there's one selected
      {
        return true; //returns true
      }
    }

    /// <summary>
    /// When the unique button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnUnique_Click(object sender, RoutedEventArgs e)
    {
      bool status = CheckRadioStatus(); //calls the CheckRadiostatus method and puts it into the status variable
      if (status == true) //If there's a radio button selected
      {
        LblUnique.Content = animal.Unique(); //calls the unique method from the child class and sets the label on the GUI
      }

    }

    /// <summary>
    /// When the skin type button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnSkinType_Click(object sender, RoutedEventArgs e)
    {
      bool status = CheckRadioStatus(); //calls the CheckRadiostatus method and puts it into the status variable
      if (status == true) //If there's a radio button selected
      {
        
        LblAttributes.Content = "Skin type: " + animal.SkinType; //calls the unique method from the child class and sets the label on the GUI
      }

    }

    /// <summary>
    /// When the Food type button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnFoodType_Click(object sender, RoutedEventArgs e)
    {
      bool status = CheckRadioStatus(); //calls the CheckRadiostatus method and puts it into the status variable
      if (status == true) //If there's a radio button selected
      {
        LblAttributes.Content = "Food type: " + animal.FoodType; //calls the unique method from the child class and sets the label on the GUI
      }
    }

    /// <summary>
    /// When the Eat button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnEat_Click(object sender, RoutedEventArgs e)
    {
      bool status = CheckRadioStatus(); //calls the CheckRadiostatus method and puts it into the status variable
      if (status == true) //If there's a radio button selected
      {
        LblActions.Content = "Eat: " + animal.Eat(); //calls the unique method from the child class and sets the label on the GUI
      }
    }

    /// <summary>
    /// When the move button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnMove_Click(object sender, RoutedEventArgs e)
    {
      bool status = CheckRadioStatus(); //calls the CheckRadiostatus method and puts it into the status variable
      if (status == true) //If there's a radio button selected
      {
        LblActions.Content = "Move: " + animal.Move(); //calls the unique method from the child class and sets the label on the GUI
      }
    }

    /// <summary>
    /// When the reproduce button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnReproduce_Click(object sender, RoutedEventArgs e)
    {
      bool status = CheckRadioStatus(); //calls the CheckRadiostatus method and puts it into the status variable
      if (status == true) //If there's a radio button selected
      {
        LblActions.Content = "Reproduce: " + animal.Reproduce(); //calls the unique method from the child class and sets the label on the GUI
      }

    }
  }
}
