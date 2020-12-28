using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCaoOc
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?","Thông báo",MessageBoxButtons.OKCancel)!= System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string UserName = txtUserName.Text;
            string PassWork = txtPassWork.Text;
            if (Login(UserName, PassWork)/*true*/)
            {
                AccountDTO LoginAcc = AccountDAO.Instance.GetAccountByUserName(UserName);
                frmMain f = new frmMain(LoginAcc);
                this.Hide();
                f.ShowDialog();
                this.Show();

            }
            else
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu","Thông báo!");
        }
        bool Login(string UserName,string PassWork)
        {
            return AccountDAO.Instance.Login(UserName,PassWork);
        }
    }
}
