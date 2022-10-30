using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Participation4_PhoneDb
{
  public partial class LandingForm : Form
  {
    public LandingForm()
    {
      InitializeComponent(); //Initializes the components of the window
    }

    /*
     * Loads the Local Phone Form when the local database button is clicked
     */
    private void BtnLoadLocal_Click(object sender, EventArgs e)
    {
      LocalPhoneForm localPhoneForm = new LocalPhoneForm(); //Creates a new instance of the form
      localPhoneForm.ShowDialog(); //Displays the new form as modal
    }

     /*
     * Loads the Local Phone Form when the local database button is clicked
     */
    private void BtnImported_Click(object sender, EventArgs e)
    {
      ImportedDBform importedDBform = new ImportedDBform(); //Creates a new instance of the form
      importedDBform.ShowDialog(); //Displays the new form as modal
    }

    /*
     * Loads the Local Phone Form when the local database button is clicked
     */
    private void BtnOnline_Click(object sender, EventArgs e)
    {
      OnlineForm onlineForm = new OnlineForm(); //Creates a new instance of the form
      onlineForm.ShowDialog(); //Displays the new form as modal
    }

    /*
     * Closes the window when the close button is clicked
     */
    private void BtnClose_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
