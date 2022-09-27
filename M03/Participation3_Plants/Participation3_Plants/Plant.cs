using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation3_Plants
{
  public class Plant
  {
    private string _name;
    private string _type;
    private string _environment;

    public string Name
    {
      get { return _name; }
      set { _name = value; }
    }

    public string Type
    {
      get { return _type; }
      set { _type = value; }
    }

    public string Environment
    {
      get { return _environment; }
      set { _environment = value; }
    }

    public Plant(string nm, string env, string tp)
    {
      _name = nm;
      _type = tp;
      _environment = env;

    }


    public virtual string Sniff()
    {
      return "Let's sniff plants";
    }
  }
}
