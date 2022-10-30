namespace Participation4_PhoneDb
{
  partial class UVUTotalsForm
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UVUTotalsForm));
      this.iNFO2200_CrandallSayDataSet1 = new Participation4_PhoneDb.INFO2200_CrandallSayDataSet1();
      this.uVUPhoneNumbersSPBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.uVUPhoneNumbersSPTableAdapter = new Participation4_PhoneDb.INFO2200_CrandallSayDataSet1TableAdapters.UVUPhoneNumbersSPTableAdapter();
      this.tableAdapterManager = new Participation4_PhoneDb.INFO2200_CrandallSayDataSet1TableAdapters.TableAdapterManager();
      this.uVUPhoneNumbersSPBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.uVUPhoneNumbersSPBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.uVUPhoneNumbersSPDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumbersSPBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumbersSPBindingNavigator)).BeginInit();
      this.uVUPhoneNumbersSPBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumbersSPDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // iNFO2200_CrandallSayDataSet1
      // 
      this.iNFO2200_CrandallSayDataSet1.DataSetName = "INFO2200_CrandallSayDataSet1";
      this.iNFO2200_CrandallSayDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // uVUPhoneNumbersSPBindingSource
      // 
      this.uVUPhoneNumbersSPBindingSource.DataMember = "UVUPhoneNumbersSP";
      this.uVUPhoneNumbersSPBindingSource.DataSource = this.iNFO2200_CrandallSayDataSet1;
      // 
      // uVUPhoneNumbersSPTableAdapter
      // 
      this.uVUPhoneNumbersSPTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.Connection = null;
      this.tableAdapterManager.UpdateOrder = Participation4_PhoneDb.INFO2200_CrandallSayDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // uVUPhoneNumbersSPBindingNavigator
      // 
      this.uVUPhoneNumbersSPBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.uVUPhoneNumbersSPBindingNavigator.BindingSource = this.uVUPhoneNumbersSPBindingSource;
      this.uVUPhoneNumbersSPBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.uVUPhoneNumbersSPBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.uVUPhoneNumbersSPBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
      this.uVUPhoneNumbersSPBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.uVUPhoneNumbersSPBindingNavigatorSaveItem});
      this.uVUPhoneNumbersSPBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.uVUPhoneNumbersSPBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.uVUPhoneNumbersSPBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.uVUPhoneNumbersSPBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.uVUPhoneNumbersSPBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.uVUPhoneNumbersSPBindingNavigator.Name = "uVUPhoneNumbersSPBindingNavigator";
      this.uVUPhoneNumbersSPBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.uVUPhoneNumbersSPBindingNavigator.Size = new System.Drawing.Size(800, 42);
      this.uVUPhoneNumbersSPBindingNavigator.TabIndex = 0;
      this.uVUPhoneNumbersSPBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 19);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 6);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 32);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // uVUPhoneNumbersSPBindingNavigatorSaveItem
      // 
      this.uVUPhoneNumbersSPBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.uVUPhoneNumbersSPBindingNavigatorSaveItem.Enabled = false;
      this.uVUPhoneNumbersSPBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("uVUPhoneNumbersSPBindingNavigatorSaveItem.Image")));
      this.uVUPhoneNumbersSPBindingNavigatorSaveItem.Name = "uVUPhoneNumbersSPBindingNavigatorSaveItem";
      this.uVUPhoneNumbersSPBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
      this.uVUPhoneNumbersSPBindingNavigatorSaveItem.Text = "Save Data";
      // 
      // uVUPhoneNumbersSPDataGridView
      // 
      this.uVUPhoneNumbersSPDataGridView.AutoGenerateColumns = false;
      this.uVUPhoneNumbersSPDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.uVUPhoneNumbersSPDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      this.uVUPhoneNumbersSPDataGridView.DataSource = this.uVUPhoneNumbersSPBindingSource;
      this.uVUPhoneNumbersSPDataGridView.Location = new System.Drawing.Point(12, 60);
      this.uVUPhoneNumbersSPDataGridView.Name = "uVUPhoneNumbersSPDataGridView";
      this.uVUPhoneNumbersSPDataGridView.RowHeadersWidth = 82;
      this.uVUPhoneNumbersSPDataGridView.RowTemplate.Height = 33;
      this.uVUPhoneNumbersSPDataGridView.Size = new System.Drawing.Size(776, 574);
      this.uVUPhoneNumbersSPDataGridView.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn1.DataPropertyName = "Dept";
      this.dataGridViewTextBoxColumn1.HeaderText = "Dept";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn2.DataPropertyName = "Department";
      this.dataGridViewTextBoxColumn2.HeaderText = "Department";
      this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // UVUTotalsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 646);
      this.Controls.Add(this.uVUPhoneNumbersSPDataGridView);
      this.Controls.Add(this.uVUPhoneNumbersSPBindingNavigator);
      this.Name = "UVUTotalsForm";
      this.Text = "UVUTotalsForm";
      this.Load += new System.EventHandler(this.UVUTotalsForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumbersSPBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumbersSPBindingNavigator)).EndInit();
      this.uVUPhoneNumbersSPBindingNavigator.ResumeLayout(false);
      this.uVUPhoneNumbersSPBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.uVUPhoneNumbersSPDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private INFO2200_CrandallSayDataSet1 iNFO2200_CrandallSayDataSet1;
        private System.Windows.Forms.BindingSource uVUPhoneNumbersSPBindingSource;
        private INFO2200_CrandallSayDataSet1TableAdapters.UVUPhoneNumbersSPTableAdapter uVUPhoneNumbersSPTableAdapter;
        private INFO2200_CrandallSayDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator uVUPhoneNumbersSPBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton uVUPhoneNumbersSPBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView uVUPhoneNumbersSPDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}