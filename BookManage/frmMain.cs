using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookManage
{
    public partial class frmMain : Form//主窗体，继承自Form类
    {
        public static DialogResult result;//声明对话框返回对象
        public frmMain()//构造函数 
        {
            InitializeComponent();

        }
        //查询子窗体是否存在
        public bool checkchildfrm(string childfrmname)
        {
            foreach (Form childFrm in this.MdiChildren)//遍历子窗体
            {
                if (childFrm.Name == childfrmname)//判断子窗体的名称
                {
                    if (childFrm.WindowState == FormWindowState.Minimized)//如果子窗体处于最小化的状态
                    {
                        childFrm.WindowState = FormWindowState.Normal;//恢复正常显示
                    }
                    childFrm.Activate();//激活窗体
                    return true;//返回真值
                }
            }
            return false;//返回假值
        }

        private void tsbtnLogin_Click(object sender, EventArgs e)//登陆
        {
            if (this.checkchildfrm("frmLogin") == true)//检测该窗口是否处于打开状态
            {
                return;//窗口已打开，返回
            }
            frmLogin user = new frmLogin();//实例化登陆窗体
            user.ShowDialog();//登陆窗体以模式对话框的方式打开
            if (result == DialogResult.OK)//判断是否登陆成功，登陆成功则启用相应的菜单和按钮
            {
                this.tsbtnAddBook.Enabled = true;
                this.tsbtnUpdateBook.Enabled = true;
                this.mmuAddBook.Enabled = true;
                this.mmuUpdateBook.Enabled = true;
            }
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)//图书查询 
        {
            if (this.checkchildfrm("frmSearchBook") == true)//检测该窗口是否处于打开状态
            {
                return;//窗口已打开，返回
            }
            frmSearchBook book = new frmSearchBook();//实例化图书查询窗体
            book.MdiParent = this;//设置为当前窗体的子窗体
            book.Show();//图书查询窗体以非模式对话框的方式打开
        }

        private void tsbtnAddBook_Click(object sender, EventArgs e)//图书入库
        {
            if (this.checkchildfrm("frmAddBook") == true)//检测该窗口是否处于打开状态
            {
                return;//窗口已打开，返回
            }
            frmAddBook objbook = new frmAddBook();//实例化图书入库窗体
            objbook.MdiParent = this;//设置为当前窗体的子窗体
            objbook.Show();//图书入库以非模式对话框的方式打开
        }

        private void tsbtnUpdateBook_Click(object sender, EventArgs e)//图书更新
        {
            if (this.checkchildfrm("frmUpdateBook") == true)//检测该窗口是否处于打开状态
            {
                return;//窗口已打开，返回
            }
            frmUpdateBook objbook = new frmUpdateBook();//实例化图书更新窗体
            objbook.MdiParent = this;//设置为当前窗体的子窗体
            objbook.Show();//图书更新以非模式对话框的方式打开
        }

        private void tsbtnIssue_Click(object sender, EventArgs e)//图书借阅
        {
            if (this.checkchildfrm("frmIssueBook") == true)//检测该窗口是否处于打开状态
            {
                return;//窗口已打开，返回
            }
            frmIssueBook issuebook = new frmIssueBook();//实例化图书借阅窗体
            issuebook.MdiParent = this;//设置为当前窗体的子窗体
            issuebook.Show();//图书借阅以非模式对话框的方式打开
        }

        private void tsbtnExit_Click(object sender, EventArgs e)//退出 
        {
            Application.Exit();//退出应用程序
        }

        private void mmuLogin_Click(object sender, EventArgs e)//登陆
        {
            if (this.checkchildfrm("frmLogin") == true)//检测该窗口是否处于打开状态
            {
                return;//窗口已打开，返回
            }
            frmLogin user = new frmLogin();//实例化登陆窗体
            user.ShowDialog();//登陆窗体以模式对话框的方式打开
            if (result == DialogResult.OK)//判断是否登陆成功，登陆成功则启用相应的菜单和按钮
            {
                this.tsbtnAddBook.Enabled = true;
                this.tsbtnUpdateBook.Enabled = true;
                this.mmuAddBook.Enabled = true;
                this.mmuUpdateBook.Enabled = true;
            }
        }

        private void mmuSearch_Click(object sender, EventArgs e)//图书查询
        {
            if (this.checkchildfrm("frmSearchBook") == true)//检测该窗口是否处于打开状态
            {
                return;//窗口已打开，返回
            }
            frmSearchBook book = new frmSearchBook();//实例化图书查询窗体
            book.MdiParent = this;//设置为当前窗体的子窗体
            book.Show();//图书查询窗体以非模式对话框的方式打开
        }

        private void mmuAddBook_Click(object sender, EventArgs e)//图书入库
        {
            if (this.checkchildfrm("frmAddBook") == true)//检测该窗口是否处于打开状态
            {
                return;//窗口已打开，返回
            }
            frmAddBook objbook = new frmAddBook();//实例化图书入库窗体
            objbook.MdiParent = this;//设置为当前窗体的子窗体
            objbook.Show();//图书入库以非模式对话框的方式打开
        }

        private void mmuUpdateBook_Click(object sender, EventArgs e)//图书更新 
        {
            if (this.checkchildfrm("frmUpdateBook") == true)//检测该窗口是否处于打开状态
            {
                return;//窗口已打开，返回
            }
            frmUpdateBook objbook = new frmUpdateBook();//实例化图书更新窗体
            objbook.MdiParent = this;//设置为当前窗体的子窗体
            objbook.Show();//图书更新以非模式对话框的方式打开
        }

        private void mmuIssue_Click(object sender, EventArgs e)//图书借阅
        {
            if (this.checkchildfrm("frmIssueBook") == true)//检测该窗口是否处于打开状态
            {
                return;//窗口已打开，返回
            }
            frmIssueBook issuebook = new frmIssueBook();//实例化图书借阅窗体
            issuebook.MdiParent = this;//设置为当前窗体的子窗体
            issuebook.Show();//图书借阅以非模式对话框的方式打开
        }

        private void mmuExit_Click(object sender, EventArgs e)//退出
        {
            Application.Exit();//退出应用程序
        }

        private void frmMain_Load(object sender, EventArgs e)//窗体载入时事件处理
        {
            this.tsbtnAddBook.Enabled = false;
            this.tsbtnUpdateBook.Enabled = false;
            this.mmuAddBook.Enabled = false;
            this.mmuUpdateBook.Enabled = false;
        }

        private void 系统辅助ToolStripMenuItem_Click(object sender, EventArgs e)//系统辅助
        {
            MessageBox.Show("此功能尚未设计");
        }
    }
}
