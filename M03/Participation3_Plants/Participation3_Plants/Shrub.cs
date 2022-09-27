using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation3_Plants
{
  public class Shrub : Plant
  {
    public Shrub(string nm, string env, string tp) : base(nm, env, tp)
    {

    }

    public override string Sniff()
    {
      return "I like the smell of shrubs.";
    }
  }
}
