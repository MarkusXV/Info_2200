using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerApp
{
  public class SynchronousSocketListener
  {
    const int PORT_NUMBER = 11000; //Creates a constant for the port number
    const string IP_ADDRESS = "127.0.0.1"; //Creates a constant for the IP address
    const string JOKE_INPUT = "JOKE"; //Creates a constant for the joke input that we'll use to compare to the request string
    const string CONSP_INPUT = "CONSPIRACY"; //Creates a constant for the consp input that we'll use to compare to the request string

    TcpListener tcpListener; //imports the tcpListener class
    ServerData serverData; //imports the serverData class

    /// <summary>
    /// Initiates the Socket Listener
    /// </summary>
    public SynchronousSocketListener()
    {
      serverData = new ServerData(); //calls the ServerData constructor method
      serverData.LoadFiles(); //calls the LoadFiles method (loads the arrays with the txt files)
    }

    /// <summary>
    /// Starts the Thread for the socket so that we can listen for requests on the IP address and port
    /// </summary>
    public void StartListening()
    {
      IPAddress iPAddress = IPAddress.Parse(IP_ADDRESS);
      tcpListener = new TcpListener(iPAddress, PORT_NUMBER);
      tcpListener.Start();

      Thread thread = new Thread(new ThreadStart(ProcessSocket));
      thread.Start();
    }

    public void ProcessSocket()
    {
      Socket socket = null;

      while (true)
      {
        try
        {
          socket = tcpListener.AcceptSocket();
          NetworkStream ns = new NetworkStream(socket);
          StreamReader streamReader = new StreamReader(ns);
          StreamWriter streamWriter = new StreamWriter(ns);

          streamWriter.AutoFlush = true;

          string userRequest = streamReader.ReadLine();
          Console.WriteLine($"User Requested: {userRequest}");

          if (userRequest.ToUpper() == JOKE_INPUT)
          {
            string randJoke = serverData.GetRandomJoke();
            Console.WriteLine(randJoke);
            streamWriter.WriteLine(randJoke);


          }
          else if (userRequest.ToUpper() == CONSP_INPUT)
          {
            string randConsp = serverData.GetRandomConsp();
            Console.WriteLine(randConsp);
            streamWriter.WriteLine(randConsp);
          }
          else
          {
            Console.WriteLine($"Unable to make process {userRequest} on the server");
            streamWriter.WriteLine("Please type \"Joke\" or \"Conspiracy\"");
          }
        }
        catch (Exception ex)
        {
          Console.WriteLine(ex.ToString());
        }
      }
    }
  }
}
