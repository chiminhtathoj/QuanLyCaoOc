﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace QuanLyCaoOc
{
    public partial class frmMain : Form
    {
        public delegate void del_Room(int id);
        public del_Room GetIdRoom;
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
        void ShowInfo(int id)
        {
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
        public int GetCurrentRoomID()
        {
            int id = 0;
            if (int.TryParse(txtIDRoom.Text, out id))
                return id;
            else
                return -1;
        }
        private void btnBookRoom_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRent f = new frmRent();
            GetIdRoom += new del_Room(f.LoadRoomByID);
            GetIdRoom(GetCurrentRoomID());
            f.ShowDialog();
            this.Show();
        }
    }
}
