
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
            this.txtIDCUS = new System.Windows.Forms.TextBox();
            this.txtNameCus = new System.Windows.Forms.TextBox();
            this.txtSexCus = new System.Windows.Forms.TextBox();
            this.txtPhoneCus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtpDOBCus = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.tcAdmin.SuspendLayout();
            this.tpCustomer.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
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
            this.tcAdmin.Controls.Add(this.tabPage2);
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
            this.panel5.Controls.Add(this.dtpDOBCus);
            this.panel5.Controls.Add(this.txtIDCUS);
            this.panel5.Controls.Add(this.txtNameCus);
            this.panel5.Controls.Add(this.txtSexCus);
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
            // txtSexCus
            // 
            this.txtSexCus.Location = new System.Drawing.Point(137, 158);
            this.txtSexCus.Name = "txtSexCus";
            this.txtSexCus.Size = new System.Drawing.Size(174, 20);
            this.txtSexCus.TabIndex = 3;
            // 
            // txtPhoneCus
            // 
            this.txtPhoneCus.Location = new System.Drawing.Point(137, 265);
            this.txtPhoneCus.Name = "txtPhoneCus";
            this.txtPhoneCus.Size = new System.Drawing.Size(174, 20);
            this.txtPhoneCus.TabIndex = 5;
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
            this.panel4.Controls.Add(this.btnLogin);
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Location = new System.Drawing.Point(604, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(320, 30);
            this.panel4.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(222, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Tìm kiếm";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 20);
            this.textBox1.TabIndex = 0;
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(933, 470);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dtpDOBCus
            // 
            this.dtpDOBCus.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOBCus.Location = new System.Drawing.Point(137, 212);
            this.dtpDOBCus.Name = "dtpDOBCus";
            this.dtpDOBCus.Size = new System.Drawing.Size(174, 20);
            this.dtpDOBCus.TabIndex = 4;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 523);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpCustomer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLogin;
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
        private System.Windows.Forms.TextBox txtSexCus;
        private System.Windows.Forms.TextBox txtPhoneCus;
        private System.Windows.Forms.DateTimePicker dtpDOBCus;
    }
}