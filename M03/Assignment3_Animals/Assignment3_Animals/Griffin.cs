using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Animals
{
  public class Griffin : Animal //Creates the derived class from the animal abstract class
  {
    public Griffin(string skin, string food) : base(skin, food) //Constructer method that pulls the skin and food parameters from the base class
    {
     
    }

    public override string Move() //Overrides the Move method from the base class
    {
      return "Walkin\'"; //Returns the string for the move method
    }
    public override string Unique() //overrides the Unique method from the base class
    {
      return "Flaps wings aggressively and sqauwks"; //Returns the string for the move method
    }

  }
}
