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
  internal class SynchronousSocketListener
  {
    const int PORT_NUMBER = 11000; //Creates a constant for the port number
    const string IP_ADDRESS = "127.0.0.1"; //Creates a constant for the IP address
    const string FACT_INPUT = "UVUFACT"; //Creates a constant for the Fact input that we'll use to compare to the request string
    const string MAJOR_INPUT = "UVUMAJOR"; //Creates a constant for the Major input that we'll use to compare to the request string

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
      IPAddress iPAddress = IPAddress.Parse(IP_ADDRESS); //Sets the IP address using the IP_ADDRESS constant
      tcpListener = new TcpListener(iPAddress, PORT_NUMBER); //Creates a new TcpListener using the IP address and the port
      tcpListener.Start(); //Starts the listener

      Thread thread = new Thread(new ThreadStart(ProcessSocket)); //Creates a new thread using a new Threadstart which passes in the ProcessSocket method (doesn't need parenthesis for some reason)
      thread.Start(); //Starts the thread
    }

    /// <summary>
    /// Tells the socket how to handle the connection and what to do with streamreaders and writers
    /// </summary>
    public void ProcessSocket()
    {
      Socket socket = null; //Sets a new Socket to null

      while (true)
      {
        try
        {
          socket = tcpListener.AcceptSocket(); //Tries to accept the socket
          NetworkStream ns = new NetworkStream(socket); //Creates a network stream based on the socket just created
          StreamReader streamReader = new StreamReader(ns); //Creates a new StreamReader based on the networkstream just created
          StreamWriter streamWriter = new StreamWriter(ns); //Creates a new StreamWriter based on the networkstream just created

          streamWriter.AutoFlush = true; //Sets the AutoFlush to true for the streamWriter

          string userRequest = streamReader.ReadLine(); //Reads a line from the streamreader once something comes in and calls it the userRequest
          Console.WriteLine($"User Requested: {userRequest}"); //Outputs the user's request to see that the server got it on the console

          ///Checks to see what the user input was and what to output based on that
          if (userRequest.ToUpper() == FACT_INPUT) //If the user requests fact
          {
            string randFact = serverData.GetRandomFact(); //Calls the GetRandomFact in serverData.cs and calls it randFact
            Console.WriteLine(randFact); //Writes the randFact to the console
            streamWriter.WriteLine(randFact); //Passes the randFact to the client through streamwriter


          }
          else if (userRequest.ToUpper() == MAJOR_INPUT) //If the user requests major
          {
            string randMajor = serverData.GetRandomMajor(); //Calls the GetRandomMajor in serverData.cs and calls it randMajor
            Console.WriteLine(randMajor); //Writes the randMajor to the console
            streamWriter.WriteLine(randMajor); //Passes teh randMajor to the client through streamwriter
          }
          else //If it isn't either fact or major (error)
          {
            Console.WriteLine($"Unable to make process {userRequest} on the server"); //Writes the userRequest to the console so we can see what they requested
            streamWriter.WriteLine("Please type \"UVUFact\" or \"UVUMajor\""); //Passes an error message to the client through streamwriter
          }
        }
        catch (Exception ex) //Any errors or exceptions
        {
          Console.WriteLine(ex.ToString()); //Writes the error out to the server console
        }
      }
    }
  }
}