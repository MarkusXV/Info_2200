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

    private void LoadValues()
    {
      cbEnvironment.Items.Add("Desert");
      cbEnvironment.Items.Add("Forest");
      cbEnvironment.Items.Add("Tropical");

      cbType.Items.Add("Flower");
      cbType.Items.Add("Shrub");
      cbType.Items.Add("Tree");
    }

    private bool ValidateEntries()
    {

      string errorMessage = "";
      if (TxtBoxName.Text == "") errorMessage += "Please enter a plant name.";
      if (cbEnvironment.SelectedIndex == -1) errorMessage += "\nPlease select an environment.";
      if (cbType.SelectedIndex == -1) errorMessage += "\nPlease select a plant type.";

      if (errorMessage != "")
      {
        MessageBox.Show(errorMessage, "Invalid Input");
        return false;
      }
      return true;
    }

    private void BtnAddPlant_Click(object sender, RoutedEventArgs e)
    {
      if (ValidateEntries())
      {
        Plant plant = null;

        switch (cbType.SelectedItem.ToString())
        {
          case "Flower":
            plant = new Flower(TxtBoxName.Text, cbEnvironment.SelectedItem.ToString(), cbType.SelectedItem.ToString());
            break;
          case "Tree":
            plant = new Tree(TxtBoxName.Text, cbEnvironment.SelectedItem.ToString(), cbType.SelectedItem.ToString());
            break;
          case "Shrub":
            plant = new Shrub(TxtBoxName.Text, cbEnvironment.SelectedItem.ToString(), cbType.SelectedItem.ToString());
            break;

          default:
            MessageBox.Show("This is an error");
            break;
        }

        if (plant != null)
        {
          allPlantsDict.Add(plant.Name, plant);
          LstBoxPlant.Items.Add(plant.Name);

          TxtBoxName.Text = "";
          cbEnvironment.SelectedIndex = -1;
          cbType.SelectedIndex = -1;
        }

      }
    }


    private void BtnShowDetails_Click(object sender, RoutedEventArgs e)
    {
      if (LstBoxPlant.SelectedIndex > -1)
      {
        if (allPlantsDict.TryGetValue(LstBoxPlant.SelectedItem.ToString(), out Plant slPlant))
        {
          DetailsWindow pdw = new DetailsWindow();
          pdw.LblNameResults.Content = slPlant.Name;
          pdw.LblTypeResults.Content = slPlant.Type;
          pdw.LblEnvResults.Content = slPlant.Environment;
          pdw.SelectedPlant = slPlant;

          pdw.Show();
        }
        else
        {
          MessageBox.Show("Couldn't find that plant in the database.");
        }
      }
    }

    private void cbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      if (cbEnvironment.SelectedIndex > -1)
      {
        switch (cbType.SelectedItem.ToString())
        {
          case "Flower":
            ImgType.Source = new BitmapImage(new Uri("/Images/rose.png", UriKind.Relative));
            break;
          case "Tree":
            ImgType.Source = new BitmapImage(new Uri("/Images/tree.jpg", UriKind.Relative));
            break;
          case "Shrub":
            ImgType.Source = new BitmapImage(new Uri("/Images/shrub.png", UriKind.Relative));
            break;

          default:
            MessageBox.Show("An unexpected error has occurred");
            break;
        }
      }
      else
      {
        ImgType.Source = new BitmapImage(new Uri("/Images/blank.jpg", UriKind.Relative));
      }
    }

    private void cbEnvironment_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

      if (cbEnvironment.SelectedIndex > -1)
      {
        switch (cbEnvironment.SelectedItem.ToString())
        {
          case "Forest":
            ImgEnvironment.Source = new BitmapImage(new Uri("/Images/forest.png", UriKind.Relative));
            break;
          case "Tropical":
            ImgEnvironment.Source = new BitmapImage(new Uri("/Images/tropical.jpg", UriKind.Relative));
            break;
          case "Desert":
            ImgEnvironment.Source = new BitmapImage(new Uri("/Images/desert.png", UriKind.Relative));
            break;

          default:
            MessageBox.Show("An unexpected error has occurred");
            break;
        }
      }
      else
      {
        ImgEnvironment.Source = new BitmapImage(new Uri("/Images/blank.jpg", UriKind.Relative));
      }  
    }

    private void LstBoxPlant_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      string slLst = LstBoxPlant.SelectedItem.ToString();
      
      allPlantsDict.TryGetValue(slLst, out Plant slPlant);

      switch (slPlant.Environment)
      {
        case "Forest":
          ImgEnvironment.Source = new BitmapImage(new Uri("/Images/forest.png", UriKind.Relative));
          break;
        case "Tropical":
          ImgEnvironment.Source = new BitmapImage(new Uri("/Images/tropical.jpg", UriKind.Relative));
          break;
        case "Desert":
          ImgEnvironment.Source = new BitmapImage(new Uri("/Images/desert.png", UriKind.Relative));
          break;
      }

      switch (slPlant.Type)
      {
        case "Flower":
          ImgType.Source = new BitmapImage(new Uri("/Images/rose.png", UriKind.Relative));
          break;
        case "Tree":
          ImgType.Source = new BitmapImage(new Uri("/Images/tree.jpg", UriKind.Relative));
          break;
        case "Shrub":
          ImgType.Source = new BitmapImage(new Uri("/Images/shrub.png", UriKind.Relative));
          break;

        default:
          break;
      }
    }
  }
}

