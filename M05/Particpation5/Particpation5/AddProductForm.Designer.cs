﻿namespace Particpation5
{
  partial class AddProductForm
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.LblNew = new System.Windows.Forms.Label();
      this.BtnAdd = new System.Windows.Forms.Button();
      this.BtnCancel = new System.Windows.Forms.Button();
      this.TxtBoxProductNumber = new System.Windows.Forms.TextBox();
      this.TxtBoxDescription = new System.Windows.Forms.TextBox();
      this.TxtBoxUoH = new System.Windows.Forms.TextBox();
      this.TxtBoxPrice = new System.Windows.Forms.TextBox();
      this.TxtBoxNewCategory = new System.Windows.Forms.TextBox();
      this.CbCategory = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 14);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(323, 48);
      this.label1.TabIndex = 0;
      this.label1.Text = "Product Number";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(59, 72);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(230, 48);
      this.label2.TabIndex = 0;
      this.label2.Text = "Description";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(31, 130);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(283, 48);
      this.label3.TabIndex = 0;
      this.label3.Text = "Units on Hand";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(118, 188);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(116, 48);
      this.label4.TabIndex = 0;
      this.label4.Text = "Price";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(80, 246);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(189, 48);
      this.label5.TabIndex = 0;
      this.label5.Text = "Category";
      // 
      // LblNew
      // 
      this.LblNew.AutoSize = true;
      this.LblNew.Location = new System.Drawing.Point(408, 252);
      this.LblNew.Name = "LblNew";
      this.LblNew.Size = new System.Drawing.Size(103, 48);
      this.LblNew.TabIndex = 0;
      this.LblNew.Text = "New";
      // 
      // BtnAdd
      // 
      this.BtnAdd.Location = new System.Drawing.Point(185, 319);
      this.BtnAdd.Name = "BtnAdd";
      this.BtnAdd.Size = new System.Drawing.Size(361, 59);
      this.BtnAdd.TabIndex = 1;
      this.BtnAdd.Text = "Add";
      this.BtnAdd.UseVisualStyleBackColor = true;
      this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
      // 
      // BtnCancel
      // 
      this.BtnCancel.Location = new System.Drawing.Point(480, 384);
      this.BtnCancel.Name = "BtnCancel";
      this.BtnCancel.Size = new System.Drawing.Size(198, 58);
      this.BtnCancel.TabIndex = 1;
      this.BtnCancel.Text = "Cancel";
      this.BtnCancel.UseVisualStyleBackColor = true;
      this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
      // 
      // TxtBoxProductNumber
      // 
      this.TxtBoxProductNumber.Location = new System.Drawing.Point(341, 7);
      this.TxtBoxProductNumber.Name = "TxtBoxProductNumber";
      this.TxtBoxProductNumber.Size = new System.Drawing.Size(353, 55);
      this.TxtBoxProductNumber.TabIndex = 2;
      // 
      // TxtBoxDescription
      // 
      this.TxtBoxDescription.Location = new System.Drawing.Point(341, 68);
      this.TxtBoxDescription.Name = "TxtBoxDescription";
      this.TxtBoxDescription.Size = new System.Drawing.Size(353, 55);
      this.TxtBoxDescription.TabIndex = 2;
      // 
      // TxtBoxUoH
      // 
      this.TxtBoxUoH.Location = new System.Drawing.Point(341, 129);
      this.TxtBoxUoH.Name = "TxtBoxUoH";
      this.TxtBoxUoH.Size = new System.Drawing.Size(353, 55);
      this.TxtBoxUoH.TabIndex = 2;
      // 
      // TxtBoxPrice
      // 
      this.TxtBoxPrice.Location = new System.Drawing.Point(341, 188);
      this.TxtBoxPrice.Name = "TxtBoxPrice";
      this.TxtBoxPrice.Size = new System.Drawing.Size(353, 55);
      this.TxtBoxPrice.TabIndex = 2;
      // 
      // TxtBoxNewCategory
      // 
      this.TxtBoxNewCategory.Location = new System.Drawing.Point(605, 249);
      this.TxtBoxNewCategory.Name = "TxtBoxNewCategory";
      this.TxtBoxNewCategory.Size = new System.Drawing.Size(153, 55);
      this.TxtBoxNewCategory.TabIndex = 2;
      // 
      // CbCategory
      // 
      this.CbCategory.FormattingEnabled = true;
      this.CbCategory.Location = new System.Drawing.Point(275, 246);
      this.CbCategory.Name = "CbCategory";
      this.CbCategory.Size = new System.Drawing.Size(121, 56);
      this.CbCategory.TabIndex = 3;
      this.CbCategory.SelectedIndexChanged += new System.EventHandler(this.CbCategory_SelectedIndexChanged);
      // 
      // AddProductForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(24F, 48F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(903, 498);
      this.Controls.Add(this.CbCategory);
      this.Controls.Add(this.TxtBoxNewCategory);
      this.Controls.Add(this.TxtBoxPrice);
      this.Controls.Add(this.TxtBoxUoH);
      this.Controls.Add(this.TxtBoxDescription);
      this.Controls.Add(this.TxtBoxProductNumber);
      this.Controls.Add(this.BtnCancel);
      this.Controls.Add(this.BtnAdd);
      this.Controls.Add(this.LblNew);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "AddProductForm";
      this.Text = "Add Product Form";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblNew;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.TextBox TxtBoxProductNumber;
        private System.Windows.Forms.TextBox TxtBoxDescription;
        private System.Windows.Forms.TextBox TxtBoxUoH;
        private System.Windows.Forms.TextBox TxtBoxPrice;
        private System.Windows.Forms.TextBox TxtBoxNewCategory;
        private System.Windows.Forms.ComboBox CbCategory;
    }
}