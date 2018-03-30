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
    public partial class frmAddBook : Form
    {
        public frmAddBook()
        {
            InitializeComponent();
        }

        private void frmAddBook_Load(object sender, EventArgs e)//窗体载入时事件处理
        {
            //this.bookinfoTableAdapter.Fill(this.bookManageDataSet.bookinfo);//将数据加载到表“bookManageDataSet.bookinfo”中。
        }

        private void btnInsertBkDt_Click(object sender, EventArgs e)//插入
        {
            if (Validate())//如果数据验证通过则调用DataAccess类的方法实现添加功能
            {

                #region 定义变量接收控件的值
                int bookid = Convert.ToInt32(this.txtID.Text);
                string bookname = this.txtName.Text.ToString();
                string booktype = this.txtType.Text.ToString();
                string bookauthor = this.txtAuthor.Text.ToString();
                string bookprice = this.txtPrice.Text.ToString();
                string bookpic = this.txtPic.Text.ToString();
                string bookcontent = this.txtContent.Text.ToString();
                int bookissue = Convert.ToInt32(this.txtIssue.Text);
                #endregion

                string sql = string.Format("insert into bookinfo values({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', {7})", bookid, bookname, booktype, bookauthor, bookprice, bookpic, bookcontent, bookissue);//sql语句
                if (DataAccess.UpdateDataTable(sql))//调用更新方法
                {
                    MessageBox.Show("添加成功", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("添加失败", "提示", MessageBoxButtons.OK); 
                }
                DataSet ds = DataAccess.GetDataSetBySql("select * from bookinfo");
                this.dataGridView1.DataSource = ds.Tables[0];//DataGridView控件显示数据
            }
        }

        private void btxExit_Click(object sender, EventArgs e)//退出
        {
            this.Close();//关闭窗体
        }

        private bool Validate()//数据验证
        { 
            if(this.txtID.Text!=string.Empty && this.txtName.Text!=string.Empty && this.txtType.Text!=string.Empty && this.txtAuthor.Text!=string.Empty && this.txtContent.Text!=string.Empty && this.txtIssue.Text!=string.Empty && this.txtPrice.Text!=string.Empty)
            {
                return true;
            }
            else
            {
                MessageBox.Show("请输入完整的信息");
            }
            return false;
        }
    }
}
