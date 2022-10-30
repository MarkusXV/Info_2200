namespace Assignment4_MoviesDb
{
  partial class MoviesForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoviesForm));
      this.movieBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
      this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
      this.movieDataGridView = new System.Windows.Forms.DataGridView();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.TxtboxMovieTitle = new System.Windows.Forms.TextBox();
      this.LblMovieTitle = new System.Windows.Forms.Label();
      this.BtnAtoZ = new System.Windows.Forms.Button();
      this.BtnZtoA = new System.Windows.Forms.Button();
      this.BtnSearchFirst20 = new System.Windows.Forms.Button();
      this.BtnShowTotals = new System.Windows.Forms.Button();
      this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.iNFO2200_CrandallSayDataSet = new Assignment4_MoviesDb.INFO2200_CrandallSayDataSet();
      this.movieTableAdapter = new Assignment4_MoviesDb.INFO2200_CrandallSayDataSetTableAdapters.MovieTableAdapter();
      this.tableAdapterManager = new Assignment4_MoviesDb.INFO2200_CrandallSayDataSetTableAdapters.TableAdapterManager();
      ((System.ComponentModel.ISupportInitialize)(this.movieBindingNavigator)).BeginInit();
      this.movieBindingNavigator.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet)).BeginInit();
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
      this.movieBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
      this.movieBindingNavigator.Size = new System.Drawing.Size(758, 50);
      this.movieBindingNavigator.TabIndex = 0;
      this.movieBindingNavigator.Text = "bindingNavigator1";
      // 
      // bindingNavigatorAddNewItem
      // 
      this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
      this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
      this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 44);
      this.bindingNavigatorAddNewItem.Text = "Add new";
      // 
      // bindingNavigatorCountItem
      // 
      this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
      this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 44);
      this.bindingNavigatorCountItem.Text = "of {0}";
      this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
      // 
      // bindingNavigatorDeleteItem
      // 
      this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
      this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
      this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 44);
      this.bindingNavigatorDeleteItem.Text = "Delete";
      // 
      // bindingNavigatorMoveFirstItem
      // 
      this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
      this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
      this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 44);
      this.bindingNavigatorMoveFirstItem.Text = "Move first";
      // 
      // bindingNavigatorMovePreviousItem
      // 
      this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
      this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
      this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 44);
      this.bindingNavigatorMovePreviousItem.Text = "Move previous";
      // 
      // bindingNavigatorSeparator
      // 
      this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
      this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 50);
      // 
      // bindingNavigatorPositionItem
      // 
      this.bindingNavigatorPositionItem.AccessibleName = "Position";
      this.bindingNavigatorPositionItem.AutoSize = false;
      this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
      this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
      this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
      this.bindingNavigatorPositionItem.Text = "0";
      this.bindingNavigatorPositionItem.ToolTipText = "Current position";
      // 
      // bindingNavigatorSeparator1
      // 
      this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
      this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 50);
      // 
      // bindingNavigatorMoveNextItem
      // 
      this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
      this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
      this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 44);
      this.bindingNavigatorMoveNextItem.Text = "Move next";
      // 
      // bindingNavigatorMoveLastItem
      // 
      this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
      this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
      this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
      this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 44);
      this.bindingNavigatorMoveLastItem.Text = "Move last";
      // 
      // bindingNavigatorSeparator2
      // 
      this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
      this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 50);
      // 
      // movieBindingNavigatorSaveItem
      // 
      this.movieBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.movieBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("movieBindingNavigatorSaveItem.Image")));
      this.movieBindingNavigatorSaveItem.Name = "movieBindingNavigatorSaveItem";
      this.movieBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 44);
      this.movieBindingNavigatorSaveItem.Text = "Save Data";
      // 
      // movieDataGridView
      // 
      this.movieDataGridView.AutoGenerateColumns = false;
      this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.movieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
      this.movieDataGridView.DataSource = this.movieBindingSource;
      this.movieDataGridView.Location = new System.Drawing.Point(21, 60);
      this.movieDataGridView.Name = "movieDataGridView";
      this.movieDataGridView.RowHeadersWidth = 82;
      this.movieDataGridView.RowTemplate.Height = 33;
      this.movieDataGridView.Size = new System.Drawing.Size(710, 472);
      this.movieDataGridView.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.TxtboxMovieTitle);
      this.groupBox1.Controls.Add(this.LblMovieTitle);
      this.groupBox1.Location = new System.Drawing.Point(53, 578);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(649, 112);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Search";
      // 
      // TxtboxMovieTitle
      // 
      this.TxtboxMovieTitle.Location = new System.Drawing.Point(220, 44);
      this.TxtboxMovieTitle.Name = "TxtboxMovieTitle";
      this.TxtboxMovieTitle.Size = new System.Drawing.Size(396, 31);
      this.TxtboxMovieTitle.TabIndex = 1;
      this.TxtboxMovieTitle.TextChanged += new System.EventHandler(this.TxtboxMovieTitle_TextChanged);
      // 
      // LblMovieTitle
      // 
      this.LblMovieTitle.AutoSize = true;
      this.LblMovieTitle.Location = new System.Drawing.Point(101, 47);
      this.LblMovieTitle.Name = "LblMovieTitle";
      this.LblMovieTitle.Size = new System.Drawing.Size(117, 25);
      this.LblMovieTitle.TabIndex = 0;
      this.LblMovieTitle.Text = "Movie Title";
      // 
      // BtnAtoZ
      // 
      this.BtnAtoZ.Location = new System.Drawing.Point(21, 720);
      this.BtnAtoZ.Name = "BtnAtoZ";
      this.BtnAtoZ.Size = new System.Drawing.Size(169, 69);
      this.BtnAtoZ.TabIndex = 3;
      this.BtnAtoZ.Text = "Sort A-Z by Title";
      this.BtnAtoZ.UseVisualStyleBackColor = true;
      this.BtnAtoZ.Click += new System.EventHandler(this.BtnAtoZ_Click);
      // 
      // BtnZtoA
      // 
      this.BtnZtoA.Location = new System.Drawing.Point(202, 720);
      this.BtnZtoA.Name = "BtnZtoA";
      this.BtnZtoA.Size = new System.Drawing.Size(169, 69);
      this.BtnZtoA.TabIndex = 4;
      this.BtnZtoA.Text = "Sort Z-A by Title";
      this.BtnZtoA.UseVisualStyleBackColor = true;
      this.BtnZtoA.Click += new System.EventHandler(this.BtnZtoA_Click);
      // 
      // BtnSearchFirst20
      // 
      this.BtnSearchFirst20.Location = new System.Drawing.Point(380, 720);
      this.BtnSearchFirst20.Name = "BtnSearchFirst20";
      this.BtnSearchFirst20.Size = new System.Drawing.Size(169, 69);
      this.BtnSearchFirst20.TabIndex = 5;
      this.BtnSearchFirst20.Text = "Search First 20 \r\n(By ID)";
      this.BtnSearchFirst20.UseVisualStyleBackColor = true;
      this.BtnSearchFirst20.Click += new System.EventHandler(this.BtnSearchFirst20_Click);
      // 
      // BtnShowTotals
      // 
      this.BtnShowTotals.Location = new System.Drawing.Point(562, 720);
      this.BtnShowTotals.Name = "BtnShowTotals";
      this.BtnShowTotals.Size = new System.Drawing.Size(169, 69);
      this.BtnShowTotals.TabIndex = 6;
      this.BtnShowTotals.Text = "Show Totals";
      this.BtnShowTotals.UseVisualStyleBackColor = true;
      this.BtnShowTotals.Click += new System.EventHandler(this.BtnShowTotals_Click);
      // 
      // dataGridViewTextBoxColumn1
      // 
      this.dataGridViewTextBoxColumn1.DataPropertyName = "movieID";
      this.dataGridViewTextBoxColumn1.HeaderText = "movieID";
      this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
      this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
      this.dataGridViewTextBoxColumn1.ReadOnly = true;
      this.dataGridViewTextBoxColumn1.Width = 200;
      // 
      // dataGridViewTextBoxColumn2
      // 
      this.dataGridViewTextBoxColumn2.DataPropertyName = "movieTitle";
      this.dataGridViewTextBoxColumn2.HeaderText = "movieTitle";
      this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
      this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
      this.dataGridViewTextBoxColumn2.Width = 200;
      // 
      // dataGridViewTextBoxColumn3
      // 
      this.dataGridViewTextBoxColumn3.DataPropertyName = "category";
      this.dataGridViewTextBoxColumn3.HeaderText = "category";
      this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
      this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
      this.dataGridViewTextBoxColumn3.Width = 200;
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
      // MoviesForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(758, 823);
      this.Controls.Add(this.BtnShowTotals);
      this.Controls.Add(this.BtnSearchFirst20);
      this.Controls.Add(this.BtnZtoA);
      this.Controls.Add(this.BtnAtoZ);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.movieDataGridView);
      this.Controls.Add(this.movieBindingNavigator);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "MoviesForm";
      this.Text = "Movies Form";
      this.Load += new System.EventHandler(this.MoviesForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.movieBindingNavigator)).EndInit();
      this.movieBindingNavigator.ResumeLayout(false);
      this.movieBindingNavigator.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.iNFO2200_CrandallSayDataSet)).EndInit();
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
    private System.Windows.Forms.DataGridView movieDataGridView;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button BtnAtoZ;
    private System.Windows.Forms.Button BtnZtoA;
    private System.Windows.Forms.Button BtnSearchFirst20;
    private System.Windows.Forms.TextBox TxtboxMovieTitle;
    private System.Windows.Forms.Label LblMovieTitle;
    private System.Windows.Forms.Button BtnShowTotals;
  }
}

