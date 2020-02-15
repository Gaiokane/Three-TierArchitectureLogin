using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;

namespace Three_TierArchitecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //新建业务逻辑对象
        UserManager manager = new UserManager();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            string pwd = txtUserPwd.Text;
            User user = new User { UserName = name, UserPwd = pwd };
            bool result = manager.Login(user);
            if (result)
            {
                MessageBox.Show("登录成功！");
            }
            else
            {
                MessageBox.Show("登录失败！");
            }
        }
    }
}