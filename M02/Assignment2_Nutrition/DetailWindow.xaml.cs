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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace Assignment2_Nutrition
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window
    {
        /// <summary>
        /// Creates the GUI
        /// </summary>
        public DetailWindow()
        {
            InitializeComponent(); //Initializes the Components of the GUI so that we can show it later
        }

        /// <summary>
        /// Updates the Detail Window's Label contect with the selected Food's details
        /// </summary>
        /// <param name="selectedFood"></param>
        public void UpdateGUI(Food selectedFood)
        {
            LblFood.Content =         selectedFood.Foodkey;
            LblCalcium.Content =      selectedFood.Calcium;
            LblServingSize.Content =  selectedFood.ServingSize;
            LblWeight.Content =       selectedFood.Weight;
            LblPercentWater.Content = selectedFood.PercentWater;
            LblCalories.Content =     selectedFood.Energy;
            LblProtein.Content =      selectedFood.Protein;
            LblCarbohydrate.Content = selectedFood.Carbohydrate;
            LblFiber.Content =        selectedFood.Fiber;
            LblCholesterol.Content =  selectedFood.Cholesterol;
            LblTotalFat.Content =     selectedFood.TotalFat;
            LblSaturateFat.Content =  selectedFood.SaturateFat;
            LblMonosatFat.Content =   selectedFood.MonosatFat;
            LblPolyunsatFat.Content = selectedFood.PolyunsatFat;
            LblIron.Content =         selectedFood.Iron;
            LblMagnesium.Content =    selectedFood.Magnesium;
            LblSodium.Content =       selectedFood.Sodium;
            LblPhosphorous.Content =  selectedFood.Phosphorous;
            LblCaP.Content =          selectedFood.CaP;
            LblPotassium.Content =    selectedFood.Potassium;
            LblZinc.Content =         selectedFood.Zinc;
            LblNiacin.Content =       selectedFood.Niacin;
            LblThiamin.Content =      selectedFood.Thiamin;
            LblRiboflavin.Content =   selectedFood.Riboflavin;
            LblVitA.Content =         selectedFood.VitA;
            LblVitC.Content =         selectedFood.VitC;
            LblVitB6.Content =        selectedFood.VitB6;
            LblFoodType.Content =     selectedFood.FoodType;
        }
    }
}
