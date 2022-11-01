namespace Particpation5
{
  partial class ProductSearchForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.DgvProducts = new System.Windows.Forms.DataGridView();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.TxtBoxDescription = new System.Windows.Forms.TextBox();
      this.CbProductIds = new System.Windows.Forms.ComboBox();
      this.BtnAddProduct = new System.Windows.Forms.Button();
      this.BtnDelete = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).BeginInit();
      this.SuspendLayout();
      // 
      // DgvProducts
      // 
      this.DgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DgvProducts.Location = new System.Drawing.Point(12, 12);
      this.DgvProducts.Name = "DgvProducts";
      this.DgvProducts.Size = new System.Drawing.Size(736, 257);
      this.DgvProducts.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(19, 286);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(206, 25);
      this.label1.TabIndex = 1;
      this.label1.Text = "Product Description:";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(341, 338);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(115, 25);
      this.label2.TabIndex = 1;
      this.label2.Text = "Product Id:";
      // 
      // TxtBoxDescription
      // 
      this.TxtBoxDescription.Location = new System.Drawing.Point(225, 283);
      this.TxtBoxDescription.Name = "TxtBoxDescription";
      this.TxtBoxDescription.Size = new System.Drawing.Size(358, 31);
      this.TxtBoxDescription.TabIndex = 2;
      this.TxtBoxDescription.TextChanged += new System.EventHandler(this.TxtBoxDescription_TextChanged);
      // 
      // CbProductIds
      // 
      this.CbProductIds.FormattingEnabled = true;
      this.CbProductIds.Location = new System.Drawing.Point(462, 335);
      this.CbProductIds.Name = "CbProductIds";
      this.CbProductIds.Size = new System.Drawing.Size(121, 33);
      this.CbProductIds.TabIndex = 3;
      // 
      // BtnAddProduct
      // 
      this.BtnAddProduct.Location = new System.Drawing.Point(589, 279);
      this.BtnAddProduct.Name = "BtnAddProduct";
      this.BtnAddProduct.Size = new System.Drawing.Size(159, 39);
      this.BtnAddProduct.TabIndex = 4;
      this.BtnAddProduct.Text = "Add Product";
      this.BtnAddProduct.UseVisualStyleBackColor = true;
      this.BtnAddProduct.Click += new System.EventHandler(this.BtnAddProduct_Click);
      // 
      // BtnDelete
      // 
      this.BtnDelete.Location = new System.Drawing.Point(589, 335);
      this.BtnDelete.Name = "BtnDelete";
      this.BtnDelete.Size = new System.Drawing.Size(159, 33);
      this.BtnDelete.TabIndex = 4;
      this.BtnDelete.Text = "Delete";
      this.BtnDelete.UseVisualStyleBackColor = true;
      this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
      // 
      // ProductSearchForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(760, 380);
      this.Controls.Add(this.BtnDelete);
      this.Controls.Add(this.BtnAddProduct);
      this.Controls.Add(this.CbProductIds);
      this.Controls.Add(this.TxtBoxDescription);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.DgvProducts);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "ProductSearchForm";
      this.Text = "Product Search Form";
      this.Load += new System.EventHandler(this.ProductSearchForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.DgvProducts)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.DataGridView DgvProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBoxDescription;
        private System.Windows.Forms.ComboBox CbProductIds;
        private System.Windows.Forms.Button BtnAddProduct;
        private System.Windows.Forms.Button BtnDelete;
    }
}