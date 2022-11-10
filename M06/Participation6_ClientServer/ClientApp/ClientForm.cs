using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
  public partial class ClientForm : Form
  {
    SynchronousSocketClient client = new SynchronousSocketClient(); //Creates a new instance of teh SynchronousSocketClient class and calls the constructor method

    public ClientForm()
    {
      InitializeComponent(); //Initializes the components of the GUI
    }

    /// <summary>
    /// When the Submit button is clicked, it will get the response from the server and display it in the response box
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnSubmit_Click(object sender, EventArgs e)
    {
      TxtBoxResponse.Text = client.ContactServer(TxtBoxRequest.Text); //Takes the request from the GUI, sends it to the server, and sets the Response text box to the response of the server
    }
  }
}

