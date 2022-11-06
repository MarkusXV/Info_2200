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
      InitializeComponent();
    }

    private void BtnShowFlavors_Click(object sender, EventArgs e)
    {
      CategoryForm cf = new CategoryForm();
      cf.ShowDialog();
    }

    private void BtnSearchFlavors_Click(object sender, EventArgs e)
    {
      JellyBellyForm jbf = new JellyBellyForm();
      jbf.ShowDialog();
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
