using DAO;
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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            LoadListCustomer();
            AddCustomerBinding();
        }

        void LoadListCustomer()
        {
            dtgvCustomer.DataSource = CustomerDAO.Instance.GetListCustomer();
            dtgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvCustomer.Columns[dtgvCustomer.ColumnCount - 4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;// cho dtgv vừa khung hình 
            //dtgvCustomer.Columns[1].HeaderText = "Họ và tên";
            //dtgvCustomer.Columns[2].HeaderText = "Số điện thoại";
            //dtgvCustomer.Columns[3].HeaderText = "Ngày sinh";
            //dtgvCustomer.Columns[4].HeaderText = "Giới tính";
          
            //foreach (DataGridViewColumn col in dtgvCustomer.Columns)
            //{
            //    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            //}
        }
        void AddCustomerBinding()
        {
            dtgvCustomer.Columns[0].DataPropertyName="MaKH";
            txtSexCus.DataBindings.Clear();
            txtSexCus.DataBindings.Add("text", dtgvCustomer,"MaKH");
        }
        private void BtnLoadCus_Click(object sender, EventArgs e)
        {
            LoadListCustomer();
        }
    }
}
