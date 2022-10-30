using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation3_Plants
{
  public class Flower : Plant //Derives the Flower class from the plant abstract class
  {
    public Flower(string nm, string env, string tp) : base(nm, env, tp) //Passes the nm env nad tp to the derived class
    {

    }

    public override string Sniff() //Overrides the Sniff abstract method from the parent class
    {
      return "I like the smell of Flowers."; //Returns the sniff string for the flower
    }

    public override decimal Price() //Overrides the Sniff abstract method from the parent class
    {
      return 5.39m; //Returns the price for the flower
    }

  }
}
