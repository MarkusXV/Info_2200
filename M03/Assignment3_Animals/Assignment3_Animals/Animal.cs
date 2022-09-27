using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Animals
{
  public abstract class Animal
  {
    private string _skinType;
    private string _foodType;
    
    public string SkinType
    {
      get { return _skinType; }
      set { _skinType = value; }
    }

    public string FoodType
    {
      get { return _foodType; }
      set { _foodType = value; }
    }

    public Animal(string skin, string food)
    {
      _skinType = skin;
      _foodType = food;
    }


    public string Eat()
    {
      return "Crunch Crunch";
    }

    public virtual string Move()
    {
      return "Zooming";
    }

    public string Reproduce()
    {
      return "Make a Little Baby";
    }

    public abstract string Unique();
    
  }



  
}
