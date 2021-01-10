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
    public partial class frmRent : Form
    {
        BindingSource CustomerBinding = new BindingSource();
        List<RoomDTO> listRoom = new List<RoomDTO>();
        public frmRent()
        {
            InitializeComponent();
            dtgvListCusRent.DataSource = CustomerBinding;
            LoadListCustomer();
            AddCustomerBinding();
        }
        
        public List<RoomDTO> LoadRoomListRoom(List<RoomDTO> list)
        {
            double TotalPrice = 0;
            foreach (RoomDTO item in list)
            {
                TotalPrice +=(item.GiaCoBan + (double)item.SoChoLamViec * 200000 + (double)item.Tang * 500000);
                txtIDRent.Text += item.MaPhong +",";
            }
            txtPriceRent.Text = TotalPrice.ToString();
            txtIDContractRent.Text = (ContractRentalDAO.Instance.GetMaxIDRental()+1).ToString();
            CalSumMoneyrent();
            listRoom = list;
            return list;
        }
        double CalSumMoneyrent()
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            double money = double.Parse(txtPriceRent.Text.ToString());
            double nudValue = double.Parse(nudRentalPeriod.Value.ToString());
            double SumMoney = money * nudValue;
            txtMoney.Text = SumMoney.ToString("c", culture);
            return SumMoney;
        }
        void LoadListCustomer()
        {
            dtgvBill.Visible = false;
            dtpFirstPay.Format = DateTimePickerFormat.Custom;
            dtpFirstPay.CustomFormat = "dd/MM/yyyy";//sửa định dạng 
            dtpValidityConTract.Format = DateTimePickerFormat.Custom;
            dtpValidityConTract.CustomFormat = "dd/MM/yyyy";//sửa định dạng 
            CustomerBinding.DataSource = CustomerDAO.Instance.GetListCustomer(); // dùng custombiding để khi load lại không bị lỗi
            dtgvListCusRent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtgvListCusRent.Columns[dtgvListCusRent.ColumnCount - 4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;// cho dtgv vừa khung hình 
            dtgvListCusRent.Columns[1].HeaderText = "Họ và tên";
            dtgvListCusRent.Columns[2].HeaderText = "Số điện thoại";
            dtgvListCusRent.Columns[4].HeaderText = "Ngày sinh";
            dtgvListCusRent.Columns[3].HeaderText = "Giới tính";
            dtgvListCusRent.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy"; // chỉnh format hiển thị ngày thành dd/mm
            foreach (DataGridViewColumn col in dtgvListCusRent.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
            }
        }
        List<CustomerDTO> SearchCusByName(string name)
        {
            List<CustomerDTO> listCus = CustomerDAO.Instance.SearchListCusomterByName(name);
            return listCus;
        }

        void AddCustomerBinding()
        {
            txtIDCusRent.DataBindings.Add(new Binding("text", dtgvListCusRent.DataSource, "MaKH", true, DataSourceUpdateMode.Never)); // DataSourceUpdateMode.Never để không lưu lúc chọn textbox
            txtNameCusRent.DataBindings.Add(new Binding("text", dtgvListCusRent.DataSource, "TenKH", true, DataSourceUpdateMode.Never));
        }
        private void btnCusRent_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            f.ShowDialog();
            this.Show();
        }

        private void btnSearchCusRent_Click(object sender, EventArgs e)
        {
            CustomerBinding.DataSource = SearchCusByName(txtNameCusRent.Text);
        }

        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            
            if (txtNameCusRent != null && !string.IsNullOrWhiteSpace(txtNameCusRent.Text))
            {
                int idCus = 0;
                int.TryParse(txtIDCusRent.Text, out idCus);
                DateTime ValidityConTract = dtpValidityConTract.Value;
                DateTime FirstPay = dtpFirstPay.Value;
                int RentalPeriod = int.Parse(nudRentalPeriod.Value.ToString());
                double SumOfMoney = CalSumMoneyrent();
                if (ContractRentalDAO.Instance.InsertContractRent(ValidityConTract, FirstPay, idCus))
                // tạo chi tiết hợp đồng thuê phòng cho mỗi phòng,và hóa đơn thanh toán
                {
                    if (BillDAO.Instance.InsertBill(FirstPay, "Tiền Phòng", SumOfMoney, idCus))
                    {


                        foreach (var item in listRoom)
                        {
                            DateTime expiraionDate = ValidityConTract.AddMonths(RentalPeriod);
                            double price = (item.GiaCoBan + item.SoChoLamViec * 200000 + item.Tang * 500000);
                            ContractRental_InfoDAO.Instance.InsertContractRentInfo(RentalPeriod, price, item.MaPhong, ContractRentalDAO.Instance.GetMaxIDRental(), expiraionDate);// thêm chi tiết hợp đồng TP cho từng phòng
                            BillInfoDAO.Instance.InsertBillInfoWithoutIDRenewal(BillDAO.Instance.GetMaxIDBill(), ContractRentalDAO.Instance.GetMaxIDRental());//Thêm chỉ tiết hóa đơn cho mỗi phòng thanh toán
                        }
                        MessageBox.Show("Tạo hợp đồng thành công!");
                        DialogResult dialog = MessageBox.Show("Bạn có muốn in hóa đơn không?", "In hóa đơn", MessageBoxButtons.YesNo);
                        if(dialog == DialogResult.Yes)
                        {
                            DGVPrinter printer = new DGVPrinter();
                            dtgvBill.DataSource = BillDAO.Instance.GetBillByBillID(BillDAO.Instance.GetMaxIDBill());
                            dtgvBill.Columns[0].HeaderText = "Mã hóa đơn";
                            dtgvBill.Columns[1].HeaderText = "Ngày thanh toán";
                            dtgvBill.Columns[2].HeaderText = "Lý do thanh toán";
                            dtgvBill.Columns[3].HeaderText = "Tổng tiền thanh toán";
                            dtgvBill.Columns[4].HeaderText = "Mã khách hàng";
                            foreach (DataGridViewColumn col in dtgvBill.Columns)
                            {
                                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter; //căn lề giữ cho tiêu đề
                            }
                            printer.Title= " \r\n\r\r Hóa đơn thanh toán hợp đồng thuê phòng\r\n\r\n  ";
                            printer.SubTitle = "Tên khách hàng:    " + txtNameCusRent.Text.ToString();
                            printer.PageNumbers = true;
                            printer.PageNumberInHeader = false;
                            printer.PorportionalColumns = true;
                            printer.HeaderCellAlignment = StringAlignment.Near;
                            printer.PrintDataGridView(dtgvBill);
                        }
                        else if (dialog == DialogResult.No)
                        {
                        }
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần thuê phòng!");
            }

        }

        private void nudRentalPeriod_ValueChanged(object sender, EventArgs e)
        {
            CalSumMoneyrent();  
        }

        private void dtgvListCusRent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpValidityConTract_ValueChanged(object sender, EventArgs e)
        {
            if(dtpValidityConTract.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Vui lòng chọn thời gian hiệu lực lớn hơn hiện tại!");
                dtpValidityConTract.Value = DateTime.Now;
            }
        }

        private void dtpFirstPay_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFirstPay.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Vui lòng chọn thời gian thanh toán đầu tiên lớn hơn hiện tại!");
                dtpFirstPay.Value = DateTime.Now;
            }
        }
    }
}
