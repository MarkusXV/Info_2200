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
      InitializeComponent();


    }

    //Radio Button Methods

    private void RBtnManticore_Checked(object sender, RoutedEventArgs e)
    {
      animal = new Manticore("Rough", "Meaty things");
      ImgAnimal.Source = new BitmapImage(new Uri("/Images/Manticore.jpg", UriKind.Relative));

      LblAttributes.Content = "(Attribute)";
      LblActions.Content = "(Action)";
      LblUnique.Content = "(Unique)";
    }

    private void RBtnDragon_Checked(object sender, RoutedEventArgs e)
    {
      animal = new Dragon("Scaly", "Humans");
      ImgAnimal.Source = new BitmapImage(new Uri("/Images/Dragon.jpg", UriKind.Relative));

      LblAttributes.Content = "(Attribute)";
      LblActions.Content = "(Action)";
      LblUnique.Content = "(Unique)";
    }

    private void RBtnGriffin_Checked(object sender, RoutedEventArgs e)
    {
      animal = new Griffin("Fluffy", "All sorts of stuff");
      ImgAnimal.Source = new BitmapImage(new Uri("/Images/Griffin.jpg", UriKind.Relative));

      LblAttributes.Content = "(Attribute)";
      LblActions.Content = "(Action)";
      LblUnique.Content = "(Unique)";
    }

    //Button Methods



    public bool CheckRadioStatus()
    {
      if (RBtnManticore.IsChecked == false && RBtnDragon.IsChecked == false && RBtnGriffin.IsChecked == false)
      {
        MessageBox.Show("Select an Animal First");
        return false;
      }
      else
      {
        return true;
      }
    }

    private void BtnUnique_Click(object sender, RoutedEventArgs e)
    {
      bool status = CheckRadioStatus();
      if (status == true)
      {
        LblUnique.Content = animal.Unique();
      }

    }

    private void BtnSkinType_Click(object sender, RoutedEventArgs e)
    {
      bool status = CheckRadioStatus();
      if (status == true)
      {
        
        LblAttributes.Content = "Skin type: " + animal.SkinType;
      }

    }

    private void BtnFoodType_Click(object sender, RoutedEventArgs e)
    {
      bool status = CheckRadioStatus();
      if (status == true)
      {
        LblAttributes.Content = "Food type: " + animal.FoodType;
      }
    }

    private void BtnEat_Click(object sender, RoutedEventArgs e)
    {
      bool status = CheckRadioStatus();
      if (status == true)
      {
        LblActions.Content = "Eat: " + animal.Eat();
      }
    }

    private void BtnMove_Click(object sender, RoutedEventArgs e)
    {
      bool status = CheckRadioStatus();
      if (status == true)
      {
        LblActions.Content = "Move: " + animal.Move();
      }
    }

    private void BtnReproduce_Click(object sender, RoutedEventArgs e)
    {
      bool status = CheckRadioStatus();
      if (status == true)
      {
        LblActions.Content = "Reproduce: " + animal.Reproduce();
      }

    }
  }
}
