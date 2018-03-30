namespace BookManage
{
    partial class frmUpdateBook
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
            this.dgvBookinfo = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookContentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIssueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookManageDataSet = new BookManage.BookManageDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnUpdatePic = new System.Windows.Forms.Button();
            this.txtbIssueID = new System.Windows.Forms.TextBox();
            this.txtbContent = new System.Windows.Forms.TextBox();
            this.txtbPic = new System.Windows.Forms.TextBox();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.txtbAuthor = new System.Windows.Forms.TextBox();
            this.txtbType = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.txtbID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookinfoTableAdapter = new BookManage.BookManageDataSetTableAdapters.bookinfoTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvBookinfo);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图书详细信息";
            // 
            // dgvBookinfo
            // 
            this.dgvBookinfo.AutoGenerateColumns = false;
            this.dgvBookinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookTypeDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.bookPriceDataGridViewTextBoxColumn,
            this.bookPicDataGridViewTextBoxColumn,
            this.bookContentDataGridViewTextBoxColumn,
            this.bookIssueDataGridViewTextBoxColumn});
            this.dgvBookinfo.DataSource = this.bookinfoBindingSource;
            this.dgvBookinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookinfo.Location = new System.Drawing.Point(3, 17);
            this.dgvBookinfo.Name = "dgvBookinfo";
            this.dgvBookinfo.RowTemplate.Height = 23;
            this.dgvBookinfo.Size = new System.Drawing.Size(335, 208);
            this.dgvBookinfo.TabIndex = 0;
            this.dgvBookinfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookinfo_CellClick);
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "图书ID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
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
            // bookinfoBindingSource
            // 
            this.bookinfoBindingSource.DataMember = "bookinfo";
            this.bookinfoBindingSource.DataSource = this.bookManageDataSet;
            // 
            // bookManageDataSet
            // 
            this.bookManageDataSet.DataSetName = "BookManageDataSet";
            this.bookManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.btnDel);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnUpdatePic);
            this.groupBox2.Controls.Add(this.txtbIssueID);
            this.groupBox2.Controls.Add(this.txtbContent);
            this.groupBox2.Controls.Add(this.txtbPic);
            this.groupBox2.Controls.Add(this.txtbPrice);
            this.groupBox2.Controls.Add(this.txtbAuthor);
            this.groupBox2.Controls.Add(this.txtbType);
            this.groupBox2.Controls.Add(this.txtbName);
            this.groupBox2.Controls.Add(this.txtbID);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(360, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "更新图书信息";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(304, 184);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "关闭";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(213, 184);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 18;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(116, 184);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnUpdatePic
            // 
            this.btnUpdatePic.Location = new System.Drawing.Point(20, 184);
            this.btnUpdatePic.Name = "btnUpdatePic";
            this.btnUpdatePic.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePic.TabIndex = 16;
            this.btnUpdatePic.Text = "更新封面";
            this.btnUpdatePic.UseVisualStyleBackColor = true;
            this.btnUpdatePic.Click += new System.EventHandler(this.btnUpdatePic_Click);
            // 
            // txtbIssueID
            // 
            this.txtbIssueID.Location = new System.Drawing.Point(279, 139);
            this.txtbIssueID.Name = "txtbIssueID";
            this.txtbIssueID.Size = new System.Drawing.Size(100, 21);
            this.txtbIssueID.TabIndex = 15;
            // 
            // txtbContent
            // 
            this.txtbContent.Location = new System.Drawing.Point(279, 102);
            this.txtbContent.Name = "txtbContent";
            this.txtbContent.Size = new System.Drawing.Size(100, 21);
            this.txtbContent.TabIndex = 14;
            // 
            // txtbPic
            // 
            this.txtbPic.Location = new System.Drawing.Point(279, 64);
            this.txtbPic.Name = "txtbPic";
            this.txtbPic.Size = new System.Drawing.Size(100, 21);
            this.txtbPic.TabIndex = 13;
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(279, 27);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.Size = new System.Drawing.Size(100, 21);
            this.txtbPrice.TabIndex = 12;
            // 
            // txtbAuthor
            // 
            this.txtbAuthor.Location = new System.Drawing.Point(91, 139);
            this.txtbAuthor.Name = "txtbAuthor";
            this.txtbAuthor.Size = new System.Drawing.Size(100, 21);
            this.txtbAuthor.TabIndex = 11;
            // 
            // txtbType
            // 
            this.txtbType.Location = new System.Drawing.Point(91, 102);
            this.txtbType.Name = "txtbType";
            this.txtbType.Size = new System.Drawing.Size(100, 21);
            this.txtbType.TabIndex = 10;
            // 
            // txtbName
            // 
            this.txtbName.Location = new System.Drawing.Point(91, 64);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(100, 21);
            this.txtbName.TabIndex = 9;
            // 
            // txtbID
            // 
            this.txtbID.Location = new System.Drawing.Point(91, 27);
            this.txtbID.Name = "txtbID";
            this.txtbID.ReadOnly = true;
            this.txtbID.Size = new System.Drawing.Size(100, 21);
            this.txtbID.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "指定访问码：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(208, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "图书内容：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "图书封面：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "图书价格：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "图书作者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "图书类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "图书名字：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书编号：";
            // 
            // bookinfoTableAdapter
            // 
            this.bookinfoTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(331, 273);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存修改";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmUpdateBook
            //
            this.AcceptButton = btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = btnCancel;
            this.ClientSize = new System.Drawing.Size(776, 318);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmUpdateBook";
            this.Text = "图书更新";
            this.Load += new System.EventHandler(this.frmUpdateBook_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBookinfo;
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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnUpdatePic;
        private System.Windows.Forms.TextBox txtbIssueID;
        private System.Windows.Forms.TextBox txtbContent;
        private System.Windows.Forms.TextBox txtbPic;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.TextBox txtbAuthor;
        private System.Windows.Forms.TextBox txtbType;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.TextBox txtbID;
    }
}