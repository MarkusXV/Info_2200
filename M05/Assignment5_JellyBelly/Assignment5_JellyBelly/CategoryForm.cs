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
    JellyBellyEntityDb db = new JellyBellyEntityDb(); //Imports the database data into the class

    public CategoryForm()
    {
      InitializeComponent(); //Initializes the components of the form
    }

    /// <summary>
    /// Closes the form when they click the close button
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void BtnClose_Click(object sender, EventArgs e)
    {
      Close(); //Closes the form
    }

    /// <summary>
    /// Internal Class for all of the Categories Properties (One instance for each category)
    /// </summary>
    internal class CategoryTotal
    {
      public string Category { get; set; } //Category property
      public int Total { get; set; } //Total property
    }

    /// <summary>
    /// Loads the list view with the categories and the totals for each category
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CategoryForm_Load(object sender, EventArgs e)
    {
      lvCategory.Columns.Add("Category"); //Adds the column Category to LV
      lvCategory.Columns.Add("Count"); //Adds the count column to LV


      var jbCat = db.JellyBellies.GroupBy(c => c.category).Select(
      cat => new CategoryTotal
      {
        Category = cat.Key,
        Total = cat.Count()
      }); //Creates new CategoryTotals for each category in the Database using the Category key and the count of that category

      foreach (CategoryTotal ct in jbCat) //Takes each CategoryTotal instance and puts it into the LV
      {
        String[] listValues = { ct.Category, ct.Total.ToString() }; //Creates a list with the format that we want
        ListViewItem lvi = new ListViewItem(listValues); //Creates a Listview item with the list
        lvCategory.Items.Add(lvi); //Adds the listview item to be displayed
      } 
      lvCategory.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent); //Auto sizes the first column to the column content
      lvCategory.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.HeaderSize); //Auto sizes the second column to the Header size

      ///Backup code that I created that does the same thing as the provided code
      
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
