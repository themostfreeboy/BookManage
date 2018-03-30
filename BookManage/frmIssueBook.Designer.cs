namespace BookManage
{
    partial class frmIssueBook
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.cboBookName = new System.Windows.Forms.ComboBox();
            this.txtBookAccessCode = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtIssID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvIssInfo = new System.Windows.Forms.DataGridView();
            this.issueinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookManageDataSet = new BookManage.BookManageDataSet();
            this.issueinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.issueinfoTableAdapter = new BookManage.BookManageDataSetTableAdapters.issueinfoTableAdapter();
            this.bookManageDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookManageDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookManageDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSetBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.cboBookName);
            this.groupBox1.Controls.Add(this.txtBookAccessCode);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.txtIssID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "借阅详细信息：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(94, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 21);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(94, 181);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(107, 21);
            this.txtAuthor.TabIndex = 10;
            // 
            // cboBookName
            // 
            this.cboBookName.FormattingEnabled = true;
            this.cboBookName.Location = new System.Drawing.Point(94, 140);
            this.cboBookName.Name = "cboBookName";
            this.cboBookName.Size = new System.Drawing.Size(107, 20);
            this.cboBookName.TabIndex = 9;
            this.cboBookName.SelectedIndexChanged += new System.EventHandler(this.cboBookName_SelectedIndexChanged);
            // 
            // txtBookAccessCode
            // 
            this.txtBookAccessCode.Location = new System.Drawing.Point(94, 97);
            this.txtBookAccessCode.Name = "txtBookAccessCode";
            this.txtBookAccessCode.ReadOnly = true;
            this.txtBookAccessCode.Size = new System.Drawing.Size(107, 21);
            this.txtBookAccessCode.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(94, 58);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(107, 21);
            this.maskedTextBox1.TabIndex = 7;
            // 
            // txtIssID
            // 
            this.txtIssID.Location = new System.Drawing.Point(94, 19);
            this.txtIssID.Name = "txtIssID";
            this.txtIssID.Size = new System.Drawing.Size(107, 21);
            this.txtIssID.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "借阅日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "作者：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "书名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "图书访问码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "借阅证号：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvIssInfo);
            this.groupBox2.Location = new System.Drawing.Point(235, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "借阅详细信息：";
            // 
            // dgvIssInfo
            // 
            this.dgvIssInfo.AutoGenerateColumns = false;
            this.dgvIssInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssInfo.DataSource = this.bookManageDataSetBindingSource;
            this.dgvIssInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIssInfo.Location = new System.Drawing.Point(3, 17);
            this.dgvIssInfo.Name = "dgvIssInfo";
            this.dgvIssInfo.RowTemplate.Height = 23;
            this.dgvIssInfo.Size = new System.Drawing.Size(501, 212);
            this.dgvIssInfo.TabIndex = 0;
            // 
            // issueinfoBindingSource1
            // 
            this.issueinfoBindingSource1.DataMember = "issueinfo";
            this.issueinfoBindingSource1.DataSource = this.bookManageDataSet;
            // 
            // bookManageDataSet
            // 
            this.bookManageDataSet.DataSetName = "BookManageDataSet";
            this.bookManageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issueinfoBindingSource
            // 
            this.issueinfoBindingSource.DataMember = "issueinfo";
            this.issueinfoBindingSource.DataSource = this.bookManageDataSet;
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.Location = new System.Drawing.Point(359, 262);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(75, 23);
            this.btnIssueBook.TabIndex = 2;
            this.btnIssueBook.Text = "借阅";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(598, 262);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "退出";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // issueinfoTableAdapter
            // 
            this.issueinfoTableAdapter.ClearBeforeFill = true;
            // 
            // bookManageDataSetBindingSource
            // 
            this.bookManageDataSetBindingSource.DataSource = this.bookManageDataSet;
            this.bookManageDataSetBindingSource.Position = 0;
            // 
            // bookManageDataSetBindingSource1
            // 
            this.bookManageDataSetBindingSource1.DataSource = this.bookManageDataSet;
            this.bookManageDataSetBindingSource1.Position = 0;
            // 
            // bookManageDataSetBindingSource2
            // 
            this.bookManageDataSetBindingSource2.DataSource = this.bookManageDataSet;
            this.bookManageDataSetBindingSource2.Position = 0;
            // 
            // frmIssueBook
            // 
            this.AcceptButton = this.btnIssueBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(754, 303);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnIssueBook);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIssueBook";
            this.Text = "图书借阅";
            this.Load += new System.EventHandler(this.frmIssueBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issueinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookManageDataSetBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvIssInfo;
        private BookManageDataSet bookManageDataSet;
        private System.Windows.Forms.BindingSource issueinfoBindingSource;
        private BookManageDataSetTableAdapters.issueinfoTableAdapter issueinfoTableAdapter;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.ComboBox cboBookName;
        private System.Windows.Forms.TextBox txtBookAccessCode;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txtIssID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource issueinfoBindingSource1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource bookManageDataSetBindingSource;
        private System.Windows.Forms.BindingSource bookManageDataSetBindingSource1;
        private System.Windows.Forms.BindingSource bookManageDataSetBindingSource2;
    }
}