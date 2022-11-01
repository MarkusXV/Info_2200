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
  public partial class ProductSearchForm : Form
  {
    ProductEntityDb db = new ProductEntityDb();

    public ProductSearchForm()
    {
      InitializeComponent();
    }

    private void BtnAddProduct_Click(object sender, EventArgs e)
    {

    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {
      if (CbProductIds.SelectedIndex > -1)
      {
        Product foundProduct = db.Products.FirstOrDefault(p => p.Product_Number == CbProductIds.SelectedItem.ToString());
        if (foundProduct != null)
        {
          db.Products.Remove(foundProduct);
          db.SaveChanges();
          UpdateTableData();
        }
        else
        {
          MessageBox.Show($"Couldn't find {CbProductIds.SelectedItem} in the database.", "Unable to find product");
        }
      }
      else
      {
        MessageBox.Show("Please select a product number", "Unable to delete");
      }
    }

    private void TxtBoxDescription_TextChanged(object sender, EventArgs e)
    {
      //List<Product> filteredProducts = (from prod in db.Products
      //                                  where prod.Description.Contains(TxtBoxDescription.Text)
      //                                  select prod).ToList();
      List<Product> fltrdProducts = db.Products.Where(prod => prod.Description.Contains(TxtBoxDescription.Text)).ToList();

      DgvProducts.DataSource = fltrdProducts;
    }

    private void ProductSearchForm_Load(object sender, EventArgs e)
    {
      UpdateTableData();

    }

    private void UpdateTableData()
    {
      //List<Product> allProducts = db.Products.ToList(); // Linq method
      List<Product> products = (from prod in db.Products
                                select prod).ToList();

      DgvProducts.DataSource = products;

      for (int i = 0; i < DgvProducts.Columns.Count; i++)
      {
        DgvProducts.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      }

      CbProductIds.Items.Clear();
      CbProductIds.Items.AddRange(products.Select(prod => prod.Product_Number).ToArray());
    }
  }
}
