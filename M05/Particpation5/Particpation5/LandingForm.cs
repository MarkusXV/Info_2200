using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Particpation5
{
  public partial class LandingForm : Form
  {
    public LandingForm()
    {
      InitializeComponent();
    }

    private void BtnPoductSearch_Click(object sender, EventArgs e)
    {
      ProductSearchForm psf = new ProductSearchForm();
      psf.ShowDialog();
    }

    private void BtnGroupCategory_Click(object sender, EventArgs e)
    {
      CategoryForm cf = new CategoryForm();
      cf.ShowDialog();
    }
  }
}
