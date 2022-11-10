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
    string[] jokes; //Creates an empty array to put the jokes into
    string[] conspiracies; //Creates an empty array to put the conspiracies into
    const string JOKE_FILE = "jokes.txt"; //Constant for the Joke File name
    const string CONSP_FILE = "conspiracies.txt"; //Constant for the Conspiracy file name

    /// <summary>
    /// Loads the Jokes and Conspiracties from the files to the arrays
    /// </summary>
    public void LoadFiles()
    {
      try
      {
        jokes = File.ReadAllLines(JOKE_FILE); //PUts the Joke File contents into the jokes array
        conspiracies = File.ReadAllLines(CONSP_FILE); //Puts the Conspiracy File contents into the conspiracies array
      }
      catch (Exception ex) 
      {
        Console.WriteLine(ex.Message); //Writes any errors to the server console
      }
    }

    /// <summary>
    /// Returns a random Joke from the Array
    /// </summary>
    /// <returns></returns>
    public string GetRandomJoke()
    {
      return jokes[rand.Next(jokes.Length)]; /// Returns a random Joke from the Array
    }

    /// <summary>
    /// Returns a random Conspiracy from the Array
    /// </summary>
    /// <returns></returns>
    public string GetRandomConsp()
    {
      return conspiracies[rand.Next(conspiracies.Length)]; //Returns a random Conspiracy from the Array
    }
  }
}
