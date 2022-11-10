using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
  public class Program
  {
    static void Main(string[] args)
    {
      TempServer tempServer = new TempServer();
      tempServer.LoadFiles();

      Console.WriteLine("Welcome to Peter's UVU Server");
      Console.WriteLine("-----------------------------");

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
          Console.WriteLine($"Fact: {tempServer.GetRandomFact()}");
          Console.WriteLine($"Class: {tempServer.GetRandomMajor()}");
        }
      }
    }
  }
}
