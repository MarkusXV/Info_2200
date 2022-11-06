namespace Assignment5_JellyBelly
{
  partial class CategoryForm
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
      this.lvCategory = new System.Windows.Forms.ListView();
      this.BtnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lvCategory
      // 
      this.lvCategory.HideSelection = false;
      this.lvCategory.Location = new System.Drawing.Point(13, 13);
      this.lvCategory.Name = "lvCategory";
      this.lvCategory.Size = new System.Drawing.Size(406, 446);
      this.lvCategory.TabIndex = 0;
      this.lvCategory.UseCompatibleStateImageBehavior = false;
      this.lvCategory.View = System.Windows.Forms.View.Details;
      // 
      // BtnClose
      // 
      this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnClose.Location = new System.Drawing.Point(330, 475);
      this.BtnClose.Name = "BtnClose";
      this.BtnClose.Size = new System.Drawing.Size(89, 35);
      this.BtnClose.TabIndex = 1;
      this.BtnClose.Text = "Close";
      this.BtnClose.UseVisualStyleBackColor = true;
      this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
      // 
      // CategoryForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(431, 522);
      this.Controls.Add(this.BtnClose);
      this.Controls.Add(this.lvCategory);
      this.Name = "CategoryForm";
      this.Text = "Categories";
      this.Load += new System.EventHandler(this.CategoryForm_Load);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.ListView lvCategory;
        private System.Windows.Forms.Button BtnClose;
    }
}