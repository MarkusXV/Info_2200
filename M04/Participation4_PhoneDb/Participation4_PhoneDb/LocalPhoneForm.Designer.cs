namespace Participation4_PhoneDb
{
  partial class LocalPhoneForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalPhoneForm));
      this.phoneNumbersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.phoneNumbersBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.localPhoneDbDataSet = new Participation4_PhoneDb.LocalPhoneDbDataSet();
      this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
      this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
      this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
      this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.phoneNumbersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.phoneNumbersDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.TxtBoxFN = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.BtnSortLN = new System.Windows.Forms.Button();
      this.BtnAge30 = new System.Windows.Forms.Button();
      this.BtnAvAge = new System.Windows.Forms.Button();
      this.BtnClear = new System.Windows.Forms.Button();
      this.phoneNumbersTableAdapter = new Participation4_PhoneDb.LocalPhoneDbDataSetTableAdapters.PhoneNumbersTableAdapter();
      this.tableAdapterManager = new Participation4_PhoneDb.LocalPhoneDbDataSetTableAdapters.TableAdapterManager();
      ((System.ComponentModel.ISupportInitialize)(this.phoneNumbersBindingNavigator)).BeginInit();
      this.phoneNumbersBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.phoneNumbersBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneDbDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.phoneNumbersDataGridView)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // phoneNumbersBindingNavigator
      // 
      this.phoneNumbersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.phoneNumbersBindingNavigator.BindingSource = this.phoneNumbersBindingSource;
      this.phoneNumbersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.phoneNumbersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.phoneNumbersBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
      this.phoneNumbersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.phoneNumbersBindingNavigatorSaveItem});
      this.phoneNumbersBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.phoneNumbersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.phoneNumbersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.phoneNumbersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.phoneNumbersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.phoneNumbersBindingNavigator.Name = "phoneNumbersBindingNavigator";
      this.phoneNumbersBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
      this.phoneNumbersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.phoneNumbersBindingNavigator.Size = new System.Drawing.Size(607, 39);
      this.phoneNumbersBindingNavigator.TabIndex = 0;
      this.phoneNumbersBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(36, 36);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // phoneNumbersBindingSource
      // 
      this.phoneNumbersBindingSource.DataMember = "PhoneNumbers";
      this.phoneNumbersBindingSource.DataSource = this.localPhoneDbDataSet;
      // 
      // localPhoneDbDataSet
      // 
      this.localPhoneDbDataSet.DataSetName = "LocalPhoneDbDataSet";
      this.localPhoneDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 36);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(36, 36);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(36, 36);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(36, 36);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 39);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(27, 23);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 39);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(36, 36);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(36, 36);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 39);
      // 
      // phoneNumbersBindingNavigatorSaveItem
      // 
      this.phoneNumbersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.phoneNumbersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneNumbersBindingNavigatorSaveItem.Image")));
      this.phoneNumbersBindingNavigatorSaveItem.Name = "phoneNumbersBindingNavigatorSaveItem";
      this.phoneNumbersBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
      this.phoneNumbersBindingNavigatorSaveItem.Text = "Save Data";
      this.phoneNumbersBindingNavigatorSaveItem.Click += new System.EventHandler(this.phoneNumbersBindingNavigatorSaveItem_Click);
      // 
      // phoneNumbersDataGridView
      // 
      this.phoneNumbersDataGridView.AutoGenerateColumns = false;
      this.phoneNumbersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.phoneNumbersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
      this.phoneNumbersDataGridView.DataSource = this.phoneNumbersBindingSource;
      this.phoneNumbersDataGridView.Location = new System.Drawing.Point(6, 42);
      this.phoneNumbersDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.phoneNumbersDataGridView.Name = "phoneNumbersDataGridView";
      this.phoneNumbersDataGridView.RowHeadersWidth = 82;
      this.phoneNumbersDataGridView.RowTemplate.Height = 33;
      this.phoneNumbersDataGridView.Size = new System.Drawing.Size(592, 243);
      this.phoneNumbersDataGridView.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.dataGridViewTextBoxColumn1.DataPropertyName = "PhoneNumberId";
      this.dataGridViewTextBoxColumn1.HeaderText = "PhoneNumberId";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 109;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
      this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
      this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.Width = 79;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
      this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
      this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.Width = 80;
      // 
      // dataGridViewTextBoxColumn4
      // 
      this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
      this.dataGridViewTextBoxColumn4.HeaderText = "PhoneNumber";
      this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
      this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
      // 
      // dataGridViewTextBoxColumn5
      // 
      this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.dataGridViewTextBoxColumn5.DataPropertyName = "Age";
      this.dataGridViewTextBoxColumn5.HeaderText = "Age";
      this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
      this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
      this.dataGridViewTextBoxColumn5.Width = 51;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.TxtBoxFN);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(6, 288);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.groupBox1.Size = new System.Drawing.Size(305, 64);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Search";
      // 
      // TxtBoxFN
      // 
      this.TxtBoxFN.Location = new System.Drawing.Point(22, 38);
      this.TxtBoxFN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.TxtBoxFN.Name = "TxtBoxFN";
      this.TxtBoxFN.Size = new System.Drawing.Size(150, 21);
      this.TxtBoxFN.TabIndex = 2;
      this.TxtBoxFN.TextChanged += new System.EventHandler(this.TxtBoxFN_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(20, 20);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 15);
      this.label1.TabIndex = 1;
      this.label1.Text = "First Name";
      // 
      // BtnSortLN
      // 
      this.BtnSortLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnSortLN.Location = new System.Drawing.Point(334, 294);
      this.BtnSortLN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.BtnSortLN.Name = "BtnSortLN";
      this.BtnSortLN.Size = new System.Drawing.Size(128, 25);
      this.BtnSortLN.TabIndex = 3;
      this.BtnSortLN.Text = "Sort LN";
      this.BtnSortLN.UseVisualStyleBackColor = true;
      this.BtnSortLN.Click += new System.EventHandler(this.BtnSortLN_Click);
      // 
      // BtnAge30
      // 
      this.BtnAge30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnAge30.Location = new System.Drawing.Point(470, 294);
      this.BtnAge30.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.BtnAge30.Name = "BtnAge30";
      this.BtnAge30.Size = new System.Drawing.Size(128, 25);
      this.BtnAge30.TabIndex = 4;
      this.BtnAge30.Text = "Age > 30";
      this.BtnAge30.UseVisualStyleBackColor = true;
      this.BtnAge30.Click += new System.EventHandler(this.BtnAge30_Click);
      // 
      // BtnAvAge
      // 
      this.BtnAvAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnAvAge.Location = new System.Drawing.Point(334, 327);
      this.BtnAvAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.BtnAvAge.Name = "BtnAvAge";
      this.BtnAvAge.Size = new System.Drawing.Size(128, 25);
      this.BtnAvAge.TabIndex = 5;
      this.BtnAvAge.Text = "Average Age";
      this.BtnAvAge.UseVisualStyleBackColor = true;
      this.BtnAvAge.Click += new System.EventHandler(this.BtnAvAge_Click);
      // 
      // BtnClear
      // 
      this.BtnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnClear.Location = new System.Drawing.Point(470, 327);
      this.BtnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.BtnClear.Name = "BtnClear";
      this.BtnClear.Size = new System.Drawing.Size(128, 25);
      this.BtnClear.TabIndex = 6;
      this.BtnClear.Text = "Clear";
      this.BtnClear.UseVisualStyleBackColor = true;
      this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
      // 
      // phoneNumbersTableAdapter
      // 
      this.phoneNumbersTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.PhoneNumbersTableAdapter = this.phoneNumbersTableAdapter;
      this.tableAdapterManager.UpdateOrder = Participation4_PhoneDb.LocalPhoneDbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // LocalPhoneForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.BtnClear;
      this.ClientSize = new System.Drawing.Size(607, 359);
      this.Controls.Add(this.BtnClear);
      this.Controls.Add(this.BtnAvAge);
      this.Controls.Add(this.BtnAge30);
      this.Controls.Add(this.BtnSortLN);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.phoneNumbersDataGridView);
      this.Controls.Add(this.phoneNumbersBindingNavigator);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "LocalPhoneForm";
      this.Text = "LocalPhoneForm";
      this.Load += new System.EventHandler(this.LocalPhoneForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.phoneNumbersBindingNavigator)).EndInit();
      this.phoneNumbersBindingNavigator.ResumeLayout(false);
      this.phoneNumbersBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.phoneNumbersBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.localPhoneDbDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.phoneNumbersDataGridView)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private LocalPhoneDbDataSet localPhoneDbDataSet;
        private System.Windows.Forms.BindingSource phoneNumbersBindingSource;
        private LocalPhoneDbDataSetTableAdapters.PhoneNumbersTableAdapter phoneNumbersTableAdapter;
        private LocalPhoneDbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator phoneNumbersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton phoneNumbersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView phoneNumbersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TxtBoxFN;
    private System.Windows.Forms.Button BtnSortLN;
    private System.Windows.Forms.Button BtnAge30;
    private System.Windows.Forms.Button BtnAvAge;
    private System.Windows.Forms.Button BtnClear;
  }
}