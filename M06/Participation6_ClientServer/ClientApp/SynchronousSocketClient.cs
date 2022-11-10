using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
  public class SynchronousSocketClient
  {
    const int SERVER_PORT = 11000; //Constant for the server port
    const string IP_ADDRESS = "127.0.0.1"; //Constant for the client IP address

    /// <summary>
    /// Contacts the server by opening up the tcpClient and networkstream
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
    public string ContactServer(string request)
    {
      string responseString = ""; //Declares an empty response string
      try
      {
        ///Setting up the Connection with IP and Port
        TcpClient tcpClient = new TcpClient(); //Creates a new instance of the TcpClient class
        tcpClient.Connect(IPAddress.Parse(IP_ADDRESS), SERVER_PORT); //Connects to the server using the IP address and the port
        NetworkStream networkStream = tcpClient.GetStream(); //Creates a networkStream by calling the GetStream method

        ///Passing the request and response to and from Server
        StreamWriter streamWriter = new StreamWriter(networkStream); //Sets up the streamwriter to be able to send to the server
        StreamReader streamReader = new StreamReader(networkStream); //Sets up the streamreader to be able to read from the server's response

        streamWriter.AutoFlush = true; //Sets the streamwriter's autoflush to true
        streamWriter.WriteLine(request); //Sends the user's request over to the server
        responseString = streamReader.ReadLine(); //Gets the response from the server and puts it into the response string

        networkStream.Close(); //Closes the network stream
        tcpClient.Close(); //Closes the tcpClient
      }
      catch (Exception ex) //Any errors that occur
      {
        responseString = ex.Message; //Display the error in the response string so that the GUI response text box will see it
      }
      return responseString; //Returns the response string
    }
  }
}
