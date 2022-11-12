using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerApp
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the server app."); //Writes a welcome message to the console

      SynchronousSocketListener listener = new SynchronousSocketListener(); //Creates a new instance of the SynchSockList class and calls it's constructor method
      listener.StartListening(); //Calls the start listening method in the listener class

      Process process = new Process(); //Creates a new Process using System.Diagnostics

      process.StartInfo.FileName = "D:\\Github\\Info_2200\\M06\\Assignment6_UVU_Server\\ClientApp\\bin\\Debug\\ClientApp.exe"; //Provides the .exe for the ClientApp GUI
      process.Start(); //Starts the GUI Process

      Console.WriteLine("The Server is running..."); //Prints that the server is running just to make sure
      Console.ReadLine(); //Waits for a request from the Client and makes sure that the console stays open

      //Mac: Y:\\Documents\\GitHub\\Info_2200\\M06\\Assigment6_UVU_Server\\ClientApp\\bin\\Debug\\ClientApp.exe
      //Windows: D:\\Github\\Info_2200\\M06\\Assigment6_UVU_Server\\ClientApp\\bin\\Debug\\ClientApp.exe
    }
  }
}


