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
    public partial class frmSearchBook : Form
    {
        public frmSearchBook()
        {
            InitializeComponent();
        }

        private void frmSearchBook_Load(object sender, EventArgs e)//窗体载入时事件处理
        {
            //this.bookinfoTableAdapter.Fill(this.bookManageDataSet.bookinfo);//将数据加载到表“bookManageDataSet.bookinfo”中。
            #region 图书类别组合框初始化
            DataSet Myds = DataAccess.GetDataSetBySql("select distinct BookType from bookinfo");
            DataTable table = Myds.Tables[0];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                this.cboType.Items.Add(table.Rows[i][0].ToString().Trim());
            }
            this.cboType.SelectedIndex = 0;
            this.cboOR.SelectedIndex = 0;
            this.cboAnd.SelectedIndex = 0;
            #endregion
        }

        private void btnSearch_Click(object sender, EventArgs e)//搜索
        {
            string cbo1 = this.cboOR.Text;
            string cbo2 = this.cboAnd.Text;
            string booktype = this.cboType.Text;
            string bookname = this.txtName.Text;
            string bookcontent = this.txtContent.Text;
            string sql = "select * from bookinfo where BookType='" + booktype + "' " + cbo1 + " BookName like '%" + bookname + "%' " + cbo2 + " BookContent like '%" + bookcontent + "%'";//定义sql语句
            DataSet Myds = DataAccess.GetDataSetBySql(sql);//调用GetDataSetBySql方法
            DataTable table = Myds.Tables[0];
            this.dgvSearchBook.DataSource = table;//指定数据源
        }

        private void btnClose_Click(object sender, EventArgs e)//关闭
        {
            this.Close();
        }
    }
}
