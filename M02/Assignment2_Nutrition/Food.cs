using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Nutrition
{
    /// <summary>
    /// Creates the Food class where we create the array definitions of the Food Details
    /// </summary>
    public class Food 
    {
        /// <summary>
        /// Takes the list of the phone details from the text file and splits them into seperate details
        /// </summary>
        /// <param name="food"></param>
        public Food(string[] food)
        {
            Foodkey =       food[0];
            Calcium =       double.Parse(food[1]);
            ServingSize =   food[2]; //The assignment says double, but there's text inside the txt file for the serving size so I changed it to a string
            Weight =        double.Parse(food[3]);
            PercentWater =  double.Parse(food[4]);
            Energy =        double.Parse(food[5]);
            Protein =       double.Parse(food[6]);
            Carbohydrate =  double.Parse(food[7]);
            Fiber =         double.Parse(food[8]);
            Cholesterol =   double.Parse(food[9]);
            TotalFat =      double.Parse(food[10]);
            SaturateFat =   double.Parse(food[11]);
            MonosatFat =    double.Parse(food[12]);
            PolyunsatFat =  double.Parse(food[13]);
            Iron =          double.Parse(food[14]);
            Magnesium =     double.Parse(food[15]);
            Sodium =        double.Parse(food[16]);
            Phosphorous =   double.Parse(food[17]);
            CaP =           double.Parse(food[18]);
            Potassium =     double.Parse(food[19]);
            Zinc =          double.Parse(food[20]);
            Niacin =        double.Parse(food[21]);
            Thiamin =       double.Parse(food[22]);
            Riboflavin =    double.Parse(food[23]);
            VitA =          double.Parse(food[24]);
            VitC =          double.Parse(food[25]);
            VitB6 =         double.Parse(food[26]);
            FoodType =      food[27];
            
            //28 different Food details are in the txt file and in the Dictionary Values for each Food

        }

        /// <summary>
        /// Lets us have different Food details for each food key we pass into the method and sets it to those same values
        /// </summary>
        public string Foodkey       { get; set; }
        public double Calcium       { get; set; }
        public string ServingSize   { get; set; }
        public double Weight        { get; set; }
        public double PercentWater  { get; set; }
        public double Energy        { get; set; }
        public double Protein       { get; set; }
        public double Carbohydrate  { get; set; }
        public double Fiber         { get; set; }
        public double Cholesterol   { get; set; }
        public double TotalFat      { get; set; }
        public double SaturateFat   { get; set; }
        public double MonosatFat    { get; set; }
        public double PolyunsatFat  { get; set; }
        public double Iron          { get; set; }
        public double Magnesium     { get; set; }
        public double Sodium        { get; set; }
        public double Phosphorous   { get; set; }
        public double CaP           { get; set; }
        public double Potassium     { get; set; }
        public double Zinc          { get; set; }
        public double Niacin        { get; set; }
        public double Thiamin       { get; set; }
        public double Riboflavin    { get; set; }
        public double VitA          { get; set; }
        public double VitC          { get; set; }
        public double VitB6         { get; set; }
        public string FoodType      { get; set; }



    }
}
