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
    JellyBellyEntityDb db = new JellyBellyEntityDb();
    public JellyBellyForm()
    {
      InitializeComponent();
    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {
      List<JellyBelly> filteredJelly = db.JellyBellies.Where(jell => jell.jellyBellyFlavor.Contains(TxtBoxSearch.Text)).ToList();

      DgvJellyBellies.DataSource = filteredJelly;
    }

    private void BtnShowAll_Click(object sender, EventArgs e)
    {
      UpdateTableData();
      TxtBoxSearch.Text = "";
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void JellyBellyForm_Load(object sender, EventArgs e)
    {
      UpdateTableData();
    }

    private void UpdateTableData()
    {
      //List<JellyBelly> jellybellies = (from jell in db.JellyBellies select jell).ToList();
      List<JellyBelly> jellybellies = db.JellyBellies.ToList();

      DgvJellyBellies.DataSource = jellybellies;

      for (int i = 0; i < DgvJellyBellies.Columns.Count; i++)
      {
        DgvJellyBellies.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      }

    }
  }
}
