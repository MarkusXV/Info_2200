namespace Assignment5_JellyBelly
{
  partial class JellyBellyForm
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
      this.GbSearch = new System.Windows.Forms.GroupBox();
      this.BtnSearch = new System.Windows.Forms.Button();
      this.BtnShowAll = new System.Windows.Forms.Button();
      this.TxtBoxSearch = new System.Windows.Forms.TextBox();
      this.BtnClose = new System.Windows.Forms.Button();
      this.DgvJellyBellies = new System.Windows.Forms.DataGridView();
      this.GbSearch.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DgvJellyBellies)).BeginInit();
      this.SuspendLayout();
      // 
      // GbSearch
      // 
      this.GbSearch.Controls.Add(this.TxtBoxSearch);
      this.GbSearch.Controls.Add(this.BtnShowAll);
      this.GbSearch.Controls.Add(this.BtnSearch);
      this.GbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.GbSearch.Location = new System.Drawing.Point(13, 408);
      this.GbSearch.Name = "GbSearch";
      this.GbSearch.Size = new System.Drawing.Size(485, 87);
      this.GbSearch.TabIndex = 1;
      this.GbSearch.TabStop = false;
      this.GbSearch.Text = "Search";
      // 
      // BtnSearch
      // 
      this.BtnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnSearch.Location = new System.Drawing.Point(306, 33);
      this.BtnSearch.Name = "BtnSearch";
      this.BtnSearch.Size = new System.Drawing.Size(83, 30);
      this.BtnSearch.TabIndex = 0;
      this.BtnSearch.Text = "Search";
      this.BtnSearch.UseVisualStyleBackColor = true;
      this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
      // 
      // BtnShowAll
      // 
      this.BtnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnShowAll.Location = new System.Drawing.Point(400, 33);
      this.BtnShowAll.Name = "BtnShowAll";
      this.BtnShowAll.Size = new System.Drawing.Size(72, 30);
      this.BtnShowAll.TabIndex = 1;
      this.BtnShowAll.Text = "All";
      this.BtnShowAll.UseVisualStyleBackColor = true;
      this.BtnShowAll.Click += new System.EventHandler(this.BtnShowAll_Click);
      // 
      // TxtBoxSearch
      // 
      this.TxtBoxSearch.Location = new System.Drawing.Point(14, 34);
      this.TxtBoxSearch.Name = "TxtBoxSearch";
      this.TxtBoxSearch.Size = new System.Drawing.Size(280, 26);
      this.TxtBoxSearch.TabIndex = 2;
      // 
      // BtnClose
      // 
      this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnClose.Location = new System.Drawing.Point(415, 509);
      this.BtnClose.Name = "BtnClose";
      this.BtnClose.Size = new System.Drawing.Size(83, 30);
      this.BtnClose.TabIndex = 3;
      this.BtnClose.Text = "Close";
      this.BtnClose.UseVisualStyleBackColor = true;
      this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
      // 
      // DgvJellyBellies
      // 
      this.DgvJellyBellies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.DgvJellyBellies.Location = new System.Drawing.Point(12, 12);
      this.DgvJellyBellies.Name = "DgvJellyBellies";
      this.DgvJellyBellies.Size = new System.Drawing.Size(486, 390);
      this.DgvJellyBellies.TabIndex = 4;
      // 
      // JellyBellyForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(510, 551);
      this.Controls.Add(this.DgvJellyBellies);
      this.Controls.Add(this.BtnClose);
      this.Controls.Add(this.GbSearch);
      this.Name = "JellyBellyForm";
      this.Text = "JellyBellyForm";
      this.Load += new System.EventHandler(this.JellyBellyForm_Load);
      this.GbSearch.ResumeLayout(false);
      this.GbSearch.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.DgvJellyBellies)).EndInit();
      this.ResumeLayout(false);

    }

        #endregion
    private System.Windows.Forms.GroupBox GbSearch;
    private System.Windows.Forms.TextBox TxtBoxSearch;
    private System.Windows.Forms.Button BtnShowAll;
    private System.Windows.Forms.Button BtnSearch;
    private System.Windows.Forms.Button BtnClose;
    private System.Windows.Forms.DataGridView DgvJellyBellies;
  }
}