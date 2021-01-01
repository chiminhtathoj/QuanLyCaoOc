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
    public partial class frmAdmin : Form
    {
        BindingSource CustomerBinding = new BindingSource();
        BindingSource AccountBinding = new BindingSource();
        public AccountDTO LoginAccount;
        public frmAdmin()
        {
            InitializeComponent();
            dtgvCustomer.DataSource = CustomerBinding;
            dtgvAccount.DataSource = AccountBinding;
            LoadListCustomer();
            LoadListAccount();
            AddCustomerBinding();
            AddAccountBinding();
        }

        void LoadListCustomer()
        {
            CustomerBinding.DataSource = CustomerDAO.Instance.GetListCustomer(); // dùng custombiding để khi load lại không bị lỗi
            dtgvCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvCustomer.Columns[dtgvCustomer.ColumnCount - 4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;// cho dtgv vừa khung hình 
            dtgvCustomer.Columns[1].HeaderText = "Họ và tên";
            dtgvCustomer.Columns[2].HeaderText = "Số điện thoại";
            dtgvCustomer.Columns[4].HeaderText = "Ngày sinh";
            dtgvCustomer.Columns[3].HeaderText = "Giới tính";
            dtgvCustomer.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy"; // chỉnh format hiển thị ngày thành dd/mm
            foreach (DataGridViewColumn col in dtgvCustomer.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
        void AddCustomerBinding()
        {
            dtpDOBCus.Format = DateTimePickerFormat.Custom;
            dtpDOBCus.CustomFormat = "dd/MM/yyyy";//sửa định dạng 
            txtIDCUS.DataBindings.Add(new Binding("text", dtgvCustomer.DataSource, "MaKH",true,DataSourceUpdateMode.Never)); // DataSourceUpdateMode.Never để không lưu lúc chọn textbox
            txtNameCus.DataBindings.Add(new Binding("text", dtgvCustomer.DataSource, "TenKH",true, DataSourceUpdateMode.Never));
            cbbSexCus.DataBindings.Add(new Binding("text", dtgvCustomer.DataSource, "GioiTinhKH",true,DataSourceUpdateMode.Never));
            txtPhoneCus.DataBindings.Add(new Binding("text", dtgvCustomer.DataSource, "SDTKH", true, DataSourceUpdateMode.Never));
            dtpDOBCus.DataBindings.Add(new Binding("text", dtgvCustomer.DataSource, "NgaySinhKH", true, DataSourceUpdateMode.Never)); //Thêm true để format theo dtgv
            
        }
        void LoadListAccount()
        {
            AccountBinding.DataSource = AccountDAO.Instance.GetListAccount();
            dtgvAccount.Columns[0].HeaderText = "Tên đăng nhập";
            dtgvAccount.Columns[1].HeaderText = "Quyền hạn";
            foreach (DataGridViewColumn col in dtgvAccount.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
        void AddAccountBinding()
        {
            txtUserName.DataBindings.Add(new Binding("text", dtgvAccount.DataSource, "TenDangNhap", true, DataSourceUpdateMode.Never));
            cbbUserType.DataBindings.Add(new Binding("text", dtgvAccount.DataSource, "Loai", true, DataSourceUpdateMode.Never));

        }
        private void BtnLoadCus_Click(object sender, EventArgs e)
        {
            LoadListCustomer();
        }

        private void btnInsertCus_Click(object sender, EventArgs e)
        {
            string name = txtNameCus.Text;
            int phone = 0;
            int.TryParse(txtPhoneCus.Text,out phone); // không dùng tryparse sẻ lỗi
            DateTime DOB = dtpDOBCus.Value;
            string sex = cbbSexCus.Text;
            if (string.IsNullOrWhiteSpace(txtNameCus.Text)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng điền tên", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhoneCus.Text))
            {
                MessageBox.Show("Vui lòng điền Số điện thoại", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(dtpDOBCus.Value.ToString()))
            {
                MessageBox.Show("Vui lòng chọn ngày sinh", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(cbbSexCus.Text))
            {
                MessageBox.Show("Vui lòng chọn giới tính", "thông báo");
                return;
            }

            if (CustomerDAO.Instance.InsertCus(name, phone, DOB, sex))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadListCustomer();
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo");
        }

        private void btnEditCus_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtIDCUS.Text,out id);
            string name = txtNameCus.Text;
            int phone = 0;
            int.TryParse(txtPhoneCus.Text,out phone);
            DateTime DOB = dtpDOBCus.Value;
            string sex = cbbSexCus.Text;
            if (string.IsNullOrWhiteSpace(txtNameCus.Text) || string.IsNullOrWhiteSpace(txtIDCUS.Text) || string.IsNullOrWhiteSpace(dtpDOBCus.Value.ToString()) ||
                string.IsNullOrWhiteSpace(txtPhoneCus.Text) || string.IsNullOrWhiteSpace(cbbSexCus.Text)) // check các textbox phải điền đầy đủ mới cho sửa 
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần sửa", "thông báo");
                return;
            }
            if (CustomerDAO.Instance.UpdateCus(id,name, phone, DOB, sex))
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
                LoadListCustomer();
            }
            else
                MessageBox.Show("Sửa thất bại", "Thông báo");
        }

        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
            int id = 0;
            int.TryParse(txtIDCUS.Text,out id);
            if (string.IsNullOrWhiteSpace(txtNameCus.Text) || string.IsNullOrWhiteSpace(txtIDCUS.Text) || string.IsNullOrWhiteSpace(dtpDOBCus.Value.ToString()) ||
                string.IsNullOrWhiteSpace(txtPhoneCus.Text) || string.IsNullOrWhiteSpace(cbbSexCus.Text)) // check các textbox phải điền đầy đủ mới cho sửa 
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa", "thông báo");
                return;
            }
            BillInfoDAO.Instance.DeleteBillInfoByListCustomerID(id);
            BillDAO.Instance.DeleteBillByCustomerID(id);
            ContractRenewal_InfoDAO.Instance.DeleteListContractRenewal_InfoByCustomerID(id);
            ContractRental_InfoDAO.Instance.DeleteListContractRental_InfoByCustomerID(id);
            ContractRenewalDAO.Instance.DeteleContractRenewalByCustomerID(id);
            ContractRentalDAO.Instance.DeteleContractRentalByCustomerID(id);
            if (CustomerDAO.Instance.DeleteCus(id))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadListCustomer();
            }
            else
                MessageBox.Show("Xóa thất bại", "Thông báo");
        }

        private void btnLoadUser_Click(object sender, EventArgs e)
        {
            LoadListAccount();
        }

        private void txtPhoneCus_TextChanged(object sender, EventArgs e)//chỉ cho phép nhập số
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPhoneCus.Text, "[^0-9]"))
            {
                MessageBox.Show("Vui lòng nhập số");
                txtPhoneCus.Text = txtPhoneCus.Text.Remove(txtPhoneCus.Text.Length - 1);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string type = cbbUserType.Text;
            if (string.IsNullOrWhiteSpace(txtUserName.Text)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng điền tên", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(cbbUserType.Text))
            {
                MessageBox.Show("Vui lòng chọn loại người dùng", "thông báo");
                return;
            }
            if (AccountDAO.Instance.InsertAcc(username, type))
            {
                MessageBox.Show("Thêm thành công", "Thông báo");
                LoadListAccount();
            }
            else
                MessageBox.Show("Thêm thất bại", "Thông báo");
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            if (string.IsNullOrWhiteSpace(txtUserName.Text)) // phải chọn người xóa
            {
                MessageBox.Show("Vui lòng chọn người dùng cần xóa", "thông báo");
                return;
            }
            if (LoginAccount.TenDangNhap.Equals(
                
                ))
            {
                MessageBox.Show("Không thể tự hủy bản thân mình được!!!", "Thông báo");
                return;
            }
            if (AccountDAO.Instance.DeleteAcc(username))
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                LoadListAccount();
            }
            else
                MessageBox.Show("Xóa thất bại", "Thông báo");
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string type = cbbUserType.Text;
            if (string.IsNullOrWhiteSpace(txtUserName.Text)) // check các textbox phải điền đầy đủ mới cho thêm 
            {
                MessageBox.Show("Vui lòng chọn người dùng cần sửa", "thông báo");
                return;
            }
            if (string.IsNullOrWhiteSpace(cbbUserType.Text))
            {
                MessageBox.Show("Vui lòng chọn loại người dùng cần sửa", "thông báo");
                return;
            }
            if (AccountDAO.Instance.UpdateAcc(username, type))
            {
                MessageBox.Show("Sửa thành công", "Thông báo");
                LoadListAccount();
            }
            else
                MessageBox.Show("Sửa thất bại", "Thông báo");
        }

        private void btnResetAccPW_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            if (AccountDAO.Instance.ResetAcc(username))
            {
                MessageBox.Show("Cập nhật thành công", "Thông báo");
                LoadListAccount();
            }
            else
                MessageBox.Show("Sửa thất bại", "Thông báo");
        }
        List<CustomerDTO> SearchCusByName(string name)
        {
            List<CustomerDTO> listCus =CustomerDAO.Instance.SearchCusomterByName(name);
            return listCus;
        }

        private void btnSearchCus_Click(object sender, EventArgs e)
        {
           CustomerBinding.DataSource= SearchCusByName(txtSearchCus.Text);
           
        }

        DataTable SearchAccByName(string name)
        {
            return AccountDAO.Instance.SearchAccByUserName(name);
        }
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            AccountBinding.DataSource = SearchAccByName(txtSearchUser.Text);
        }
    }
}
