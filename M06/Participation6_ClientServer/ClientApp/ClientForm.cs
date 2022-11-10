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
    SynchronousSocketClient client = new SynchronousSocketClient();

    public ClientForm()
    {
      InitializeComponent();
    }

    private void BtnSubmit_Click(object sender, EventArgs e)
    {
      TxtBoxResponse.Text = client.ContactServer(TxtBoxRequest.Text);
    }
  }
}
