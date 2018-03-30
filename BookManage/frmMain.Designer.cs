namespace BookManage
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuUpdateBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.系统辅助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mmuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnLogin = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAddBook = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpdateBook = new System.Windows.Forms.ToolStripButton();
            this.tsbtnIssue = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.图书管理ToolStripMenuItem,
            this.mmuIssue,
            this.系统辅助ToolStripMenuItem,
            this.mmuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmuLogin});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // mmuLogin
            // 
            this.mmuLogin.Name = "mmuLogin";
            this.mmuLogin.Size = new System.Drawing.Size(100, 22);
            this.mmuLogin.Text = "登陆";
            this.mmuLogin.Click += new System.EventHandler(this.mmuLogin_Click);
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mmuSearch,
            this.mmuAddBook,
            this.mmuUpdateBook});
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.图书管理ToolStripMenuItem.Text = "图书管理";
            // 
            // mmuSearch
            // 
            this.mmuSearch.Name = "mmuSearch";
            this.mmuSearch.Size = new System.Drawing.Size(124, 22);
            this.mmuSearch.Text = "图书查询";
            this.mmuSearch.Click += new System.EventHandler(this.mmuSearch_Click);
            // 
            // mmuAddBook
            // 
            this.mmuAddBook.Name = "mmuAddBook";
            this.mmuAddBook.Size = new System.Drawing.Size(124, 22);
            this.mmuAddBook.Text = "图书入库";
            this.mmuAddBook.Click += new System.EventHandler(this.mmuAddBook_Click);
            // 
            // mmuUpdateBook
            // 
            this.mmuUpdateBook.Name = "mmuUpdateBook";
            this.mmuUpdateBook.Size = new System.Drawing.Size(124, 22);
            this.mmuUpdateBook.Text = "图书更新";
            this.mmuUpdateBook.Click += new System.EventHandler(this.mmuUpdateBook_Click);
            // 
            // mmuIssue
            // 
            this.mmuIssue.Name = "mmuIssue";
            this.mmuIssue.Size = new System.Drawing.Size(68, 21);
            this.mmuIssue.Text = "图书借阅";
            this.mmuIssue.Click += new System.EventHandler(this.mmuIssue_Click);
            // 
            // 系统辅助ToolStripMenuItem
            // 
            this.系统辅助ToolStripMenuItem.Name = "系统辅助ToolStripMenuItem";
            this.系统辅助ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统辅助ToolStripMenuItem.Text = "系统辅助";
            this.系统辅助ToolStripMenuItem.Click += new System.EventHandler(this.系统辅助ToolStripMenuItem_Click);
            // 
            // mmuExit
            // 
            this.mmuExit.Name = "mmuExit";
            this.mmuExit.Size = new System.Drawing.Size(44, 21);
            this.mmuExit.Text = "退出";
            this.mmuExit.Click += new System.EventHandler(this.mmuExit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnLogin,
            this.tsbtnSearch,
            this.tsbtnAddBook,
            this.tsbtnUpdateBook,
            this.tsbtnIssue,
            this.tsbtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnLogin
            // 
            this.tsbtnLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnLogin.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnLogin.Image")));
            this.tsbtnLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnLogin.Name = "tsbtnLogin";
            this.tsbtnLogin.Size = new System.Drawing.Size(23, 22);
            this.tsbtnLogin.Text = "登录";
            this.tsbtnLogin.Click += new System.EventHandler(this.tsbtnLogin_Click);
            // 
            // tsbtnSearch
            // 
            this.tsbtnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSearch.Image")));
            this.tsbtnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSearch.Name = "tsbtnSearch";
            this.tsbtnSearch.Size = new System.Drawing.Size(23, 22);
            this.tsbtnSearch.Text = "图书查询";
            this.tsbtnSearch.Click += new System.EventHandler(this.tsbtnSearch_Click);
            // 
            // tsbtnAddBook
            // 
            this.tsbtnAddBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAddBook.Image")));
            this.tsbtnAddBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddBook.Name = "tsbtnAddBook";
            this.tsbtnAddBook.Size = new System.Drawing.Size(23, 22);
            this.tsbtnAddBook.Text = "图书入库";
            this.tsbtnAddBook.Click += new System.EventHandler(this.tsbtnAddBook_Click);
            // 
            // tsbtnUpdateBook
            // 
            this.tsbtnUpdateBook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnUpdateBook.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnUpdateBook.Image")));
            this.tsbtnUpdateBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdateBook.Name = "tsbtnUpdateBook";
            this.tsbtnUpdateBook.Size = new System.Drawing.Size(23, 22);
            this.tsbtnUpdateBook.Text = "图书更新";
            this.tsbtnUpdateBook.Click += new System.EventHandler(this.tsbtnUpdateBook_Click);
            // 
            // tsbtnIssue
            // 
            this.tsbtnIssue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnIssue.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnIssue.Image")));
            this.tsbtnIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnIssue.Name = "tsbtnIssue";
            this.tsbtnIssue.Size = new System.Drawing.Size(23, 22);
            this.tsbtnIssue.Text = "图书借阅";
            this.tsbtnIssue.Click += new System.EventHandler(this.tsbtnIssue_Click);
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(23, 22);
            this.tsbtnExit.Text = "退出";
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "图书管理信息系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmuIssue;
        private System.Windows.Forms.ToolStripMenuItem 系统辅助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mmuExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnLogin;
        private System.Windows.Forms.ToolStripButton tsbtnSearch;
        private System.Windows.Forms.ToolStripButton tsbtnAddBook;
        private System.Windows.Forms.ToolStripButton tsbtnIssue;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripMenuItem mmuLogin;
        private System.Windows.Forms.ToolStripMenuItem mmuSearch;
        private System.Windows.Forms.ToolStripMenuItem mmuAddBook;
        private System.Windows.Forms.ToolStripMenuItem mmuUpdateBook;
        private System.Windows.Forms.ToolStripButton tsbtnUpdateBook;
    }
}

