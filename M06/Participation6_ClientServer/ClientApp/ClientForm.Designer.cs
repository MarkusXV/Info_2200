namespace ClientApp
{
  partial class ClientForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
      this.GbRequest = new System.Windows.Forms.GroupBox();
      this.LblMessage = new System.Windows.Forms.Label();
      this.BtnSubmit = new System.Windows.Forms.Button();
      this.TxtBoxRequest = new System.Windows.Forms.TextBox();
      this.GbResponse = new System.Windows.Forms.GroupBox();
      this.TxtBoxResults = new System.Windows.Forms.TextBox();
      this.GbRequest.SuspendLayout();
      this.GbResponse.SuspendLayout();
      this.SuspendLayout();
      // 
      // GbRequest
      // 
      this.GbRequest.Controls.Add(this.LblMessage);
      this.GbRequest.Controls.Add(this.BtnSubmit);
      this.GbRequest.Controls.Add(this.TxtBoxRequest);
      this.GbRequest.Location = new System.Drawing.Point(13, 15);
      this.GbRequest.Margin = new System.Windows.Forms.Padding(4);
      this.GbRequest.Name = "GbRequest";
      this.GbRequest.Padding = new System.Windows.Forms.Padding(4);
      this.GbRequest.Size = new System.Drawing.Size(1030, 144);
      this.GbRequest.TabIndex = 0;
      this.GbRequest.TabStop = false;
      this.GbRequest.Text = "Request";
      // 
      // LblMessage
      // 
      this.LblMessage.AutoSize = true;
      this.LblMessage.Location = new System.Drawing.Point(23, 39);
      this.LblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.LblMessage.Name = "LblMessage";
      this.LblMessage.Size = new System.Drawing.Size(720, 42);
      this.LblMessage.TabIndex = 2;
      this.LblMessage.Text = "Message The Server (Conspiracy or joke):";
      // 
      // BtnSubmit
      // 
      this.BtnSubmit.Location = new System.Drawing.Point(788, 81);
      this.BtnSubmit.Margin = new System.Windows.Forms.Padding(4);
      this.BtnSubmit.Name = "BtnSubmit";
      this.BtnSubmit.Size = new System.Drawing.Size(211, 49);
      this.BtnSubmit.TabIndex = 1;
      this.BtnSubmit.Text = "Submit";
      this.BtnSubmit.UseVisualStyleBackColor = true;
      this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
      // 
      // TxtBoxRequest
      // 
      this.TxtBoxRequest.Location = new System.Drawing.Point(27, 81);
      this.TxtBoxRequest.Margin = new System.Windows.Forms.Padding(4);
      this.TxtBoxRequest.Name = "TxtBoxRequest";
      this.TxtBoxRequest.Size = new System.Drawing.Size(716, 49);
      this.TxtBoxRequest.TabIndex = 0;
      // 
      // GbResponse
      // 
      this.GbResponse.Controls.Add(this.TxtBoxResults);
      this.GbResponse.Location = new System.Drawing.Point(13, 167);
      this.GbResponse.Margin = new System.Windows.Forms.Padding(4);
      this.GbResponse.Name = "GbResponse";
      this.GbResponse.Padding = new System.Windows.Forms.Padding(4);
      this.GbResponse.Size = new System.Drawing.Size(1030, 565);
      this.GbResponse.TabIndex = 1;
      this.GbResponse.TabStop = false;
      this.GbResponse.Text = "Response";
      // 
      // TxtBoxResults
      // 
      this.TxtBoxResults.Location = new System.Drawing.Point(27, 45);
      this.TxtBoxResults.Margin = new System.Windows.Forms.Padding(4);
      this.TxtBoxResults.Multiline = true;
      this.TxtBoxResults.Name = "TxtBoxResults";
      this.TxtBoxResults.ReadOnly = true;
      this.TxtBoxResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.TxtBoxResults.Size = new System.Drawing.Size(995, 512);
      this.TxtBoxResults.TabIndex = 0;
      // 
      // ClientForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1056, 745);
      this.Controls.Add(this.GbResponse);
      this.Controls.Add(this.GbRequest);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "ClientForm";
      this.Text = "Ask the Server";
      this.Load += new System.EventHandler(this.ClientForm_Load);
      this.GbRequest.ResumeLayout(false);
      this.GbRequest.PerformLayout();
      this.GbResponse.ResumeLayout(false);
      this.GbResponse.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.GroupBox GbRequest;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.TextBox TxtBoxRequest;
        private System.Windows.Forms.GroupBox GbResponse;
        private System.Windows.Forms.TextBox TxtBoxResults;
    }
}

