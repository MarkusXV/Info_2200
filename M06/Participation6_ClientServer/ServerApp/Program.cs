using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the server app.");
      
      SynchronousSocketListener listener = new SynchronousSocketListener();
      listener.StartListening();
      Console.WriteLine("The Server is running...");
      Console.ReadLine();



      //ServerData serverData = new ServerData();
      //serverData.LoadFiles();

      //Console.WriteLine("Welcome to Peter's Joke/Conspiracy Server");
      //Console.WriteLine("-----------------------------------------");

      //while (true)
      //{
      //  Console.WriteLine("Type q to quit");
      //  string userInput = Console.ReadLine();
        
      //  if (userInput == "q")
      //  {
      //    break;
      //  }
      //  else
      //  {
      //    Console.WriteLine($"Joke: {serverData.GetRandomJoke()}");
      //    Console.WriteLine($"Conspiracy: {serverData.GetRandomConsp()}");
        }
      }
    }
  }
}
