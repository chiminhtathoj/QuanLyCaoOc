using System;
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
        public frmMain()
        {
            InitializeComponent();
            LoadRoom();
        }
        #region Method
        void LoadRoom()
        {
            List<Room> RoomList = RoomDAO.Instance.LoadRoomList();
            foreach (Room item in RoomList)
            {
                Button btn = new Button() { Width = RoomDAO.width, Height = RoomDAO.height };
                btn.Text = item.ID + "\n" + item.Stt;
                switch (item.Stt)
                {
                    case "Trống":
                        btn.BackColor = Color.Green;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;
                }
                flpRoom.Controls.Add(btn);
            }
        }
        #endregion
    }
}
