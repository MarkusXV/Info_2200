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

  public partial class CategoryForm : Form
  {
    JellyBellyEntityDb db = new JellyBellyEntityDb();

    public CategoryForm()
    {
      InitializeComponent();
    }

    private void BtnClose_Click(object sender, EventArgs e)
    {
      Close();
    }

    internal class CategoryTotal
    {
      public string Category { get; set; }
      public int Total { get; set; }
    }

    private void CategoryForm_Load(object sender, EventArgs e)
    {
      lvCategory.Columns.Add("Category");
      lvCategory.Columns.Add("Count");


      var jbCat = db.JellyBellies.GroupBy(c => c.category).Select(
      cat => new CategoryTotal
      {
        Category = cat.Key,
        Total = cat.Count()
      });

      foreach (CategoryTotal ct in jbCat)
      {
        String[] listValues = { ct.Category, ct.Total.ToString() };
        ListViewItem lvi = new ListViewItem(listValues);
        lvCategory.Items.Add(lvi);
      }
      lvCategory.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
      lvCategory.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);

      //List<CategoryTotal> catTotals = (from j in db.JellyBellies
      //                                 group j by j.category into cats
      //                                 select new CategoryTotal { Category = cats.Key, Total = cats.Count() }).ToList();

      //foreach (CategoryTotal ct in catTotals)
      //{
      //  string[] listvalues = { ct.Category, ct.Total.ToString() };
      //  ListViewItem lvi = new ListViewItem(listvalues);
      //  lvCategory.Items.Add(lvi);
      //}

      //lvCategory.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
      //lvCategory.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);


    }
  }


}
