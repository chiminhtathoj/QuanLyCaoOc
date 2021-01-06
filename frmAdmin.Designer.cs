
namespace QuanLyCaoOc
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpCustomer = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnLoadCus = new System.Windows.Forms.Button();
            this.btnEditCus = new System.Windows.Forms.Button();
            this.btnDeleteCus = new System.Windows.Forms.Button();
            this.btnInsertCus = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbSexCus = new System.Windows.Forms.ComboBox();
            this.dtpDOBCus = new System.Windows.Forms.DateTimePicker();
            this.txtIDCUS = new System.Windows.Forms.TextBox();
            this.txtNameCus = new System.Windows.Forms.TextBox();
            this.txtPhoneCus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnSearchCus = new System.Windows.Forms.Button();
            this.txtSearchCus = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.tpAccount = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLoadUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnResetAccPW = new System.Windows.Forms.Button();
            this.cbbUserType = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.tpBill = new System.Windows.Forms.TabPage();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtPaymentReason = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPayment = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtIDBill = new System.Windows.Forms.TextBox();
            this.txtIDCusBill = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnLoadListBill = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnSearchBill = new System.Windows.Forms.Button();
            this.txtSearchBill = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.dtgvBill = new System.Windows.Forms.DataGridView();
            this.tpContractRenewal = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            this.tcAdmin.SuspendLayout();
            this.tpCustomer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            this.tpAccount.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.tpBill.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tcAdmin);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 500);
            this.panel1.TabIndex = 0;
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpCustomer);
            this.tcAdmin.Controls.Add(this.tpAccount);
            this.tcAdmin.Controls.Add(this.tpBill);
            this.tcAdmin.Controls.Add(this.tpContractRenewal);
            this.tcAdmin.Location = new System.Drawing.Point(3, 3);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(941, 496);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpCustomer
            // 
            this.tpCustomer.Controls.Add(this.panel2);
            this.tpCustomer.Location = new System.Drawing.Point(4, 22);
            this.tpCustomer.Name = "tpCustomer";
            this.tpCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomer.Size = new System.Drawing.Size(933, 470);
            this.tpCustomer.TabIndex = 0;
            this.tpCustomer.Text = "Khách hàng";
            this.tpCustomer.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnLoadCus);
            this.panel2.Controls.Add(this.btnEditCus);
            this.panel2.Controls.Add(this.btnDeleteCus);
            this.panel2.Controls.Add(this.btnInsertCus);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(927, 464);
            this.panel2.TabIndex = 0;
            // 
            // BtnLoadCus
            // 
            this.BtnLoadCus.Location = new System.Drawing.Point(809, 418);
            this.BtnLoadCus.Name = "BtnLoadCus";
            this.BtnLoadCus.Size = new System.Drawing.Size(85, 40);
            this.BtnLoadCus.TabIndex = 9;
            this.BtnLoadCus.Text = "Xem";
            this.BtnLoadCus.UseVisualStyleBackColor = true;
            this.BtnLoadCus.Click += new System.EventHandler(this.BtnLoadCus_Click);
            // 
            // btnEditCus
            // 
            this.btnEditCus.Location = new System.Drawing.Point(617, 418);
            this.btnEditCus.Name = "btnEditCus";
            this.btnEditCus.Size = new System.Drawing.Size(85, 40);
            this.btnEditCus.TabIndex = 8;
            this.btnEditCus.Text = "Sửa";
            this.btnEditCus.UseVisualStyleBackColor = true;
            this.btnEditCus.Click += new System.EventHandler(this.btnEditCus_Click);
            // 
            // btnDeleteCus
            // 
            this.btnDeleteCus.Location = new System.Drawing.Point(809, 352);
            this.btnDeleteCus.Name = "btnDeleteCus";
            this.btnDeleteCus.Size = new System.Drawing.Size(85, 40);
            this.btnDeleteCus.TabIndex = 7;
            this.btnDeleteCus.Text = "Xóa";
            this.btnDeleteCus.UseVisualStyleBackColor = true;
            this.btnDeleteCus.Click += new System.EventHandler(this.btnDeleteCus_Click);
            // 
            // btnInsertCus
            // 
            this.btnInsertCus.Location = new System.Drawing.Point(617, 352);
            this.btnInsertCus.Name = "btnInsertCus";
            this.btnInsertCus.Size = new System.Drawing.Size(85, 40);
            this.btnInsertCus.TabIndex = 6;
            this.btnInsertCus.Text = "Thêm";
            this.btnInsertCus.UseVisualStyleBackColor = true;
            this.btnInsertCus.Click += new System.EventHandler(this.btnInsertCus_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbbSexCus);
            this.panel5.Controls.Add(this.dtpDOBCus);
            this.panel5.Controls.Add(this.txtIDCUS);
            this.panel5.Controls.Add(this.txtNameCus);
            this.panel5.Controls.Add(this.txtPhoneCus);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(604, 37);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(320, 309);
            this.panel5.TabIndex = 2;
            // 
            // cbbSexCus
            // 
            this.cbbSexCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSexCus.FormattingEnabled = true;
            this.cbbSexCus.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbbSexCus.Location = new System.Drawing.Point(137, 154);
            this.cbbSexCus.Name = "cbbSexCus";
            this.cbbSexCus.Size = new System.Drawing.Size(174, 21);
            this.cbbSexCus.TabIndex = 7;
            // 
            // dtpDOBCus
            // 
            this.dtpDOBCus.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOBCus.Location = new System.Drawing.Point(137, 212);
            this.dtpDOBCus.Name = "dtpDOBCus";
            this.dtpDOBCus.Size = new System.Drawing.Size(174, 20);
            this.dtpDOBCus.TabIndex = 4;
            this.dtpDOBCus.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // txtIDCUS
            // 
            this.txtIDCUS.Location = new System.Drawing.Point(137, 49);
            this.txtIDCUS.Name = "txtIDCUS";
            this.txtIDCUS.ReadOnly = true;
            this.txtIDCUS.Size = new System.Drawing.Size(174, 20);
            this.txtIDCUS.TabIndex = 1;
            // 
            // txtNameCus
            // 
            this.txtNameCus.Location = new System.Drawing.Point(137, 105);
            this.txtNameCus.Name = "txtNameCus";
            this.txtNameCus.Size = new System.Drawing.Size(174, 20);
            this.txtNameCus.TabIndex = 2;
            // 
            // txtPhoneCus
            // 
            this.txtPhoneCus.Location = new System.Drawing.Point(137, 265);
            this.txtPhoneCus.Name = "txtPhoneCus";
            this.txtPhoneCus.Size = new System.Drawing.Size(174, 20);
            this.txtPhoneCus.TabIndex = 5;
            this.txtPhoneCus.TextChanged += new System.EventHandler(this.txtPhoneCus_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Số Điện Thoại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Giới Tính:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày Sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin khách hàng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnSearchCus);
            this.panel4.Controls.Add(this.txtSearchCus);
            this.panel4.Location = new System.Drawing.Point(604, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 30);
            this.panel4.TabIndex = 1;
            // 
            // btnSearchCus
            // 
            this.btnSearchCus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCus.Location = new System.Drawing.Point(222, 2);
            this.btnSearchCus.Name = "btnSearchCus";
            this.btnSearchCus.Size = new System.Drawing.Size(89, 23);
            this.btnSearchCus.TabIndex = 3;
            this.btnSearchCus.Text = "Tìm kiếm";
            this.btnSearchCus.UseVisualStyleBackColor = true;
            this.btnSearchCus.Click += new System.EventHandler(this.btnSearchCus_Click);
            // 
            // txtSearchCus
            // 
            this.txtSearchCus.Location = new System.Drawing.Point(3, 3);
            this.txtSearchCus.Name = "txtSearchCus";
            this.txtSearchCus.Size = new System.Drawing.Size(213, 20);
            this.txtSearchCus.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvCustomer);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(598, 455);
            this.panel3.TabIndex = 0;
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Location = new System.Drawing.Point(3, 3);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.Size = new System.Drawing.Size(592, 452);
            this.dtgvCustomer.TabIndex = 0;
            // 
            // tpAccount
            // 
            this.tpAccount.Controls.Add(this.panel6);
            this.tpAccount.Location = new System.Drawing.Point(4, 22);
            this.tpAccount.Name = "tpAccount";
            this.tpAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tpAccount.Size = new System.Drawing.Size(933, 470);
            this.tpAccount.TabIndex = 1;
            this.tpAccount.Text = "Tài khoản";
            this.tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnLoadUser);
            this.panel6.Controls.Add(this.btnEditUser);
            this.panel6.Controls.Add(this.btnDeleteUser);
            this.panel6.Controls.Add(this.btnAddUser);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(927, 464);
            this.panel6.TabIndex = 1;
            // 
            // btnLoadUser
            // 
            this.btnLoadUser.Location = new System.Drawing.Point(809, 418);
            this.btnLoadUser.Name = "btnLoadUser";
            this.btnLoadUser.Size = new System.Drawing.Size(85, 40);
            this.btnLoadUser.TabIndex = 9;
            this.btnLoadUser.Text = "Xem";
            this.btnLoadUser.UseVisualStyleBackColor = true;
            this.btnLoadUser.Click += new System.EventHandler(this.btnLoadUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Location = new System.Drawing.Point(617, 418);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(85, 40);
            this.btnEditUser.TabIndex = 8;
            this.btnEditUser.Text = "Sửa";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(809, 352);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(85, 40);
            this.btnDeleteUser.TabIndex = 7;
            this.btnDeleteUser.Text = "Xóa";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(617, 352);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(85, 40);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Thêm";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnResetAccPW);
            this.panel7.Controls.Add(this.cbbUserType);
            this.panel7.Controls.Add(this.txtUserName);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Location = new System.Drawing.Point(604, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(320, 309);
            this.panel7.TabIndex = 2;
            // 
            // btnResetAccPW
            // 
            this.btnResetAccPW.Location = new System.Drawing.Point(201, 152);
            this.btnResetAccPW.Name = "btnResetAccPW";
            this.btnResetAccPW.Size = new System.Drawing.Size(110, 23);
            this.btnResetAccPW.TabIndex = 5;
            this.btnResetAccPW.Text = "Đặt lại mật khẩu";
            this.btnResetAccPW.UseVisualStyleBackColor = true;
            this.btnResetAccPW.Click += new System.EventHandler(this.btnResetAccPW_Click);
            // 
            // cbbUserType
            // 
            this.cbbUserType.FormattingEnabled = true;
            this.cbbUserType.Items.AddRange(new object[] {
            "Admin",
            "Quản Lý",
            "Lễ Tân",
            "Kế Toán"});
            this.cbbUserType.Location = new System.Drawing.Point(139, 104);
            this.cbbUserType.Name = "cbbUserType";
            this.cbbUserType.Size = new System.Drawing.Size(172, 21);
            this.cbbUserType.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(139, 48);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(174, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Loại:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(134, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "Tên Đăng Nhập:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(49, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(231, 24);
            this.label12.TabIndex = 1;
            this.label12.Text = "Thông tin người dùng";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnSearchUser);
            this.panel8.Controls.Add(this.txtSearchUser);
            this.panel8.Location = new System.Drawing.Point(604, 6);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(320, 30);
            this.panel8.TabIndex = 1;
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchUser.Location = new System.Drawing.Point(222, 2);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(89, 23);
            this.btnSearchUser.TabIndex = 3;
            this.btnSearchUser.Text = "Tìm kiếm";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Location = new System.Drawing.Point(3, 3);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(213, 20);
            this.txtSearchUser.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.dtgvAccount);
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(598, 455);
            this.panel9.TabIndex = 0;
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Location = new System.Drawing.Point(3, 3);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.Size = new System.Drawing.Size(592, 452);
            this.dtgvAccount.TabIndex = 0;
            // 
            // tpBill
            // 
            this.tpBill.Controls.Add(this.panel10);
            this.tpBill.Location = new System.Drawing.Point(4, 22);
            this.tpBill.Name = "tpBill";
            this.tpBill.Padding = new System.Windows.Forms.Padding(3);
            this.tpBill.Size = new System.Drawing.Size(933, 470);
            this.tpBill.TabIndex = 2;
            this.tpBill.Text = "Hóa Đơn";
            this.tpBill.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.btnLoadListBill);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(927, 464);
            this.panel10.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtPaymentReason);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.txtTotalPayment);
            this.panel11.Controls.Add(this.label16);
            this.panel11.Controls.Add(this.txtIDBill);
            this.panel11.Controls.Add(this.txtIDCusBill);
            this.panel11.Controls.Add(this.label13);
            this.panel11.Controls.Add(this.label14);
            this.panel11.Controls.Add(this.label15);
            this.panel11.Location = new System.Drawing.Point(607, 42);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(320, 370);
            this.panel11.TabIndex = 10;
            // 
            // txtPaymentReason
            // 
            this.txtPaymentReason.Location = new System.Drawing.Point(150, 180);
            this.txtPaymentReason.Name = "txtPaymentReason";
            this.txtPaymentReason.ReadOnly = true;
            this.txtPaymentReason.Size = new System.Drawing.Size(164, 20);
            this.txtPaymentReason.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lý do thanh toán:";
            // 
            // txtTotalPayment
            // 
            this.txtTotalPayment.Location = new System.Drawing.Point(150, 256);
            this.txtTotalPayment.Name = "txtTotalPayment";
            this.txtTotalPayment.ReadOnly = true;
            this.txtTotalPayment.Size = new System.Drawing.Size(164, 20);
            this.txtTotalPayment.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 257);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 19);
            this.label16.TabIndex = 10;
            this.label16.Text = "Tổng tiền:";
            // 
            // txtIDBill
            // 
            this.txtIDBill.Location = new System.Drawing.Point(150, 53);
            this.txtIDBill.Name = "txtIDBill";
            this.txtIDBill.ReadOnly = true;
            this.txtIDBill.Size = new System.Drawing.Size(164, 20);
            this.txtIDBill.TabIndex = 1;
            // 
            // txtIDCusBill
            // 
            this.txtIDCusBill.Location = new System.Drawing.Point(150, 113);
            this.txtIDCusBill.Name = "txtIDCusBill";
            this.txtIDCusBill.ReadOnly = true;
            this.txtIDCusBill.Size = new System.Drawing.Size(164, 20);
            this.txtIDCusBill.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 19);
            this.label13.TabIndex = 3;
            this.label13.Text = "Mã khách Hàng:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 19);
            this.label14.TabIndex = 2;
            this.label14.Text = "Mã hóa đơn:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(25, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(270, 24);
            this.label15.TabIndex = 1;
            this.label15.Text = "Thông tin chi tiết hóa đơn";
            // 
            // btnLoadListBill
            // 
            this.btnLoadListBill.Location = new System.Drawing.Point(836, 418);
            this.btnLoadListBill.Name = "btnLoadListBill";
            this.btnLoadListBill.Size = new System.Drawing.Size(85, 40);
            this.btnLoadListBill.TabIndex = 9;
            this.btnLoadListBill.Text = "Xem";
            this.btnLoadListBill.UseVisualStyleBackColor = true;
            this.btnLoadListBill.Click += new System.EventHandler(this.btnLoadListBill_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnSearchBill);
            this.panel12.Controls.Add(this.txtSearchBill);
            this.panel12.Location = new System.Drawing.Point(604, 6);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(320, 30);
            this.panel12.TabIndex = 1;
            // 
            // btnSearchBill
            // 
            this.btnSearchBill.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBill.Location = new System.Drawing.Point(222, 2);
            this.btnSearchBill.Name = "btnSearchBill";
            this.btnSearchBill.Size = new System.Drawing.Size(89, 23);
            this.btnSearchBill.TabIndex = 3;
            this.btnSearchBill.Text = "Tìm kiếm";
            this.btnSearchBill.UseVisualStyleBackColor = true;
            this.btnSearchBill.Click += new System.EventHandler(this.btnSearchBill_Click);
            // 
            // txtSearchBill
            // 
            this.txtSearchBill.Location = new System.Drawing.Point(3, 3);
            this.txtSearchBill.Name = "txtSearchBill";
            this.txtSearchBill.Size = new System.Drawing.Size(213, 20);
            this.txtSearchBill.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.dtgvBill);
            this.panel13.Location = new System.Drawing.Point(3, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(598, 455);
            this.panel13.TabIndex = 0;
            // 
            // dtgvBill
            // 
            this.dtgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBill.Location = new System.Drawing.Point(3, 3);
            this.dtgvBill.Name = "dtgvBill";
            this.dtgvBill.Size = new System.Drawing.Size(592, 452);
            this.dtgvBill.TabIndex = 0;
            // 
            // tpContractRenewal
            // 
            this.tpContractRenewal.Location = new System.Drawing.Point(4, 22);
            this.tpContractRenewal.Name = "tpContractRenewal";
            this.tpContractRenewal.Padding = new System.Windows.Forms.Padding(3);
            this.tpContractRenewal.Size = new System.Drawing.Size(933, 470);
            this.tpContractRenewal.TabIndex = 3;
            this.tpContractRenewal.Text = "Hợp đồng gia hạn";
            this.tpContractRenewal.UseVisualStyleBackColor = true;
            // 
            // frmAdmin
            // 
            this.AcceptButton = this.btnSearchCus;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 523);
            this.Controls.Add(this.panel1);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdmin";
            this.panel1.ResumeLayout(false);
            this.tcAdmin.ResumeLayout(false);
            this.tpCustomer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            this.tpAccount.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.tpBill.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpCustomer;
        private System.Windows.Forms.TabPage tpAccount;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtSearchCus;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSearchCus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnLoadCus;
        private System.Windows.Forms.Button btnEditCus;
        private System.Windows.Forms.Button btnDeleteCus;
        private System.Windows.Forms.Button btnInsertCus;
        private System.Windows.Forms.TextBox txtIDCUS;
        private System.Windows.Forms.TextBox txtNameCus;
        private System.Windows.Forms.TextBox txtPhoneCus;
        private System.Windows.Forms.DateTimePicker dtpDOBCus;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnLoadUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtSearchUser;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.ComboBox cbbUserType;
        private System.Windows.Forms.ComboBox cbbSexCus;
        private System.Windows.Forms.Button btnResetAccPW;
        private System.Windows.Forms.TabPage tpBill;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button btnLoadListBill;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnSearchBill;
        private System.Windows.Forms.TextBox txtSearchBill;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.DataGridView dtgvBill;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtPaymentReason;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalPayment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIDBill;
        private System.Windows.Forms.TextBox txtIDCusBill;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tpContractRenewal;
    }
}