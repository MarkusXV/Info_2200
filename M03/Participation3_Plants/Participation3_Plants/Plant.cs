using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation3_Plants
{
  public abstract class Plant //Creates the Abstract class for all the child plant classes
  {
    private string _name; //Backing field for the name
    private string _type; //Backing field for the type
    private string _environment; //Backing field for the environment

    public string Name //Name method that returns a string
    {
      get { return _name; } //returns the value if the method is retrieved
      set { _name = value; } //Sets the backing field if the method is assigned (set)
    }

    public string Type //Name method that returns a string
    {
      get { return _type; } //returns the value if the method is retrieved
      set { _type = value; } //Sets the backing field if the method is assigned (set)
    }

    public string Environment //Name method that returns a string
    {
      get { return _environment; } //returns the value if the method is retrieved
      set { _environment = value; } //Sets the backing field if the method is assigned (set)
    }

    public abstract decimal Price(); //Abstract method for the Price so that we can override it in the child classes

    public Plant(string nm, string env, string tp) //Lets us create plants with the three parameters and put them in the backing field
    {
      _name = nm; //Puts nm that we pass in to the _name backing field
      _type = tp; //Puts tp that we pass in to the _type backing field
      _environment = env; //Puts env that we pass in to the _environment backing field

    }


    public virtual string Sniff() //Virtual method that we'll override in the child class
    {
      return "Let's sniff plants"; //Will never run since it will be overriden
    }
  }
}
