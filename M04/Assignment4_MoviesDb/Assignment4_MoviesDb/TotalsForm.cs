using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment4_MoviesDb
{
  public partial class TotalsForm : Form
  {
    public TotalsForm()
    {
      InitializeComponent(); //Initializes the components of the window
    }

    /// <summary>
    /// Saves the data to the data set when the save item button is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void movieBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
      this.Validate();
      this.movieBindingSource.EndEdit();
      this.tableAdapterManager.UpdateAll(this.iNFO2200_CrandallSayDataSet);

    }

    /// <summary>
    /// Loads the table in the totals form with the Fill query data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TotalsForm_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'countMovieCategory._CountMovieCategory' table. You can move, or remove it, as needed.
      this.countMovieCategoryTableAdapter.Fill(this.countMovieCategory._CountMovieCategory);
    }
  }
}
