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
  public partial class LocalPhoneForm : Form
  {
    public LocalPhoneForm()
    {
      InitializeComponent(); //Initializes the components for the window
    }

    /*
     * Saves the table when the save button is clicked
     */
    private void phoneNumbersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
        this.Validate();
      this.phoneNumbersBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.localPhoneDbDataSet);

    }

    /*
     * Loads the table with the query fill
     */
    private void LocalPhoneForm_Load(object sender, EventArgs e)
    {
        // TODO: This line of code loads data into the 'localPhoneDbDataSet.PhoneNumbers' table. You can move, or remove it, as needed.
        this.phoneNumbersTableAdapter.Fill(this.localPhoneDbDataSet.PhoneNumbers);

    }

    /*
     * Sorts the table data by last name with the query SortByLastName
     */
    private void BtnSortLN_Click(object sender, EventArgs e)
    {
      this.phoneNumbersTableAdapter.SortByLastName
        (this.localPhoneDbDataSet.PhoneNumbers);
    }

    /*
     * Shows the people with a greater age than 30 with the SortAgeGT30 query
     */
    private void BtnAge30_Click(object sender, EventArgs e)
    {
      this.phoneNumbersTableAdapter.SortAgeGT30
        (this.localPhoneDbDataSet.PhoneNumbers);
    }

    /*
     * Shows the average age in a message box when the average button is clicked
     */
    private void BtnAvAge_Click(object sender, EventArgs e)
    {
      MessageBox.Show($"Average Age: {this.phoneNumbersTableAdapter.AvgAge()}"); //Display a message box
    }

    /*
     * Clears the table with all the data and clears the text box
     */
    private void BtnClear_Click(object sender, EventArgs e)
    {
      LocalPhoneForm_Load(sender, e); //Reloads the table data
      TxtBoxFN.Clear(); //Clear text box
    }

    /*
     * filters the table data based on the search results in the text box everytime the text changes in the box using the FillByFirstName query
     */
    private void TxtBoxFN_TextChanged(object sender, EventArgs e)
    {
      this.phoneNumbersTableAdapter.FillByFirstName
         (this.localPhoneDbDataSet.PhoneNumbers, TxtBoxFN.Text);
    }
  }
}
