namespace BookManage
{
    partial class frmSearchBook
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.cboOR = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboAnd = new System.Windows.Forms.ComboBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.dgvSearchBook = new System.Windows.Forms.DataGridView();
            this.bookManageDataSet = new BookManage.BookManageDataSet();
            this.bookinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookinfoTableAdapter = new BookManage.BookManageDataSetTableAdapters.bookinfoTableAdapter();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookinfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtContent);
            this.groupBox1.Controls.Add(this.cboAnd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.cboOR);
            this.groupBox1.Controls.Add(this.cboType);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "搜索条件";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(106, 233);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "关闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(9, 233);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "主要内容";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "图书名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书类别";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvSearchBook);
            this.groupBox2.Location = new System.Drawing.Point(225, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 280);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "搜索结果";
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(69, 27);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(100, 20);
            this.cboType.TabIndex = 5;
            // 
            // cboOR
            // 
            this.cboOR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOR.FormattingEnabled = true;
            this.cboOR.Items.AddRange(new object[] {
            "or",
            "and"});
            this.cboOR.Location = new System.Drawing.Point(69, 66);
            this.cboOR.Name = "cboOR";
            this.cboOR.Size = new System.Drawing.Size(100, 20);
            this.cboOR.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(69, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 7;
            // 
            // cboAnd
            // 
            this.cboAnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnd.FormattingEnabled = true;
            this.cboAnd.Items.AddRange(new object[] {
            "or",
            "and"});
            this.cboAnd.Location = new System.Drawing.Point(69, 138);
            this.cboAnd.Name = "cboAnd";
            this.cboAnd.Size = new System.Drawing.Size(100, 20);
            this.cboAnd.TabIndex = 8;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(69, 181);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(100, 21);
            this.txtContent.TabIndex = 9;
            // 
            // dgvSearchBook
            // 
            this.dgvSearchBook.AutoGenerateColumns = false;
            this.dgvSearchBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchBook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookTypeDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.bookPriceDataGridViewTextBoxColumn,
            this.bookPicDataGridViewTextBoxColumn,
            this.bookContentDataGridViewTextBoxColumn,
            this.bookIssueDataGridViewTextBoxColumn});
            this.dgvSearchBook.DataSource = this.bookinfoBindingSource;
            this.dgvSearchBook.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSearchBook.Location = new System.Drawing.Point(3, 17);
            this.dgvSearchBook.Name = "dgvSearchBook";
            this.dgvSearchBook.RowTemplate.Height = 23;
            this.dgvSearchBook.Size = new System.Drawing.Size(490, 260);
            this.dgvSearchBook.TabIndex = 0;
            // 
            // bookManageDataSet
            // 
            this.bookManageDataSet.DataSetName = "BookManageDataSet";
            this.bookManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookinfoBindingSource
            // 
            this.bookinfoBindingSource.DataMember = "bookinfo";
            this.bookinfoBindingSource.DataSource = this.bookManageDataSet;
            // 
            // bookinfoTableAdapter
            // 
            this.bookinfoTableAdapter.ClearBeforeFill = true;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "图书ID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "书名";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookTypeDataGridViewTextBoxColumn
            // 
            this.bookTypeDataGridViewTextBoxColumn.DataPropertyName = "BookType";
            this.bookTypeDataGridViewTextBoxColumn.HeaderText = "图书类别";
            this.bookTypeDataGridViewTextBoxColumn.Name = "bookTypeDataGridViewTextBoxColumn";
            this.bookTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookAuthorDataGridViewTextBoxColumn
            // 
            this.bookAuthorDataGridViewTextBoxColumn.DataPropertyName = "BookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.HeaderText = "作者";
            this.bookAuthorDataGridViewTextBoxColumn.Name = "bookAuthorDataGridViewTextBoxColumn";
            this.bookAuthorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookPriceDataGridViewTextBoxColumn
            // 
            this.bookPriceDataGridViewTextBoxColumn.DataPropertyName = "BookPrice";
            this.bookPriceDataGridViewTextBoxColumn.HeaderText = "价格";
            this.bookPriceDataGridViewTextBoxColumn.Name = "bookPriceDataGridViewTextBoxColumn";
            this.bookPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookPicDataGridViewTextBoxColumn
            // 
            this.bookPicDataGridViewTextBoxColumn.DataPropertyName = "BookPic";
            this.bookPicDataGridViewTextBoxColumn.HeaderText = "封面";
            this.bookPicDataGridViewTextBoxColumn.Name = "bookPicDataGridViewTextBoxColumn";
            this.bookPicDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookContentDataGridViewTextBoxColumn
            // 
            this.bookContentDataGridViewTextBoxColumn.DataPropertyName = "BookContent";
            this.bookContentDataGridViewTextBoxColumn.HeaderText = "内容简介";
            this.bookContentDataGridViewTextBoxColumn.Name = "bookContentDataGridViewTextBoxColumn";
            this.bookContentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookIssueDataGridViewTextBoxColumn
            // 
            this.bookIssueDataGridViewTextBoxColumn.DataPropertyName = "BookIssue";
            this.bookIssueDataGridViewTextBoxColumn.HeaderText = "指定访问码";
            this.bookIssueDataGridViewTextBoxColumn.Name = "bookIssueDataGridViewTextBoxColumn";
            this.bookIssueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmSearchBook
            // 
            this.AcceptButton = btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = btnClose;
            this.ClientSize = new System.Drawing.Size(733, 304);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);           
            this.Name = "frmSearchBook";
            this.Text = "图书查询";
            this.Load += new System.EventHandler(this.frmSearchBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookinfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.ComboBox cboAnd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboOR;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.DataGridView dgvSearchBook;
        private BookManageDataSet bookManageDataSet;
        private System.Windows.Forms.BindingSource bookinfoBindingSource;
        private BookManageDataSetTableAdapters.bookinfoTableAdapter bookinfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookContentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIssueDataGridViewTextBoxColumn;
    }
}