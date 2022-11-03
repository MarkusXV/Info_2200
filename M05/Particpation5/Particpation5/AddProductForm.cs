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
  public partial class AddProductForm : Form
  {
    ProductEntityDb db = new ProductEntityDb();
    public AddProductForm()
    {
      InitializeComponent();

    }

    private void BtnAdd_Click(object sender, EventArgs e)
    {
      if (TxtBoxProductNumber.Text != null &&
        TxtBoxDescription.Text != null &&
        decimal.TryParse(TxtBoxPrice.Text, out decimal price) &&
        int.TryParse(TxtBoxUoH.Text, out int uon) &&
        CbCategory.SelectedIndex > -1)
      {
        Product newProduct = new Product
        {
          Product_Number = TxtBoxProductNumber.Text,
          Description = TxtBoxDescription.Text,
          Price = price,
          Units_On_Hand = uon,
          Category = CbCategory.SelectedIndex == -1 ? TxtBoxNewCategory.Text : CbCategory.SelectedItem.ToString()
        };
        db.Products.Add(newProduct);
        db.SaveChanges();
        MessageBox.Show($"{newProduct.Description} was just added to the database.");

        Close();
        
      }
      else
      {
        MessageBox.Show("Please enter values for all fields");
      }
    }


    private void BtnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (CbCategory.SelectedIndex == 0)
      {
        LblNew.Show();
        TxtBoxNewCategory.Show();
      }
      else
      {
        LblNew.Hide();
        TxtBoxNewCategory.Hide();
      }
    }

    private void AddProductForm_Load(object sender, EventArgs e)
    {
      LblNew.Hide();
      TxtBoxNewCategory.Hide();

      CbCategory.Items.Add("New Category");
      var catItems = (from cat in db.Products
                      where cat.Category != null
                      group cat.Category by cat.Category into c
                      select new { Category = c.Key });
      //var catItems = db.Products.Where(cat => cat.Category != null).GroupBy(cat => cat.Category);
      

      CbCategory.Items.AddRange(catItems.Select(cats => cats.Category).ToArray());
    }

  }
}
