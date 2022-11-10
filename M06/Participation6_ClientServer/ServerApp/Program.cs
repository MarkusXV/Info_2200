using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      TempServer tempServer = new TempServer();
      tempServer.LoadFiles();

      Console.WriteLine("Welcome to Peter's Joke/Conspiracy Server");
      Console.WriteLine("-----------------------------------------");

      while (true)
      {
        Console.WriteLine("Type q to quit");
        string userInput = Console.ReadLine();
        
        if (userInput == "q")
        {
          break;
        }
        else
        {
          Console.WriteLine($"Joke: {tempServer.GetRandomJoke()}");
          Console.WriteLine($"Conspiracy: {tempServer.GetRandomConsp()}");
        }
      }
    }
  }
}
