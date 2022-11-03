namespace Particpation5
{
  partial class LandingForm
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
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.BtnPoductSearch = new System.Windows.Forms.Button();
      this.BtnGroupCategory = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Particpation5.Properties.Resources.before;
      this.pictureBox1.Location = new System.Drawing.Point(-215, -44);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(1008, 731);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // BtnPoductSearch
      // 
      this.BtnPoductSearch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.BtnPoductSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
      this.BtnPoductSearch.Location = new System.Drawing.Point(12, 347);
      this.BtnPoductSearch.Name = "BtnPoductSearch";
      this.BtnPoductSearch.Size = new System.Drawing.Size(228, 90);
      this.BtnPoductSearch.TabIndex = 1;
      this.BtnPoductSearch.Text = "Product Search";
      this.BtnPoductSearch.UseVisualStyleBackColor = false;
      this.BtnPoductSearch.Click += new System.EventHandler(this.BtnPoductSearch_Click);
      // 
      // BtnGroupCategory
      // 
      this.BtnGroupCategory.Location = new System.Drawing.Point(341, 347);
      this.BtnGroupCategory.Name = "BtnGroupCategory";
      this.BtnGroupCategory.Size = new System.Drawing.Size(228, 90);
      this.BtnGroupCategory.TabIndex = 1;
      this.BtnGroupCategory.Text = "Group By Category";
      this.BtnGroupCategory.UseVisualStyleBackColor = true;
      this.BtnGroupCategory.Click += new System.EventHandler(this.BtnGroupCategory_Click);
      // 
      // LandingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(581, 471);
      this.Controls.Add(this.BtnGroupCategory);
      this.Controls.Add(this.BtnPoductSearch);
      this.Controls.Add(this.pictureBox1);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6);
      this.Name = "LandingForm";
      this.Text = "Peter\'s Clothes";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnPoductSearch;
        private System.Windows.Forms.Button BtnGroupCategory;
    }
}

