using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation3_Plants
{
  public class Shrub : Plant //Derives the Shrub class from the Plant abstract class
  {
    public Shrub(string nm, string env, string tp) : base(nm, env, tp) //Passes the nm env and tp to the drived class
    {

    }

    public override string Sniff() //Overrides the Sniff abstract method from the parent class
    {
      return "I like the smell of shrubs."; //Returns the sniff string for the tree
    }

    public override decimal Price() //Overrides the Price abstract method from the parent class
    {
      return 5.79m; //Returns the price for the Shrub
    }
  }
}
