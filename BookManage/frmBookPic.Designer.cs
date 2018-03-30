namespace BookManage
{
    partial class frmBookPic
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPic = new System.Windows.Forms.TextBox();
            this.btnPic = new System.Windows.Forms.Button();
            this.pbBook = new System.Windows.Forms.PictureBox();
            this.btnUpdatePic = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书封面路径";
            // 
            // txtPic
            // 
            this.txtPic.Location = new System.Drawing.Point(130, 23);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(275, 21);
            this.txtPic.TabIndex = 1;
            // 
            // btnPic
            // 
            this.btnPic.Location = new System.Drawing.Point(36, 57);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(75, 23);
            this.btnPic.TabIndex = 2;
            this.btnPic.Text = "修改封面";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // pbBook
            // 
            this.pbBook.Location = new System.Drawing.Point(36, 95);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(369, 170);
            this.pbBook.TabIndex = 3;
            this.pbBook.TabStop = false;
            // 
            // btnUpdatePic
            // 
            this.btnUpdatePic.Location = new System.Drawing.Point(81, 289);
            this.btnUpdatePic.Name = "btnUpdatePic";
            this.btnUpdatePic.Size = new System.Drawing.Size(75, 23);
            this.btnUpdatePic.TabIndex = 4;
            this.btnUpdatePic.Text = "更新封面";
            this.btnUpdatePic.UseVisualStyleBackColor = true;
            this.btnUpdatePic.Click += new System.EventHandler(this.btnUpdatePic_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(274, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "picture";
            // 
            // frmBookPic
            // 
            this.AcceptButton = this.btnUpdatePic;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(432, 327);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdatePic);
            this.Controls.Add(this.pbBook);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.txtPic);
            this.Controls.Add(this.label1);
            this.Name = "frmBookPic";
            this.Text = "图书封面查看";
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPic;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.PictureBox pbBook;
        private System.Windows.Forms.Button btnUpdatePic;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog ofdFile;
    }
}