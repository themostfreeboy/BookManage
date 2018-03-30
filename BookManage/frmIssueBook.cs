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
    public partial class frmIssueBook : Form
    {
        public frmIssueBook()
        {
            InitializeComponent();
        }

        private void frmIssueBook_Load(object sender, EventArgs e)//窗体载入时事件处理
        {
            //此例程数据库中issueinfo.IssID(借阅ID)与issueinfo.IssBookID(借阅证号)有点乱，有些部分有混用现象。导致程序处理这些字段时有问题。由于此程序只是练习，此部分不修改了。此程序还有很多地方只检测textBox内内容是否为空，未检测数据是否合法，此程序纯属练习，不添加此部分校检代码了。
            #region DataGridView控件内数据数据初始化
            DataSet ds = DataAccess.GetDataSetBySql("select issueinfo.IssBookID as '借阅证号', issueinfo.IssDateTime as '借阅时间', bookinfo.BookName as '借阅图书' from bookinfo join issueinfo on bookinfo.BookID=issueinfo.BookID");//sql语句
            this.dgvIssInfo.AutoGenerateColumns = true;//自动
            this.dgvIssInfo.DataSource = ds.Tables[0];////绑定数据源
            this.dgvIssInfo.Columns[0].ReadOnly = true;//设为只读
            this.dgvIssInfo.Columns[1].ReadOnly = true;//设为只读
            this.dgvIssInfo.Columns[2].ReadOnly = true;//设为只读
            #endregion

            #region 书名初始化
            ds = DataAccess.GetDataSetBySql("select * from bookinfo");//sql语句
            this.cboBookName.DataSource = ds.Tables[0];//绑定数据源
            this.cboBookName.DisplayMember = "BookName";//组合框中显示的字段
            this.cboBookName.ValueMember = "BookID";//与显示字段对应的值
            #endregion
        }

        private void btnIssueBook_Click(object sender, EventArgs e)//借阅
        {
            //此例程数据库中issueinfo.IssID(借阅ID)与issueinfo.IssBookID(借阅证号)有点乱，有些部分有混用现象。导致程序处理这些字段时有问题。由于此程序只是练习，此部分不修改了。此程序还有很多地方只检测textBox内内容是否为空，未检测数据是否合法，此程序纯属练习，不添加此部分校检代码了。
            int bookid = Convert.ToInt32(this.cboBookName.SelectedValue);//获取组合框中的值
            int issid = Convert.ToInt32(this.txtIssID.Text);//借阅证号
            DateTime date = Convert.ToDateTime(this.dateTimePicker1.Text);//借书时间
            string sql = string.Format("insert into issueinfo values({0}, {1},123,'{2}')",issid, bookid, date);//sql语句
            if (DataAccess.UpdateDataTable(sql))//执行更新
            {
                MessageBox.Show("借阅成功");
            }
            DataSet ds = DataAccess.GetDataSetBySql("select issueinfo.IssBookID as '借阅证号', issueinfo.IssDateTime as '借阅时间', bookinfo.BookName as '借阅图书' from bookinfo join issueinfo on bookinfo.BookID=issueinfo.BookID");//sql语句
            this.dgvIssInfo.DataSource = ds.Tables[0];//绑定数据源
        }

        private void btnCancel_Click(object sender, EventArgs e)//退出
        {
            this.Close();
        }

        private void cboBookName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = DataAccess.GetDataSetBySql("select * from bookinfo");
            foreach (DataRow objRow in ds.Tables[0].Rows)//遍历数据表中的数据，查找和组合框中相同的书名
            {
                if (string.Compare(cboBookName.Text, objRow["BookName"].ToString(), true) == 0)
                {
                    this.txtBookAccessCode.Text = objRow["BookIssue"].ToString();
                    this.txtAuthor.Text = objRow["BookAuthor"].ToString();
                }
            }
        }
    }
}
