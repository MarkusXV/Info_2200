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
    Random rand = new Random();
    string[] facts;
    string[] majors;
    const string FACT_FILE = "UVUFacts.txt";
    const string MAJOR_FILE = "UVUCourseDescriptions.txt";

    public void LoadFiles()
    {
      try
      {
        facts = File.ReadAllLines(FACT_FILE);
        majors = File.ReadAllLines(MAJOR_FILE);
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }

    public string GetRandomFact()
    {
      return facts[rand.Next(facts.Length)];
    }

    public string GetRandomMajor()
    {
      return majors[rand.Next(majors.Length)];
    }
  }
}
