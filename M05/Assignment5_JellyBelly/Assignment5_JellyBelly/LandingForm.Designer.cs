namespace Assignment5_JellyBelly
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
      this.BtnSearchFlavors = new System.Windows.Forms.Button();
      this.BtnShowFlavors = new System.Windows.Forms.Button();
      this.BtnClose = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::Assignment5_JellyBelly.Properties.Resources.Jelly_Belly_Logo_svg;
      this.pictureBox1.ImageLocation = "D:\\Github\\Info_2200\\M05\\Assignment5_JellyBelly\\Assignment5_JellyBelly\\Pictures\\do" +
    "wnload.jpg";
      this.pictureBox1.Location = new System.Drawing.Point(13, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(624, 349);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 0;
      this.pictureBox1.TabStop = false;
      // 
      // BtnSearchFlavors
      // 
      this.BtnSearchFlavors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnSearchFlavors.Location = new System.Drawing.Point(45, 389);
      this.BtnSearchFlavors.Name = "BtnSearchFlavors";
      this.BtnSearchFlavors.Size = new System.Drawing.Size(256, 53);
      this.BtnSearchFlavors.TabIndex = 1;
      this.BtnSearchFlavors.Text = "Search Jelly Belly Flavors";
      this.BtnSearchFlavors.UseVisualStyleBackColor = true;
      this.BtnSearchFlavors.Click += new System.EventHandler(this.BtnSearchFlavors_Click);
      // 
      // BtnShowFlavors
      // 
      this.BtnShowFlavors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnShowFlavors.Location = new System.Drawing.Point(353, 389);
      this.BtnShowFlavors.Name = "BtnShowFlavors";
      this.BtnShowFlavors.Size = new System.Drawing.Size(256, 53);
      this.BtnShowFlavors.TabIndex = 2;
      this.BtnShowFlavors.Text = "Show Flavor Categories";
      this.BtnShowFlavors.UseVisualStyleBackColor = true;
      this.BtnShowFlavors.Click += new System.EventHandler(this.BtnShowFlavors_Click);
      // 
      // BtnClose
      // 
      this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnClose.Location = new System.Drawing.Point(478, 471);
      this.BtnClose.Name = "BtnClose";
      this.BtnClose.Size = new System.Drawing.Size(131, 40);
      this.BtnClose.TabIndex = 3;
      this.BtnClose.Text = "Close";
      this.BtnClose.UseVisualStyleBackColor = true;
      this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
      // 
      // LandingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(649, 538);
      this.Controls.Add(this.BtnClose);
      this.Controls.Add(this.BtnShowFlavors);
      this.Controls.Add(this.BtnSearchFlavors);
      this.Controls.Add(this.pictureBox1);
      this.Name = "LandingForm";
      this.Text = "Peter\'s JellyBelly Central";
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSearchFlavors;
        private System.Windows.Forms.Button BtnShowFlavors;
        private System.Windows.Forms.Button BtnClose;
    }
}

