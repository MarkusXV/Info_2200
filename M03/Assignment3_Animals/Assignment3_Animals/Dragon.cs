using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Animals
{
  public class Dragon : Animal
  {
    public Dragon(string skin, string food) : base(skin, food)
    {

    }

    public override string Move()
    {
      return "Soarin\'";
    }
    public override string Unique()
    {
      return "RWAAAAAAR (Breaths fire)";
    }
  }
}
