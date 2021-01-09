using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        BindingSource BillBinding = new BindingSource();
        BindingSource CustomerRenewaBinding = new BindingSource();
        public AccountDTO LoginAccount;
        public frmAdmin()
        {
            InitializeComponent();
            dtgvCustomer.DataSource = CustomerBinding;
            dtgvAccount.DataSource = AccountBinding;
            dtgvBill.DataSource = BillBinding;
            dtgvListCusRenewal.DataSource = CustomerRenewaBinding;
            LoadListCustomer();
            AddCustomerBinding();
            LoadListAccount();
            AddAccountBinding();
            LoadListBill();
            AddBillBinding();
            LoadListCustomerRenewal();
            AddCustomerRenewalBinding();
        }
        private void tcAdmin_SelectedIndexChanged(object sender, EventArgs e) // chọn accept button cho mỗi tag
        {
            if (tcAdmin.SelectedTab == tcAdmin.TabPages["tpCustomer"])
            {
                this.AcceptButton = btnSearchCus;
                txtSearchCus.Focus(); //focus textbox
            }
            else if (tcAdmin.SelectedTab == tcAdmin.TabPages["tpAccount"])
            {
                this.AcceptButton = btnSearchUser;
                txtSearchUser.Focus();
            }
            else if (tcAdmin.SelectedTab == tcAdmin.TabPages["tpBill"])
            {
                this.AcceptButton = btnSearchBill;
                txtSearchBill.Focus();
            }
            else if (tcAdmin.SelectedTab == tcAdmin.TabPages["tpContractRenewal"])
            {
                this.AcceptButton = btnSearchCusRenewa;
                txtNameCusRenewal.Focus();
            }
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
            dtgvAccount.Columns[0].HeaderText = "Tên đăng nhập";
            dtgvAccount.Columns[1].HeaderText = "Quyền hạn";
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
        void LoadListBill()
        {
            BillBinding.DataSource = BillDAO.Instance.GetListBill();
            dtgvBill.Columns[0].HeaderText = "Mã hóa đơn";
            dtgvBill.Columns[1].HeaderText = "Ngày thanh toán";
            dtgvBill.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm"; //format datetime
            dtgvBill.Columns[2].HeaderText = "Lý do thanh toán";
            dtgvBill.Columns[3].HeaderText = "Tổng tiền thanh toán";
            dtgvBill.Columns[3].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");//set culture về vn cho dtgv
            dtgvBill.Columns[3].DefaultCellStyle.Format = "c";
            foreach (DataGridViewColumn col in dtgvBill.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
        void AddBillBinding()
        {
            txtIDBill.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "MaHoaDon", true, DataSourceUpdateMode.Never));
            txtIDCusBill.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            txtPaymentReason.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "LyDoTT", true, DataSourceUpdateMode.Never));
            txtTotalPayment.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "TongTienThanhToan", true, DataSourceUpdateMode.Never));
            //cbbUserType.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "Loai", true, DataSourceUpdateMode.Never));
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
            if (LoginAccount.TenDangNhap.Equals(username))
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
        List<CustomerDTO> SearchListCusByName(string name)
        {
            List<CustomerDTO> listCus =CustomerDAO.Instance.SearchListCusomterByName(name);
            return listCus;
        }

        private void btnSearchCus_Click(object sender, EventArgs e)
        {
           CustomerBinding.DataSource= SearchListCusByName(txtSearchCus.Text);
        }

        DataTable SearchAccByName(string name)
        {
            return AccountDAO.Instance.SearchAccByUserName(name);
        }
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            AccountBinding.DataSource = SearchAccByName(txtSearchUser.Text);
        }

        private void btnLoadListBill_Click(object sender, EventArgs e)
        {
            LoadListBill();
        }

        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            BillBinding.DataSource = SearchBillByID(int.Parse(txtSearchBill.Text.ToString()));
        }

        List<BillDTO> SearchBillByID(int id)
        {
            List<BillDTO> listCus = BillDAO.Instance.SearchBillByIDBill(id);
            return listCus;
        }
        #region Renewa

        List<CusRenewal_InfoDTO> SearchCusRenewal_InfoByListCus(string name)
        {
            List<CusRenewal_InfoDTO> listCus = CusRenewal_InfoDAO.Instance.SearchListContractRenewal_InfoByListCusID(CustomerDAO.Instance.SearchListCusomterByName(name));
            return listCus;
        }
        void LoadListCustomerRenewal()
        {
            txtIDRenewal.Text = (ContractRenewalDAO.Instance.GetMaxIDRenewal() + 1).ToString();
            cbbReasonRenewal.SelectedIndex = 0; //giá trị mặc đinh cho cbb
            CustomerRenewaBinding.DataSource = CusRenewal_InfoDAO.Instance.GetListCusRenewal_Info(); // dùng custombiding để khi load lại không bị lỗi
            dtgvListCusRenewal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvListCusRenewal.Columns[dtgvListCusRenewal.ColumnCount - 4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;// cho dtgv vừa khung hình 
            dtgvListCusRenewal.Columns[0].HeaderText = "Mã khách hàng";
            dtgvListCusRenewal.Columns[1].HeaderText = "Mã phòng";
            dtgvListCusRenewal.Columns[2].HeaderText = "Mã hợp đồng thuê phòng";
            dtgvListCusRenewal.Columns[3].HeaderText = "Mã chi tiết hợp đồng thuê phòng";
            dtgvListCusRenewal.Columns[4].HeaderText = "Tên khách hàng thuê phòng";
            dtgvListCusRenewal.Columns[5].HeaderText = "Ngày hết hạn thuê phòng";
            dtgvListCusRenewal.Columns[6].HeaderText = "Giá thuê phòng mỗi tháng";

            dtgvListCusRenewal.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dtgvListCusRenewal.Columns[6].DefaultCellStyle.FormatProvider = CultureInfo.GetCultureInfo("vi-VN");//set culture về vn cho dtgv
            dtgvListCusRenewal.Columns[6].DefaultCellStyle.Format = "c";
            foreach (DataGridViewColumn col in dtgvListCusRenewal.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
        void AddCustomerRenewalBinding()
        {
            txtIDCusRenewal.DataBindings.Add(new Binding("text", dtgvListCusRenewal.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            txtNameCusRenewal.DataBindings.Add(new Binding("text", dtgvListCusRenewal.DataSource, "TenKH", true, DataSourceUpdateMode.Never));
            txtIDRoomRenewal.DataBindings.Add(new Binding("text", dtgvListCusRenewal.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
            txtPriceRenewal.DataBindings.Add(new Binding("text", dtgvListCusRenewal.DataSource, "GiaTP", true, DataSourceUpdateMode.Never));
            //cbbUserType.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "Loai", true, DataSourceUpdateMode.Never));
        }
        private void btnSearchCusRenewa_Click(object sender, EventArgs e)
        {
            CustomerRenewaBinding.DataSource = SearchCusRenewal_InfoByListCus(txtNameCusRenewal.Text);
        }
        double CalSumMoneyRenewal()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            double money = double.Parse(txtPriceRenewal.Text.ToString());
            double nudValue = double.Parse(nudRenewalPeriod.Value.ToString());
            double SumMoney = money * nudValue;
            txtTotalMoneyRenewal.Text = SumMoney.ToString("c", culture);
            return SumMoney;
        }
        private void nudRenewalPeriod_ValueChanged(object sender, EventArgs e)
        {
            CalSumMoneyRenewal();
        }


        #endregion

        private void btnRenewal_Click(object sender, EventArgs e)
        {
            DateTime DateRenewal = dtpDateContractRenewal.Value;
            int idCus = 0;
            int.TryParse(txtIDCusRenewal.Text, out idCus);
            double SumOfMoney = CalSumMoneyRenewal();
            ContractRenewalDAO.Instance.InsertContractRenewal(DateRenewal, idCus);
            BillDAO.Instance.InsertBill(DateTime.Now, cbbReasonRenewal.Text.ToString(), SumOfMoney, idCus);
        }
    }
}
