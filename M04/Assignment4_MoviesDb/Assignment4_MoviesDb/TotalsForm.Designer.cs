namespace Assignment4_MoviesDb
{
  partial class TotalsForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TotalsForm));
      this.movieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
      this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.iNFO2200_CrandallSayDataSet = new Assignment4_MoviesDb.INFO2200_CrandallSayDataSet();
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
      this.movieBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
      this.countMovieCategory = new Assignment4_MoviesDb.CountMovieCategory();
      this.countMovieCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.countMovieCategoryTableAdapter = new Assignment4_MoviesDb.CountMovieCategoryTableAdapters.CountMovieCategoryTableAdapter();
      this.tableAdapterManager1 = new Assignment4_MoviesDb.CountMovieCategoryTableAdapters.TableAdapterManager();
      this.countMovieCategoryDataGridView = new System.Windows.Forms.DataGridView();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.movieTableAdapter = new Assignment4_MoviesDb.INFO2200_CrandallSayDataSetTableAdapters.MovieTableAdapter();
      this.tableAdapterManager = new Assignment4_MoviesDb.INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager();
      ((System.ComponentModel.ISupportInitialize)(this.movieBindingNavigator)).BeginInit();
      this.movieBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.countMovieCategory)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.countMovieCategoryBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.countMovieCategoryDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // movieBindingNavigator
      // 
      this.movieBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
      this.movieBindingNavigator.BindingSource = this.movieBindingSource;
      this.movieBindingNavigator.CountItem = this.bindingNavigatorCountItem;
      this.movieBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
      this.movieBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
      this.movieBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.movieBindingNavigatorSaveItem});
      this.movieBindingNavigator.Location = new System.Drawing.Point(0, 0);
      this.movieBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
      this.movieBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
      this.movieBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
      this.movieBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
      this.movieBindingNavigator.Name = "movieBindingNavigator";
      this.movieBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
      this.movieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.movieBindingNavigator.Size = new System.Drawing.Size(435, 39);
      this.movieBindingNavigator.TabIndex = 0;
      this.movieBindingNavigator.Text = "bindingNavigator1";
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
      // movieBindingSource
      // 
      this.movieBindingSource.DataMember = "Movie";
      this.movieBindingSource.DataSource = this.iNFO2200_CrandallSayDataSet;
      // 
      // iNFO2200_CrandallSayDataSet
      // 
      this.iNFO2200_CrandallSayDataSet.DataSetName = "INFO2200_CrandallSayDataSet";
      this.iNFO2200_CrandallSayDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
      // movieBindingNavigatorSaveItem
      // 
      this.movieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.movieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("movieBindingNavigatorSaveItem.Image")));
      this.movieBindingNavigatorSaveItem.Name = "movieBindingNavigatorSaveItem";
      this.movieBindingNavigatorSaveItem.Size = new System.Drawing.Size(36, 36);
      this.movieBindingNavigatorSaveItem.Text = "Save Data";
      this.movieBindingNavigatorSaveItem.Click += new System.EventHandler(this.movieBindingNavigatorSaveItem_Click);
      // 
      // countMovieCategory
      // 
      this.countMovieCategory.DataSetName = "CountMovieCategory";
      this.countMovieCategory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // countMovieCategoryBindingSource
      // 
      this.countMovieCategoryBindingSource.DataMember = "CountMovieCategory";
      this.countMovieCategoryBindingSource.DataSource = this.countMovieCategory;
      // 
      // countMovieCategoryTableAdapter
      // 
      this.countMovieCategoryTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager1
      // 
      this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager1.Connection = null;
      this.tableAdapterManager1.UpdateOrder = Assignment4_MoviesDb.CountMovieCategoryTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // countMovieCategoryDataGridView
      // 
      this.countMovieCategoryDataGridView.AutoGenerateColumns = false;
      this.countMovieCategoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.countMovieCategoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
      this.countMovieCategoryDataGridView.DataSource = this.countMovieCategoryBindingSource;
      this.countMovieCategoryDataGridView.Location = new System.Drawing.Point(6, 41);
      this.countMovieCategoryDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.countMovieCategoryDataGridView.Name = "countMovieCategoryDataGridView";
      this.countMovieCategoryDataGridView.RowHeadersWidth = 82;
      this.countMovieCategoryDataGridView.RowTemplate.Height = 33;
      this.countMovieCategoryDataGridView.Size = new System.Drawing.Size(423, 226);
      this.countMovieCategoryDataGridView.TabIndex = 1;
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.dataGridViewTextBoxColumn1.DataPropertyName = "Count";
      this.dataGridViewTextBoxColumn1.HeaderText = "Count";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 60;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.dataGridViewTextBoxColumn2.DataPropertyName = "category";
      this.dataGridViewTextBoxColumn2.HeaderText = "category";
      this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      // 
      // movieTableAdapter
      // 
      this.movieTableAdapter.ClearBeforeFill = true;
      // 
      // tableAdapterManager
      // 
      this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
      this.tableAdapterManager.MovieTableAdapter = this.movieTableAdapter;
      this.tableAdapterManager.UpdateOrder = Assignment4_MoviesDb.INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
      // 
      // TotalsForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(435, 276);
      this.Controls.Add(this.countMovieCategoryDataGridView);
      this.Controls.Add(this.movieBindingNavigator);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "TotalsForm";
      this.Text = "TotalsForm";
      this.Load += new System.EventHandler(this.TotalsForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.movieBindingNavigator)).EndInit();
      this.movieBindingNavigator.ResumeLayout(false);
      this.movieBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.countMovieCategory)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.countMovieCategoryBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.countMovieCategoryDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private INFO2200_CrandallSayDataSet iNFO2200_CrandallSayDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private INFO2200_CrandallSayDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator movieBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton movieBindingNavigatorSaveItem;
        private CountMovieCategory countMovieCategory;
        private System.Windows.Forms.BindingSource countMovieCategoryBindingSource;
        private CountMovieCategoryTableAdapters.CountMovieCategoryTableAdapter countMovieCategoryTableAdapter;
        private CountMovieCategoryTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView countMovieCategoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}