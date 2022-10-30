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

namespace Participation3_Plants
{
  /// <summary>
  /// Interaction logic for DetailsWindow.xaml
  /// </summary>
  public partial class DetailsWindow : Window //Details Window that's based on the Window class
  {
    public Plant SelectedPlant { get; set; } //SelectedPlant variable so that we can use it in the Mainwindow back end code

    /// <summary>
    /// Details window constructor method
    /// </summary>
    public DetailsWindow() 
    {
      InitializeComponent(); //Initializes the components of the window
    }

    /// <summary>
    /// Shows the child classes' sniff string when the sniff button is placed
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnSniff_Click(object sender, RoutedEventArgs e)
    {
      MessageBox.Show(SelectedPlant.Sniff()); //Shows the derived classes' overriden sniff module
    }
  }
}
