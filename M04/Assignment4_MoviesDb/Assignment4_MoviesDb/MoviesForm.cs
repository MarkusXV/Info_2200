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
  public partial class MoviesForm : Form
  {
    public MoviesForm()
    {
      InitializeComponent(); //Initializes the components of the window
    }

    /// <summary>
    /// Loads the table on the Movies form with the table data
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MoviesForm_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'iNFO2200_CrandallSayDataSet.Movie' table. You can move, or remove it, as needed.
      this.movieTableAdapter.Fill(this.iNFO2200_CrandallSayDataSet.Movie);

    }

    /// <summary>
    /// calls the SortAtoZ query when the button A to Z is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnAtoZ_Click(object sender, EventArgs e)
    {
      this.movieTableAdapter.SortAtoZ
        (this.iNFO2200_CrandallSayDataSet.Movie);
    }

    /// <summary>
    /// calls the SortZtoA query when the button Z to A is clicked
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnZtoA_Click(object sender, EventArgs e)
    {
      this.movieTableAdapter.SortZtoA
        (this.iNFO2200_CrandallSayDataSet.Movie);
    }

    /// <summary>
    /// Calls the SearchFirst20 query and displays the first 20 movie id's
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnSearchFirst20_Click(object sender, EventArgs e)
    {
      this.movieTableAdapter.SearchFirst20
        (this.iNFO2200_CrandallSayDataSet.Movie, TxtboxMovieTitle);
    }

    /// <summary>
    /// Creates and shows a new instance of the totals form window that displays the totals for each category
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnShowTotals_Click(object sender, EventArgs e)
    {
      TotalsForm totalsForm = new TotalsForm();
      totalsForm.Show();
        
    }

    /// <summary>
    /// Changes the query based on what's in the search text box and updates each time the text box changes
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void TxtboxMovieTitle_TextChanged(object sender, EventArgs e)
    {
      this.movieTableAdapter.SearchTxtBox
        (this.iNFO2200_CrandallSayDataSet.Movie, TxtboxMovieTitle.Text);
    }
  }
}
