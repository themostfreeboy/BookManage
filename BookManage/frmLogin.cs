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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)//窗体载入时事件处理
        {
            this.cboUserType.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)//登陆
        {
            if (Validate())//验证通过
            {
                string state = this.cboUserType.Text;
                int num;
                if (state.Equals("管理员"))//判断用户角色
                {
                    num = 1;
                }
                else
                {
                    num = 2;
                }
                string sql = string.Format("select * from userinfo where UName='{0}' and UPwd='{1}' and UState={2}", this.txtName.Text.Trim(), this.txtPwd.Text.Trim(), num);//定义查询语句
                DataSet ds = DataAccess.GetDataSetBySql(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("登陆成功");
                    frmMain.result = DialogResult.OK;//为变量result赋值
                    this.Close();
                }
                else 
                {
                    MessageBox.Show("用户名或密码错误，请重新输入");
                }
            }
        }

        private bool Validate()//验证方法
        {
            if (this.txtName.Text != string.Empty && this.txtPwd.Text != string.Empty)
            {
                return true;
            }
            else
            {
                MessageBox.Show("用户名或者密码不能为空");
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)//取消
        {
            this.Close();
        }
    }
}
