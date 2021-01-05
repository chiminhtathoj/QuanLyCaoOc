using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace QuanLyCaoOc
{
    public partial class frmMain : Form
    {
        public delegate List<RoomDTO> del_ListRoom(List<RoomDTO> list);
        public del_ListRoom GetListRoom;
        List<RoomDTO> ListRoomGB = new List<RoomDTO>();

        public frmMain()
        {
            InitializeComponent();

        }
        public frmMain(AccountDTO acc)
        {
            InitializeComponent();
            this.LoginAcc = acc;
            cbbFloor.SelectedItem = "1";
            //ChangeAccount(acc.Loai);
        }
        private AccountDTO LoginAcc;

        public AccountDTO LoginAcc1 { get => LoginAcc; set => LoginAcc = value; }

        void LoadRoom(int floor)
        {
            CultureInfo culture = new CultureInfo("vi-VN"); //Chuyển culture về VN
            Thread.CurrentThread.CurrentCulture = culture; // chỉ dùng trong thread này
            flpRoom.Controls.Clear();
            List<RoomDTO> RoomList = RoomDAO.Instance.LoadRoomList();
            foreach (RoomDTO item in RoomList)
            {
                if (item.Tang == floor)
                {

                    Button btn = new Button() { Width = RoomDAO.width, Height = RoomDAO.height };
                    btn.Text = item.MaPhong + "\n" + item.TinhTrang;
                    btn.Click += Btn_Click;
                    btn.Tag = item;
                    switch (item.TinhTrang)
                    {
                        case "Trống":
                            btn.BackColor = Color.Green;
                            break;
                        default:
                            btn.BackColor = Color.Red;
                            btn.Click -= Btn_Click;
                            break;
                    }
                    flpRoom.Controls.Add(btn);

                }
            }
        }
        List<RoomDTO> ShowListRoomRent(string id)
        {
            List<RoomDTO> listRoom = new List<RoomDTO>();
            DataTable data = RoomDAO.Instance.GetRoomByRoomid(int.Parse(id));
            

            foreach (DataRow item in data.Rows)
            {
                RoomDTO room = new RoomDTO(item);
                listRoom.Add(room);
                
            }
            
            foreach (RoomDTO item in listRoom)
            {
                bool found = false;
                foreach (ListViewItem item1 in lvRoom.Items) // nếu phòng đả có trong danh sách thì cho người dùng nhập lại
                {
                    if (item1.Text == item.MaPhong.ToString())
                    {
                        found = true;
                        MessageBox.Show("Phòng đả có trong danh sách thuê,vùi lòng chọn phòng khác!");
                        break;
                    }
                }
                if (!found)
                {
                    ListViewItem lvItem = new ListViewItem(item.MaPhong.ToString());
                    float Price = item.GiaCoBan + item.SoChoLamViec * 200000 + item.Tang * 500000;
                    lvItem.SubItems.Add(item.Tang.ToString());
                    lvItem.SubItems.Add(item.DTSuDung.ToString());
                    lvItem.SubItems.Add(item.SoChoLamViec.ToString());
                    lvItem.SubItems.Add(Price.ToString("c"));
                    lvRoom.Items.Add(lvItem);
                }
                //ListViewItem lvItem = new ListViewItem(item.MaPhong.ToString()); =>>> không biết sao lỗi 
                //if (lvRoom.FindItemWithText(item.MaPhong.ToString()) == null)
                //{
                //    float Price = item.GiaCoBan + item.SoChoLamViec * 200000 + item.Tang * 500000;
                //    lvItem.SubItems.Add(item.Tang.ToString());
                //    lvItem.SubItems.Add(item.DTSuDung.ToString());
                //    lvItem.SubItems.Add(item.SoChoLamViec.ToString());
                //    lvItem.SubItems.Add(Price.ToString("c"));
                //    lvRoom.Items.Add(lvItem);
                //}
                //else
                //    MessageBox.Show("Phòng đả có trong danh sách vui lòng chọn phòng khác!");
              
            }
            ListRoomGB.AddRange(listRoom);
            CalSumMoney();
            return listRoom;
        }
        void CalSumMoney()
        {
            float TotalPrice = 0;
            foreach (RoomDTO item in ListRoomGB)
            {
                TotalPrice += (item.GiaCoBan + item.SoChoLamViec * 200000 + item.Tang * 500000);
            }
            txtTotalPrice.Text = TotalPrice.ToString("c");
        }
        void ChangeAccount(string type)
        {
            adminToolStripMenuItem.Enabled = type == "Admin";
            TaiKhoanToolStripMenuItem.Text += " (" + LoginAcc1.TenDangNhap + ") ";
        }
        private void cbbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoom(Convert.ToInt32(cbbFloor.SelectedItem));
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int RoomID=((sender as Button).Tag as RoomDTO).MaPhong;
            txtIDRoom.Text = RoomID.ToString();
            txtAera.Text = ((sender as Button).Tag as RoomDTO).DTSuDung.ToString();
            txtNOW.Text = ((sender as Button).Tag as RoomDTO).SoChoLamViec.ToString();
            txtAddress.Text= RoomDAO.Instance.GetAddressBuildingByRoomID(RoomID);
        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfile f = new frmProfile(LoginAcc);
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin f = new frmAdmin();
            f.LoginAccount = LoginAcc;
            f.ShowDialog();
        }
        public List<RoomDTO> GetListCurrentRoom(List<RoomDTO> list)
        {
            return list;
        }
        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRent f = new frmRent();
            GetListRoom += new del_ListRoom(f.LoadRoomListRoom);
            GetListRoom(ListRoomGB);
            f.ShowDialog();
            this.Show();
        }

        private void btnAddListRoomRent_Click(object sender, EventArgs e)
        {
               ShowListRoomRent(txtIDRoom.Text);
        }

        private void btnResetLV_Click(object sender, EventArgs e)
        {
            lvRoom.Items.Clear();
            ListRoomGB.Clear();
            CalSumMoney();
        }

        private void btnDeleteOneLV_Click(object sender, EventArgs e) // xóa phòng đả chọn muốn thuê trong LV
        {
            for (int i = lvRoom.Items.Count - 1; i >= 0; i--)
            {
                if (lvRoom.Items[i].Selected)
                {
                    lvRoom.Items[i].Remove();
                    ListRoomGB.RemoveAt(i); // xóa luôn trong listroomGB
                }
            }
            MessageBox.Show(ListRoomGB.Count.ToString());
            CalSumMoney();
        }
    }
}
