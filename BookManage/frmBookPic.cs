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
    public partial class frmBookPic : Form
    {
        private int id;//声明整型变量
        public frmBookPic()
        {
            InitializeComponent();
        }

        public void ShowContent(int bookid, string pic)//将frmUpdateBook中选定的图片信息显示出来
        {
            id = bookid;
            this.txtPic.Text = pic;
            if (pic != string.Empty)
            {
                this.pbBook.Image = Image.FromFile(this.txtPic.Text);
            }
        }

        private void btnPic_Click(object sender, EventArgs e)//修改封面
        {
            if (ofdFile.ShowDialog() == DialogResult.OK)
            {
                this.txtPic.Text = ofdFile.FileName;//图片路径显示在文本框中
                this.pbBook.Image = Image.FromFile(txtPic.Text);//显示图片 
            }
        }

        private void btnUpdatePic_Click(object sender, EventArgs e)//更新封面
        {
            if (DataAccess.UpdateDataTable("update bookinfo set BookPic='" + txtPic.Text + "' where BookID=" + id))
            {
                MessageBox.Show("更新成功", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("添加失败","提示",MessageBoxButtons.OK);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)//取消
        {
            this.Close();
        }
    }
}
