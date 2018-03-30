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
    public partial class frmUpdateBook : Form
    {
        public frmUpdateBook()
        {
            InitializeComponent();
        }

        private void frmUpdateBook_Load(object sender, EventArgs e)//窗体载入时事件处理
        {
            this.bookinfoTableAdapter.Fill(this.bookManageDataSet.bookinfo);//将数据加载到表“bookManageDataSet.bookinfo”中。
        }

        private void btnSave_Click(object sender, EventArgs e)//保存修改
        {
            string sql = "select * from bookinfo";//sql语句
            DialogResult result = MessageBox.Show("确定要将修改保存到数据库吗？", "操作提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                DataSet ds = DataAccess.GetDataSetBySql(sql);
                DataAccess.UpdateDataSet(ds, sql);
                MessageBox.Show("保存成功");
            }
            this.dgvBookinfo.DataSource = DataAccess.GetDataSetBySql(sql).Tables[0];//DataGridView控件显示数据
        }

        private void dgvBookinfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = this.dgvBookinfo.CurrentCell.RowIndex;//获取当前鼠标单击时的行索引号
            #region 通过索引号获得值并赋予相应的文本框显示
            this.txtbID.Text = this.dgvBookinfo.Rows[index].Cells[0].Value.ToString().Trim();
            this.txtbName.Text = this.dgvBookinfo.Rows[index].Cells[1].Value.ToString().Trim();
            this.txtbType.Text = this.dgvBookinfo.Rows[index].Cells[2].Value.ToString().Trim();
            this.txtbAuthor.Text = this.dgvBookinfo.Rows[index].Cells[3].Value.ToString().Trim();
            this.txtbPrice.Text = this.dgvBookinfo.Rows[index].Cells[4].Value.ToString().Trim();
            this.txtbPic.Text = this.dgvBookinfo.Rows[index].Cells[5].Value.ToString().Trim();
            this.txtbContent.Text = this.dgvBookinfo.Rows[index].Cells[6].Value.ToString();
            this.txtbIssueID.Text = this.dgvBookinfo.Rows[index].Cells[7].Value.ToString();
            #endregion
        }

        private void btnUpdate_Click(object sender, EventArgs e)//更新，在执行此函数的DataAccess.UpdateDataTable(sql)语句时数据库中的内容已经修改，只是DataGridView中的内容未更新而已，点击保存修改按钮触发对应的消息处理函数进行DataGridView中的内容更新，而无论是否点击保存修改，无论在保存修改中是否确认修改，数据库中的数据已经修改完毕。(个人感觉此为此例程bug)
        {
            string bookname = this.txtbName.Text.ToString();
            string booktype = this.txtbType.Text.ToString();
            string bookauthor = this.txtbAuthor.Text.ToString();
            Double bookprice = Convert.ToDouble(this.txtbPrice.Text);
            string bookpic = this.txtbPic.Text.ToString();
            string bookcontent = this.txtbContent.Text.ToString();
            int bookissue = Convert.ToInt32(this.txtbIssueID.Text);
            string sql = string.Format("update bookinfo set BookName='{0}', BookType='{1}', BookAuthor='{2}', BookPrice={3}, BookPic='{4}', BookContent='{5}', BookIssue={6} where BookID={7}", bookname, booktype, bookauthor, bookprice, bookpic, bookcontent, bookissue, Convert.ToInt32(this.txtbID.Text));//sql语句
            if (DataAccess.UpdateDataTable(sql))
            {
                MessageBox.Show("更新成功", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("更新失败", "提示", MessageBoxButtons.OK);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)//删除
        {
            DataSet ds = DataAccess.GetDataSetBySql("select * from issueinfo where BookID=" + Convert.ToInt32(this.txtbID.Text));
            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("此书有借阅，不能删除");
                return;
            }
            else
            {
                string sql = "delete from bookinfo where BookID=" + this.txtbID.Text;//sql语句
                if (DataAccess.UpdateDataTable(sql))
                {
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("删除失败", "提示", MessageBoxButtons.OK);
                }
            }
            this.txtbID.Text = "";
            this.txtbType.Text = "";
            this.txtbName.Text = "";
            this.txtbAuthor.Text = "";
            this.txtbPrice.Text = "";
            this.txtbPic.Text = "";
            this.txtbContent.Text = "";
            this.txtbIssueID.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)//关闭
        {
            this.Close();
        }

        private void btnUpdatePic_Click(object sender, EventArgs e)//更新封面
        {
            string pic = this.txtbPic.Text.ToString();
            int bookid = Convert.ToInt32(this.txtbID.Text);//记录该条数据的主键值
            frmBookPic bookpic = new frmBookPic();//实例化封面查看窗体
            bookpic.ShowContent(bookid, pic);//调用封面查看窗体中的方法
            bookpic.ShowDialog();//封面查看窗体以模式对话框方式打开
        }
    }
}
