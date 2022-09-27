using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Animals
{
  public class Manticore : Animal
  {
    public Manticore(string skin, string food) : base(skin, food)
    {
      

    }

    public override string Move()
    {
      return "Moonwalkin\'";
    }
    public override string Unique()
    {
      return "Swings stinger half-hazardly";
    }
  }
}
