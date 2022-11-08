using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_JellyBelly
{
  public partial class JellyBellyForm : Form
  {
    JellyBellyEntityDb db = new JellyBellyEntityDb(); //Imports the database into the class
    public JellyBellyForm()
    {
      InitializeComponent(); //Initializes the components of the form
    }

    /// <summary>
    /// Searches the database for what's in the text box and puts it into the data grid view
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnSearch_Click(object sender, EventArgs e)
    {
      List<JellyBelly> filteredJelly = db.JellyBellies.Where(jell => jell.jellyBellyFlavor.Contains(TxtBoxSearch.Text)).ToList(); //Puts the filtered database items in a list based on the search textbox

      DgvJellyBellies.DataSource = filteredJelly; //Puts the new filtered list into the Data grid view
    }

    /// <summary>
    /// Resets the Data grid view with the full database to the DGV and resets the search text box
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnShowAll_Click(object sender, EventArgs e)
    {
      UpdateTableData(); //Calls the UpdateTableData method to put the full database in the DGV
      TxtBoxSearch.Text = ""; //Resets the textbox to blank
    }

    /// <summary>
    /// Closes the form when you click on the button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnClose_Click(object sender, EventArgs e)
    {
      Close(); //Closes the form
    }

    /// <summary>
    /// When the form is loaded, it will input the database data to the DGV
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void JellyBellyForm_Load(object sender, EventArgs e)
    {
      UpdateTableData(); //Calls the UpdateTableData method
    }
    
    /// <summary>
    /// Inputs the database data into the DGV
    /// </summary>
    private void UpdateTableData()
    {
      //List<JellyBelly> jellybellies = (from jell in db.JellyBellies select jell).ToList();
      List<JellyBelly> jellybellies = db.JellyBellies.ToList(); //Takes the database and puts it into a list so that we can put it in the DGV

      DgvJellyBellies.DataSource = jellybellies; //Sets the DGV source to the new list we just made

      for (int i = 0; i < DgvJellyBellies.Columns.Count; i++) //Sets all the columns to Fill size
      {
        DgvJellyBellies.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      }

    }
  }
}
