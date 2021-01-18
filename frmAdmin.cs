using BUS;
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
            CustomerBUS.Instance.LoadCustomerList(dtgvCustomer, CustomerBinding);
            AddCustomerBinding();
            AccountBUS.Instance.LoadListAccount(dtgvAccount, AccountBinding);
            AddAccountBinding();
            BillBUS.Instance.LoadListBill(dtgvBill,BillBinding);
            AddBillBinding();
            ContractRenewalBUS.Instance.LoadListRenewal(dtgvListCusRenewal, CustomerRenewaBinding, cbbReasonRenewal, txtIDRenewal);
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
<<<<<<< HEAD
        #region Customer
=======
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
>>>>>>> parent of 901d7c9... Hoàn thành các chức năng cơ bản
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
            CustomerBUS.Instance.LoadCustomerList(dtgvCustomer, CustomerBinding);
        }
        private void btnInsertCus_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
=======
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
>>>>>>> parent of 901d7c9... Hoàn thành các chức năng cơ bản
            if (string.IsNullOrWhiteSpace(txtPhoneCus.Text))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại");
                return;
            }
            CustomerBUS.Instance.InsertCus(dtgvCustomer, CustomerBinding, txtNameCus.Text, txtPhoneCus.Text, dtpDOBCus.Value, cbbSexCus.Text);
        }

        private void btnEditCus_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            CustomerBUS.Instance.EditCus(dtgvCustomer, CustomerBinding, txtIDCUS.Text, txtNameCus.Text, txtPhoneCus.Text, dtpDOBCus.Value, cbbSexCus.Text);
=======
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
>>>>>>> parent of 901d7c9... Hoàn thành các chức năng cơ bản
        }

        private void btnDeleteCus_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            CustomerBUS.Instance.DeleteCus(dtgvCustomer, CustomerBinding, txtIDCUS.Text, txtNameCus.Text, txtPhoneCus.Text, dtpDOBCus.Value, cbbSexCus.Text);
        }
        private void btnSearchCus_Click(object sender, EventArgs e)
        {
            CustomerBinding.DataSource = CustomerBUS.Instance.SearchListCusByName(txtSearchCus.Text);
        }
        
        private void txtPhoneCus_KeyPress(object sender, KeyPressEventArgs e) // chỉ nhập số 0-9
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void txtPhoneCus_Leave(object sender, EventArgs e) // khác 10 số thì reset
        {
            if (txtPhoneCus.Text.Length != 10)
            {
                txtPhoneCus.Clear();
                MessageBox.Show("Vui lòng nhập 10 số");
            }
        }
        #endregion
        #region Bill
    
        void AddBillBinding()
        {
            txtIDBill.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "MaHoaDon", true, DataSourceUpdateMode.Never));
            txtIDCusBill.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "MaKH", true, DataSourceUpdateMode.Never));
            txtPaymentReason.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "LyDoTT", true, DataSourceUpdateMode.Never));
            txtTotalPayment.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "TongTienThanhToan", true, DataSourceUpdateMode.Never));
            //cbbUserType.DataBindings.Add(new Binding("text", dtgvBill.DataSource, "Loai", true, DataSourceUpdateMode.Never));
        }
        private void btnLoadListBill_Click(object sender, EventArgs e)
        {
            BillBUS.Instance.LoadListBill(dtgvBill,BillBinding);
        }

        private void btnSearchBill_Click(object sender, EventArgs e)
        {
            BillBinding.DataSource = BillBUS.Instance.SearchBillByID(int.Parse(txtSearchBill.Text.ToString()));
        }

      

        #endregion
        #region Account
        //void LoadListAccount()
        //{
        //    AccountBinding.DataSource = AccountDAO.Instance.GetListAccount();
        //    dtgvAccount.Columns[0].HeaderText = "Tên đăng nhập";
        //    dtgvAccount.Columns[1].HeaderText = "Quyền hạn";
        //    foreach (DataGridViewColumn col in dtgvAccount.Columns)
        //    {
        //        col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
        //    }
        //}
        void AddAccountBinding()
        {
            txtUserName.DataBindings.Add(new Binding("text", dtgvAccount.DataSource, "TenDangNhap", true, DataSourceUpdateMode.Never));
            cbbUserType.DataBindings.Add(new Binding("text", dtgvAccount.DataSource, "Loai", true, DataSourceUpdateMode.Never));

        }
=======
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

>>>>>>> parent of 901d7c9... Hoàn thành các chức năng cơ bản
        private void btnLoadUser_Click(object sender, EventArgs e)
        {
            AccountBUS.Instance.LoadListAccount(dtgvAccount, AccountBinding);
        }

        

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AccountBUS.Instance.AddAccount(dtgvAccount, AccountBinding, txtUserName.Text, cbbUserType.Text);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            AccountBUS.Instance.DeleteAccount(dtgvAccount, AccountBinding, txtUserName.Text,LoginAccount);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            AccountBUS.Instance.EditAccount(dtgvAccount, AccountBinding, txtUserName.Text, cbbUserType.Text);
        }

        private void btnResetAccPW_Click(object sender, EventArgs e)
        {
            AccountBUS.Instance.ResetAccount(dtgvAccount, AccountBinding, txtUserName.Text);
        }
        List<CustomerDTO> SearchListCusByName(string name)
        {
            List<CustomerDTO> listCus =CustomerDAO.Instance.SearchListCusomterByName(name);
            return listCus;
        }

<<<<<<< HEAD
=======
        private void btnSearchCus_Click(object sender, EventArgs e)
        {
           CustomerBinding.DataSource= SearchListCusByName(txtSearchCus.Text);
        }

        DataTable SearchAccByName(string name)
        {
            return AccountDAO.Instance.SearchAccByUserName(name);
        }
>>>>>>> parent of 901d7c9... Hoàn thành các chức năng cơ bản
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            AccountBinding.DataSource =AccountBUS.Instance.SearchAccByName(txtSearchUser.Text);
        }

<<<<<<< HEAD
        #endregion
        #region Renewal

        
=======
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
>>>>>>> parent of 901d7c9... Hoàn thành các chức năng cơ bản
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
            CustomerRenewaBinding.DataSource = CusRenewal_InfoBUS.Instance.SearchCusRenewal_InfoByListCus(txtNameCusRenewal.Text);
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
<<<<<<< HEAD
            int RenewalPeriod = int.Parse(nudRenewalPeriod.Value.ToString());
            if (nudRenewalPeriod.Value == 0 && cbbReasonRenewal.SelectedItem.ToString() == "Tiền phòng")
            {
                MessageBox.Show("Vui lòng chọn tháng cần gia hạn!");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtUtilityBills.Text) && cbbReasonRenewal.SelectedItem.ToString() == "Tiền điện nước")
            {
                MessageBox.Show("Vui lòng nhập tổng tiền điện nước!");
                return;
            }
            else
            {
                ContractRenewalBUS.Instance.AddRenewal(DateRenewal, idCus, cbbReasonRenewal, SumOfMoney, RenewalPeriod, idRoom, idRenewal, dtgvPrintBillRenewal, txtNameCusRenewal);
                this.Close();
            }

        }

        private void cbbReasonRenewal_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbbReasonRenewal.SelectedItem.ToString() == "Tiền phòng") // nếu cbb có giá trị là tiền phòng thì sẻ disable tiền điện nước
            {
                nudRenewalPeriod.Enabled = true;
                txtUtilityBills.Enabled = false;
            }
            else
            {
                nudRenewalPeriod.Enabled = false;
                txtUtilityBills.Enabled = true;
            }
        }
        private void txtIDRoomRenewal_TextChanged(object sender, EventArgs e)
        {
            CalSumMoneyRenewal();
        }
        private void txtUtilityBills_TextChanged(object sender, EventArgs e)
        {
            CalSumMoneyRenewal();
        }

        private void txtUtilityBills_KeyPress(object sender, KeyPressEventArgs e)
        {
            //chỉ cho phép nhập kiểu float 
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }
        private void dtpDateContractRenewal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpDateContractRenewal.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Vui lòng chọn thời gian thanh toán đầu tiên lớn hơn hiện tại!");
                dtpDateContractRenewal.Value = DateTime.Now;
            }
        }


        #endregion
        #region EmptyRoom
        void LoadListRoomEmpty()
        {
            dtgvListRoomEmpty.DataSource = RoomDAO.Instance.GetListRoomEmpty();
            dtgvListRoomEmpty.Columns[0].HeaderText = "Mã phòng";
            dtgvListRoomEmpty.Columns[1].HeaderText = "Diện tích sử dụng(m²)";
            dtgvListRoomEmpty.Columns[2].HeaderText = "Giá cơ bản (vnđ)";
            dtgvListRoomEmpty.Columns[3].HeaderText = "Tầng";
            dtgvListRoomEmpty.Columns[4].HeaderText = "Số chổ làm việc";
            dtgvListRoomEmpty.Columns[5].HeaderText = "Tình trạng";
            dtgvListRoomEmpty.Columns[6].HeaderText = "Mã cao ốc";
            foreach (DataGridViewColumn col in dtgvListRoomEmpty.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
        #endregion
        #region RentedRoom
        void LoadListRoomRented()
        {
            dtgvListRoomRented.DataSource = RoomDAO.Instance.GetListRoomRented();
            dtgvListRoomRented.Columns[0].HeaderText = "Mã phòng";
            dtgvListRoomRented.Columns[1].HeaderText = "Diện tích sử dụng(m²)";
            dtgvListRoomRented.Columns[2].HeaderText = "Giá cơ bản (vnđ)";
            dtgvListRoomRented.Columns[3].HeaderText = "Tầng";
            dtgvListRoomRented.Columns[4].HeaderText = "Số chổ làm việc";
            dtgvListRoomRented.Columns[5].HeaderText = "Tình trạng";
            dtgvListRoomRented.Columns[6].HeaderText = "Mã cao ốc";
            foreach (DataGridViewColumn col in dtgvListRoomRented.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
        #endregion
        #region RentalExpires
        void LoadListRoomRentalExpiresInMonth()
        {
            dtgvListRoomRentalExpires.DataSource = RoomDAO.Instance.GetListRoomRentalExpires();
            dtgvListRoomRentalExpires.Columns[0].HeaderText = "Mã phòng";
            dtgvListRoomRentalExpires.Columns[1].HeaderText = "Diện tích sử dụng(m²)";
            dtgvListRoomRentalExpires.Columns[2].HeaderText = "Giá cơ bản (vnđ)";
            dtgvListRoomRentalExpires.Columns[3].HeaderText = "Tầng";
            dtgvListRoomRentalExpires.Columns[4].HeaderText = "Số chổ làm việc";
            dtgvListRoomRentalExpires.Columns[5].HeaderText = "Tình trạng";
            dtgvListRoomRentalExpires.Columns[6].HeaderText = "Mã cao ốc";
            foreach (DataGridViewColumn col in dtgvListRoomRentalExpires.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }

        #endregion

       
=======
            ContractRenewalDAO.Instance.InsertContractRenewal(DateRenewal, idCus);
            BillDAO.Instance.InsertBill(DateTime.Now, cbbReasonRenewal.Text.ToString(), SumOfMoney, idCus);
        }
>>>>>>> parent of 901d7c9... Hoàn thành các chức năng cơ bản
    }
}
