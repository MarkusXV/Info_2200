using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Animals
{
  public class Dragon : Animal //Creates the derived class from the animal abstract class
  {
    public Dragon(string skin, string food) : base(skin, food) //Constructer method that pulls the skin and food parameters from the base class
    {

    }

    public override string Move() //Overrides the Move method from the base class
    {
      return "Soarin\'"; //Returns the string for the move method
    }
    public override string Unique() //overrides the Unique method from the base class
    {
      return "RWAAAAAAR (Breaths fire)"; //Returns the string for the move method
    }
  }
}
