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
  public partial class ImportedDBform : Form
  {
    public ImportedDBform()
    {
      InitializeComponent(); //Initializes the components of the window
    }
    /*
     * Saves the table when the save button is clicked
     */
    private void uvuPhoneDirectoryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.uvuPhoneDirectoryBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.uVUPhoneNumsDataSet);
    }
    /*
     * Loads the table with the query fill
     */
    private void ImportedDBform_Load(object sender, EventArgs e)
    {
      this.uvuPhoneDirectoryTableAdapter.Fill(this.uVUPhoneNumsDataSet.UvuPhoneDirectory);
    }

  }
}
