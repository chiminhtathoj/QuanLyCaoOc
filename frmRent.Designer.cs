
namespace QuanLyCaoOc
{
    partial class frmRent
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDRent = new System.Windows.Forms.TextBox();
            this.txtPriceRent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearchCusRent = new System.Windows.Forms.Button();
            this.txtIDCusRent = new System.Windows.Forms.TextBox();
            this.dtgvListCusRent = new System.Windows.Forms.DataGridView();
            this.txtNameCusRent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpValidityConTract = new System.Windows.Forms.DateTimePicker();
            this.dtpFirstPay = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCusRent)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Danh sách mã phòng thuê:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tổng giá:";
            // 
            // txtIDRent
            // 
            this.txtIDRent.Location = new System.Drawing.Point(145, 9);
            this.txtIDRent.Name = "txtIDRent";
            this.txtIDRent.ReadOnly = true;
            this.txtIDRent.Size = new System.Drawing.Size(100, 20);
            this.txtIDRent.TabIndex = 5;
            // 
            // txtPriceRent
            // 
            this.txtPriceRent.Location = new System.Drawing.Point(145, 44);
            this.txtPriceRent.Name = "txtPriceRent";
            this.txtPriceRent.ReadOnly = true;
            this.txtPriceRent.Size = new System.Drawing.Size(100, 20);
            this.txtPriceRent.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(322, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 24);
            this.label9.TabIndex = 1;
            this.label9.Text = "Hợp Đồng Thuê Phòng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBookRoom);
            this.panel1.Controls.Add(this.dtpFirstPay);
            this.panel1.Controls.Add(this.dtpValidityConTract);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtIDCusRent);
            this.panel1.Controls.Add(this.txtNameCusRent);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPriceRent);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIDRent);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnSearchCusRent);
            this.panel1.Controls.Add(this.dtgvListCusRent);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(887, 503);
            this.panel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mã hợp đồng thuế phòng:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(713, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // btnSearchCusRent
            // 
            this.btnSearchCusRent.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCusRent.Location = new System.Drawing.Point(261, 113);
            this.btnSearchCusRent.Name = "btnSearchCusRent";
            this.btnSearchCusRent.Size = new System.Drawing.Size(89, 23);
            this.btnSearchCusRent.TabIndex = 17;
            this.btnSearchCusRent.Text = "Tìm kiếm";
            this.btnSearchCusRent.UseVisualStyleBackColor = true;
            this.btnSearchCusRent.Click += new System.EventHandler(this.btnSearchCusRent_Click);
            // 
            // txtIDCusRent
            // 
            this.txtIDCusRent.Location = new System.Drawing.Point(145, 81);
            this.txtIDCusRent.Name = "txtIDCusRent";
            this.txtIDCusRent.ReadOnly = true;
            this.txtIDCusRent.Size = new System.Drawing.Size(100, 20);
            this.txtIDCusRent.TabIndex = 15;
            // 
            // dtgvListCusRent
            // 
            this.dtgvListCusRent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvListCusRent.Location = new System.Drawing.Point(3, 231);
            this.dtgvListCusRent.Name = "dtgvListCusRent";
            this.dtgvListCusRent.Size = new System.Drawing.Size(878, 269);
            this.dtgvListCusRent.TabIndex = 14;
            // 
            // txtNameCusRent
            // 
            this.txtNameCusRent.Location = new System.Drawing.Point(145, 114);
            this.txtNameCusRent.Name = "txtNameCusRent";
            this.txtNameCusRent.Size = new System.Drawing.Size(100, 20);
            this.txtNameCusRent.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Khách Hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(583, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Ngày hiệu lực hợp đồng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(576, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Ngày thanh toán đầu tiên:";
            // 
            // dtpValidityConTract
            // 
            this.dtpValidityConTract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpValidityConTract.Location = new System.Drawing.Point(713, 41);
            this.dtpValidityConTract.Name = "dtpValidityConTract";
            this.dtpValidityConTract.Size = new System.Drawing.Size(100, 20);
            this.dtpValidityConTract.TabIndex = 22;
            this.dtpValidityConTract.Value = new System.DateTime(2021, 1, 6, 1, 1, 48, 0);
            // 
            // dtpFirstPay
            // 
            this.dtpFirstPay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFirstPay.Location = new System.Drawing.Point(713, 77);
            this.dtpFirstPay.Name = "dtpFirstPay";
            this.dtpFirstPay.Size = new System.Drawing.Size(100, 20);
            this.dtpFirstPay.TabIndex = 23;
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.Location = new System.Drawing.Point(783, 185);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(98, 40);
            this.btnBookRoom.TabIndex = 24;
            this.btnBookRoom.Text = "Tạo hợp đồng";
            this.btnBookRoom.UseVisualStyleBackColor = true;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // frmRent
            // 
            this.AcceptButton = this.btnSearchCusRent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 541);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label9);
            this.Name = "frmRent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvListCusRent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDRent;
        private System.Windows.Forms.TextBox txtPriceRent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameCusRent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgvListCusRent;
        private System.Windows.Forms.TextBox txtIDCusRent;
        private System.Windows.Forms.Button btnSearchCusRent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFirstPay;
        private System.Windows.Forms.DateTimePicker dtpValidityConTract;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnBookRoom;
    }
}