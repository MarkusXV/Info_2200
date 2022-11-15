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
    SynchronousSocketClient client = new SynchronousSocketClient(); //imports the Socket class so that we can create a new socket

    public ClientForm()
    {
      InitializeComponent(); //Initializes the components of the GUI
    }

    /// <summary>
    /// 
    /// Gets the response from the server when the Submit button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnSubmit_Click(object sender, EventArgs e)
    {
      TxtBoxResponse.Text = client.ContactServer(TxtBoxRequest.Text); //Sends the text box info to the server and the server sends the response back, and puts it into the Response Text Box
    }
  }
}
