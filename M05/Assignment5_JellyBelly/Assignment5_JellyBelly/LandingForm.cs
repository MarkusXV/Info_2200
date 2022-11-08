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
  public partial class LandingForm : Form
  {
    public LandingForm()
    {
      InitializeComponent(); //Initializes the components of the form
    }

    /// <summary>
    /// Shows the CategoryForm Form when they click the Show Flavors button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnShowFlavors_Click(object sender, EventArgs e)
    {
      CategoryForm cf = new CategoryForm(); //Creates a new instance of the form
      cf.ShowDialog(); //Shows the form modally
    }

    /// <summary>
    /// Shows the JellyBellyForm Form when they click the Show Flavors button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnSearchFlavors_Click(object sender, EventArgs e)
    {
      JellyBellyForm jbf = new JellyBellyForm(); //Creates a new instance of the form
      jbf.ShowDialog(); //Shows the form modally
    }

    /// <summary>
    /// Closes the form when they click on the close button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnClose_Click(object sender, EventArgs e)
    {
      Close(); //Closes the form
    }
  }
}
