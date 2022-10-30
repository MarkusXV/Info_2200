namespace Participation4_PhoneDb
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
      this.BtnLoadLocal = new System.Windows.Forms.Button();
      this.BtnImported = new System.Windows.Forms.Button();
      this.BtnOnline = new System.Windows.Forms.Button();
      this.BtnClose = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // BtnLoadLocal
      // 
      this.BtnLoadLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnLoadLocal.Location = new System.Drawing.Point(6, 6);
      this.BtnLoadLocal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.BtnLoadLocal.Name = "BtnLoadLocal";
      this.BtnLoadLocal.Size = new System.Drawing.Size(278, 155);
      this.BtnLoadLocal.TabIndex = 0;
      this.BtnLoadLocal.Text = "Load Phone Numbers";
      this.BtnLoadLocal.UseVisualStyleBackColor = true;
      this.BtnLoadLocal.Click += new System.EventHandler(this.BtnLoadLocal_Click);
      // 
      // BtnImported
      // 
      this.BtnImported.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnImported.Location = new System.Drawing.Point(294, 6);
      this.BtnImported.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.BtnImported.Name = "BtnImported";
      this.BtnImported.Size = new System.Drawing.Size(280, 155);
      this.BtnImported.TabIndex = 1;
      this.BtnImported.Text = "Imported Phone Numbers";
      this.BtnImported.UseVisualStyleBackColor = true;
      this.BtnImported.Click += new System.EventHandler(this.BtnImported_Click);
      // 
      // BtnOnline
      // 
      this.BtnOnline.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnOnline.Location = new System.Drawing.Point(6, 171);
      this.BtnOnline.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.BtnOnline.Name = "BtnOnline";
      this.BtnOnline.Size = new System.Drawing.Size(278, 152);
      this.BtnOnline.TabIndex = 2;
      this.BtnOnline.Text = "Online Phone Numbers";
      this.BtnOnline.UseVisualStyleBackColor = true;
      this.BtnOnline.Click += new System.EventHandler(this.BtnOnline_Click);
      // 
      // BtnClose
      // 
      this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnClose.Location = new System.Drawing.Point(294, 171);
      this.BtnClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.BtnClose.Name = "BtnClose";
      this.BtnClose.Size = new System.Drawing.Size(280, 152);
      this.BtnClose.TabIndex = 3;
      this.BtnClose.Text = "Close";
      this.BtnClose.UseVisualStyleBackColor = true;
      this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
      // 
      // LandingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(579, 329);
      this.Controls.Add(this.BtnClose);
      this.Controls.Add(this.BtnOnline);
      this.Controls.Add(this.BtnImported);
      this.Controls.Add(this.BtnLoadLocal);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "LandingForm";
      this.Text = "Peter\'s Landing Form";
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.Button BtnLoadLocal;
        private System.Windows.Forms.Button BtnImported;
        private System.Windows.Forms.Button BtnOnline;
        private System.Windows.Forms.Button BtnClose;
    }
}

