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
  public partial class CategoryForm : Form
  {
    ProductEntityDb db = new ProductEntityDb();
    public CategoryForm()
    {
      InitializeComponent();
    }

    private void CategoryForm_Load(object sender, EventArgs e)
    {
      LstViewsCategories.Columns.Add("Category");
      LstViewsCategories.Columns.Add("Count");

      List<CatTotalViewModel> catTotals = (from cat in db.Products
                                          group cat.Category by cat.Category into cats
                                          select new CatTotalViewModel { ProdCategory = cats.Key, CatCount = cats.Count()}).ToList();

      //List<CatTotalViewModel> catTotalsLM = db.Products.GroupBy(cat => cat.Category).Select(cats => new CatTotalViewModel { ProdCategory = cats.Key, CatCount = cats.Count() }).ToList();

      LstViewsCategories.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
      LstViewsCategories.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize);

      foreach (CatTotalViewModel catTotal in catTotals)
      {
        string[] listitems = { catTotal.ProdCategory, catTotal.CatCount.ToString() };
        ListViewItem listViewItem = new ListViewItem(listitems);
        LstViewsCategories.Items.Add(listViewItem);
      }
    }
  }

  public class CatTotalViewModel
  {
    public string ProdCategory { get; set; }
    public int CatCount { get; set; }
  }
}
