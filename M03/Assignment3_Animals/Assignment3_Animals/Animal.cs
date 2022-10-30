using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Animals
{
  public abstract class Animal //Sets the Abstract class Animal
  {
    private string _skinType; //Declares the skintype backing field
    private string _foodType; //Declares the foodtype backing field
    
    public string SkinType //Skintype property variable
    {
      get { return _skinType; } //Get the value
      set { _skinType = value; } //Set the value
    }

    public string FoodType //Foodtype property variable
    {
      get { return _foodType; } //Get the value
      set { _foodType = value; } //Set the value
    }

    /// <summary>
    /// Calls an instance of the Animal class with the backing fields being set
    /// </summary>
    /// <param name="skin"></param>
    /// <param name="food"></param>
    public Animal(string skin, string food) 
    {
      _skinType = skin; //calls the backing fields fromm their parameters
      _foodType = food; //calls the backing fields from their parameters
    }

    /// <summary>
    /// Eat method
    /// </summary>
    /// <returns>string</returns>
    public string Eat()
    {
      return "Crunch Crunch"; //returns the string that I want displayed
    }

    /// <summary>
    /// Move method
    /// </summary>
    /// <returns>string</returns>
    public virtual string Move() 
    {
      return "Zooming"; //returns the string that I want displayed
    }

    public string Reproduce() //returns the string that I want displayed
    {
      return "Make a Little Baby"; //returns the string that I want displayed
    }

    /// <summary>
    /// Declares the Unique abstract method
    /// </summary>
    /// <returns></returns>
    public abstract string Unique();
    
  }



  
}
