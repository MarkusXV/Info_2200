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
      this.GbRequest = new System.Windows.Forms.GroupBox();
      this.GbResponse = new System.Windows.Forms.GroupBox();
      this.LblMessage = new System.Windows.Forms.Label();
      this.TxtBoxRequest = new System.Windows.Forms.TextBox();
      this.BtnSubmit = new System.Windows.Forms.Button();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.GbRequest.SuspendLayout();
      this.GbResponse.SuspendLayout();
      this.SuspendLayout();
      // 
      // GbRequest
      // 
      this.GbRequest.Controls.Add(this.BtnSubmit);
      this.GbRequest.Controls.Add(this.TxtBoxRequest);
      this.GbRequest.Controls.Add(this.LblMessage);
      this.GbRequest.Location = new System.Drawing.Point(13, 13);
      this.GbRequest.Name = "GbRequest";
      this.GbRequest.Size = new System.Drawing.Size(991, 215);
      this.GbRequest.TabIndex = 0;
      this.GbRequest.TabStop = false;
      this.GbRequest.Text = "Request";
      // 
      // GbResponse
      // 
      this.GbResponse.Controls.Add(this.textBox2);
      this.GbResponse.Location = new System.Drawing.Point(12, 234);
      this.GbResponse.Name = "GbResponse";
      this.GbResponse.Size = new System.Drawing.Size(992, 510);
      this.GbResponse.TabIndex = 1;
      this.GbResponse.TabStop = false;
      this.GbResponse.Text = "Response";
      // 
      // LblMessage
      // 
      this.LblMessage.AutoSize = true;
      this.LblMessage.Location = new System.Drawing.Point(28, 57);
      this.LblMessage.Name = "LblMessage";
      this.LblMessage.Size = new System.Drawing.Size(807, 42);
      this.LblMessage.TabIndex = 0;
      this.LblMessage.Text = "Message The Server (UVUFact or UVUMajor):  ";
      // 
      // TxtBoxRequest
      // 
      this.TxtBoxRequest.Location = new System.Drawing.Point(32, 123);
      this.TxtBoxRequest.Name = "TxtBoxRequest";
      this.TxtBoxRequest.Size = new System.Drawing.Size(689, 49);
      this.TxtBoxRequest.TabIndex = 1;
      // 
      // BtnSubmit
      // 
      this.BtnSubmit.Location = new System.Drawing.Point(763, 123);
      this.BtnSubmit.Name = "BtnSubmit";
      this.BtnSubmit.Size = new System.Drawing.Size(193, 49);
      this.BtnSubmit.TabIndex = 2;
      this.BtnSubmit.Text = "Submit";
      this.BtnSubmit.UseVisualStyleBackColor = true;
      // 
      // textBox2
      // 
      this.textBox2.Location = new System.Drawing.Point(33, 72);
      this.textBox2.Multiline = true;
      this.textBox2.Name = "textBox2";
      this.textBox2.Size = new System.Drawing.Size(924, 412);
      this.textBox2.TabIndex = 0;
      // 
      // ClientForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 42F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1016, 756);
      this.Controls.Add(this.GbResponse);
      this.Controls.Add(this.GbRequest);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
      this.Name = "ClientForm";
      this.Text = "Peter\'s UVU Server";
      this.GbRequest.ResumeLayout(false);
      this.GbRequest.PerformLayout();
      this.GbResponse.ResumeLayout(false);
      this.GbResponse.PerformLayout();
      this.ResumeLayout(false);

    }

        #endregion

        private System.Windows.Forms.GroupBox GbRequest;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.TextBox TxtBoxRequest;
        private System.Windows.Forms.Label LblMessage;
        private System.Windows.Forms.GroupBox GbResponse;
        private System.Windows.Forms.TextBox textBox2;
    }
}

