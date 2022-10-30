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
  public partial class OnlineForm : Form
  {
    public OnlineForm()
    {
      InitializeComponent(); //Initializes the components of the window
    }
    
    /* 
     * Saves the table when the save button is clicked
     */
    private void uVUPhoneNumsTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.uVUPhoneNumsTableBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.iNFO2200_CrandallSayDataSet);

    }

    /*
     * Loads the table with the query Fill
     */
    private void OnlineForm_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'iNFO2200_CrandallSayDataSet.UVUPhoneNumsTable' table. You can move, or remove it, as needed.
      this.uVUPhoneNumsTableTableAdapter.Fill(this.iNFO2200_CrandallSayDataSet.UVUPhoneNumsTable);

    }

    /*
     * Shows the Totals form when the show totals button is clicked
     */
    private void BtnShowTotals_Click(object sender, EventArgs e)
    {
      UVUTotalsForm uvuTotalsForm = new UVUTotalsForm(); //Creates a new instance of the Totals form
      uvuTotalsForm.ShowDialog(); //Displays the totals form just created as modal
    }
  }
}
