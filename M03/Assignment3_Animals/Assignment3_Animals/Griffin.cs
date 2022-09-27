using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Animals
{
  public class Griffin : Animal
  {
    public Griffin(string skin, string food) : base(skin, food)
    {
     
    }

    public override string Move()
    {
      return "Walkin\'";
    }
    public override string Unique()
    {
      return "Flaps wings aggressively and sqauwks";
    }

  }
}
