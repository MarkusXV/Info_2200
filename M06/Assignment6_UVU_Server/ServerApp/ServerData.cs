using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
  public class ServerData
  {
    Random rand = new Random(); //Imports the random class
    string[] facts; //Creates an empty array to put teh facts into
    string[] majors; //Creates an empty array to put the Majors into
    const string FACT_FILE = "UVUFacts.txt"; //Constant for the fact file
    const string MAJOR_FILE = "UVUCourseDescriptions.txt"; //Constant for the Major file

    /// <summary>
    /// Loads the Facts and Majors from the files to the arrays
    /// </summary>
    public void LoadFiles()
    {
      try
      {
        facts = File.ReadAllLines(FACT_FILE); //Puts the fact file contents into the facts array
        majors = File.ReadAllLines(MAJOR_FILE); //Puts the major file contents into the majors array
      }
      catch (Exception ex) //Any errors will be caught here
      {
        Console.WriteLine(ex.Message); //Writes any errors to the server console
      }
    }

    /// <summary>
    /// Returns a random Fact from the array
    /// </summary>
    /// <returns></returns>
    public string GetRandomFact()
    {
      return facts[rand.Next(facts.Length)]; //Returns a random fact from the array
    }

    /// <summary>
    /// Returns a random Major from the array
    /// </summary>
    /// <returns></returns>
    public string GetRandomMajor()
    {
      return majors[rand.Next(majors.Length)]; //Returns a random Major from the array
    }
  }
}
