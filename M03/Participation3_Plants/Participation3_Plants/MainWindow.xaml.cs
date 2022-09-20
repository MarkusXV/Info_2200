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

namespace Participation3_Plants
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
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

        private void BtnAddPlant_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnShowDetails_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
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

        private void cbEnvironment_SelectionChanged(object sender, SelectionChangedEventArgs e)
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
    }
}
