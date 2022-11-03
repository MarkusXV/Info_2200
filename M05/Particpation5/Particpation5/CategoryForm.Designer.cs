namespace Particpation5
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
      this.LstViewsCategories = new System.Windows.Forms.ListView();
      this.SuspendLayout();
      // 
      // LstViewsCategories
      // 
      this.LstViewsCategories.HideSelection = false;
      this.LstViewsCategories.Location = new System.Drawing.Point(12, 12);
      this.LstViewsCategories.Name = "LstViewsCategories";
      this.LstViewsCategories.Size = new System.Drawing.Size(946, 737);
      this.LstViewsCategories.TabIndex = 0;
      this.LstViewsCategories.UseCompatibleStateImageBehavior = false;
      this.LstViewsCategories.View = System.Windows.Forms.View.Details;
      // 
      // CategoryForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 44F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(970, 761);
      this.Controls.Add(this.LstViewsCategories);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "CategoryForm";
      this.Text = "CategoryForm";
      this.Load += new System.EventHandler(this.CategoryForm_Load);
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.ListView LstViewsCategories;
    }
}