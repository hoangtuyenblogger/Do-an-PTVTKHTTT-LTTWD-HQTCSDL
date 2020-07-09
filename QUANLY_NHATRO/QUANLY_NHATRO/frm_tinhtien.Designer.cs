namespace QUANLY_NHATRO
{
    partial class frm_tinhtien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_tinhtien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.group_thongtinthanhtoan = new System.Windows.Forms.GroupBox();
            this.picktime = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.combo_nguoithanhtoan = new System.Windows.Forms.ComboBox();
            this.combo_Phong = new System.Windows.Forms.ComboBox();
            this.group_chitietdichvu = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_gia_internet = new System.Windows.Forms.TextBox();
            this.txt_sodien = new System.Windows.Forms.TextBox();
            this.txt_sonuoc = new System.Windows.Forms.TextBox();
            this.group_hoadon = new System.Windows.Forms.GroupBox();
            this.txt_NgayThanhToan = new System.Windows.Forms.TextBox();
            this.txt_tienphong = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_tenphong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_nguoithanhtoan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tien_internet = new System.Windows.Forms.TextBox();
            this.txt_tiennuoc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_tiendien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_thanhtoan = new System.Windows.Forms.Button();
            this.combo_tienphong = new System.Windows.Forms.ComboBox();
            this.group_thongtinthanhtoan.SuspendLayout();
            this.group_chitietdichvu.SuspendLayout();
            this.group_hoadon.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn phòng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Người thanh toán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số nước:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giá internet:";
            // 
            // group_thongtinthanhtoan
            // 
            this.group_thongtinthanhtoan.Controls.Add(this.picktime);
            this.group_thongtinthanhtoan.Controls.Add(this.label14);
            this.group_thongtinthanhtoan.Controls.Add(this.combo_nguoithanhtoan);
            this.group_thongtinthanhtoan.Controls.Add(this.combo_Phong);
            this.group_thongtinthanhtoan.Controls.Add(this.label2);
            this.group_thongtinthanhtoan.Controls.Add(this.label1);
            this.group_thongtinthanhtoan.Location = new System.Drawing.Point(23, 41);
            this.group_thongtinthanhtoan.Name = "group_thongtinthanhtoan";
            this.group_thongtinthanhtoan.Size = new System.Drawing.Size(315, 137);
            this.group_thongtinthanhtoan.TabIndex = 5;
            this.group_thongtinthanhtoan.TabStop = false;
            this.group_thongtinthanhtoan.Text = "Thông tin thanh toán";
            // 
            // picktime
            // 
            this.picktime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.picktime.Location = new System.Drawing.Point(126, 99);
            this.picktime.MaximumSize = new System.Drawing.Size(163, 20);
            this.picktime.MinimumSize = new System.Drawing.Size(163, 20);
            this.picktime.Name = "picktime";
            this.picktime.Size = new System.Drawing.Size(163, 20);
            this.picktime.TabIndex = 3;
            this.picktime.ValueChanged += new System.EventHandler(this.picktime_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Ngày thanh toán:";
            // 
            // combo_nguoithanhtoan
            // 
            this.combo_nguoithanhtoan.FormattingEnabled = true;
            this.combo_nguoithanhtoan.Location = new System.Drawing.Point(126, 65);
            this.combo_nguoithanhtoan.Name = "combo_nguoithanhtoan";
            this.combo_nguoithanhtoan.Size = new System.Drawing.Size(163, 21);
            this.combo_nguoithanhtoan.TabIndex = 2;
            this.combo_nguoithanhtoan.SelectedIndexChanged += new System.EventHandler(this.combo_nguoithanhtoan_SelectedIndexChanged);
            // 
            // combo_Phong
            // 
            this.combo_Phong.FormattingEnabled = true;
            this.combo_Phong.Location = new System.Drawing.Point(126, 25);
            this.combo_Phong.Name = "combo_Phong";
            this.combo_Phong.Size = new System.Drawing.Size(163, 21);
            this.combo_Phong.TabIndex = 1;
            this.combo_Phong.SelectedIndexChanged += new System.EventHandler(this.combo_Phong_SelectedIndexChanged);
            // 
            // group_chitietdichvu
            // 
            this.group_chitietdichvu.Controls.Add(this.combo_tienphong);
            this.group_chitietdichvu.Controls.Add(this.label12);
            this.group_chitietdichvu.Controls.Add(this.txt_gia_internet);
            this.group_chitietdichvu.Controls.Add(this.txt_sodien);
            this.group_chitietdichvu.Controls.Add(this.txt_sonuoc);
            this.group_chitietdichvu.Controls.Add(this.label3);
            this.group_chitietdichvu.Controls.Add(this.label5);
            this.group_chitietdichvu.Controls.Add(this.label4);
            this.group_chitietdichvu.Location = new System.Drawing.Point(26, 194);
            this.group_chitietdichvu.Name = "group_chitietdichvu";
            this.group_chitietdichvu.Size = new System.Drawing.Size(312, 189);
            this.group_chitietdichvu.TabIndex = 6;
            this.group_chitietdichvu.TabStop = false;
            this.group_chitietdichvu.Text = "Chi tiết dịch vụ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Tiền phòng:";
            // 
            // txt_gia_internet
            // 
            this.txt_gia_internet.Location = new System.Drawing.Point(87, 146);
            this.txt_gia_internet.Name = "txt_gia_internet";
            this.txt_gia_internet.Size = new System.Drawing.Size(199, 20);
            this.txt_gia_internet.TabIndex = 7;
            // 
            // txt_sodien
            // 
            this.txt_sodien.Location = new System.Drawing.Point(87, 65);
            this.txt_sodien.Name = "txt_sodien";
            this.txt_sodien.Size = new System.Drawing.Size(199, 20);
            this.txt_sodien.TabIndex = 5;
            // 
            // txt_sonuoc
            // 
            this.txt_sonuoc.Location = new System.Drawing.Point(87, 106);
            this.txt_sonuoc.Name = "txt_sonuoc";
            this.txt_sonuoc.Size = new System.Drawing.Size(199, 20);
            this.txt_sonuoc.TabIndex = 6;
            // 
            // group_hoadon
            // 
            this.group_hoadon.Controls.Add(this.txt_NgayThanhToan);
            this.group_hoadon.Controls.Add(this.txt_tienphong);
            this.group_hoadon.Controls.Add(this.label15);
            this.group_hoadon.Controls.Add(this.label13);
            this.group_hoadon.Controls.Add(this.txt_tenphong);
            this.group_hoadon.Controls.Add(this.label11);
            this.group_hoadon.Controls.Add(this.txt_nguoithanhtoan);
            this.group_hoadon.Controls.Add(this.label10);
            this.group_hoadon.Controls.Add(this.txt_tongtien);
            this.group_hoadon.Controls.Add(this.label9);
            this.group_hoadon.Controls.Add(this.txt_tien_internet);
            this.group_hoadon.Controls.Add(this.txt_tiennuoc);
            this.group_hoadon.Controls.Add(this.label8);
            this.group_hoadon.Controls.Add(this.txt_tiendien);
            this.group_hoadon.Controls.Add(this.label7);
            this.group_hoadon.Controls.Add(this.label6);
            this.group_hoadon.Location = new System.Drawing.Point(363, 41);
            this.group_hoadon.Name = "group_hoadon";
            this.group_hoadon.Size = new System.Drawing.Size(414, 342);
            this.group_hoadon.TabIndex = 7;
            this.group_hoadon.TabStop = false;
            this.group_hoadon.Text = "Thông tin hóa đơn";
            this.group_hoadon.Enter += new System.EventHandler(this.group_hoadon_Enter);
            // 
            // txt_NgayThanhToan
            // 
            this.txt_NgayThanhToan.Location = new System.Drawing.Point(246, 311);
            this.txt_NgayThanhToan.Name = "txt_NgayThanhToan";
            this.txt_NgayThanhToan.ReadOnly = true;
            this.txt_NgayThanhToan.Size = new System.Drawing.Size(155, 20);
            this.txt_NgayThanhToan.TabIndex = 15;
            // 
            // txt_tienphong
            // 
            this.txt_tienphong.Location = new System.Drawing.Point(94, 117);
            this.txt_tienphong.Name = "txt_tienphong";
            this.txt_tienphong.ReadOnly = true;
            this.txt_tienphong.Size = new System.Drawing.Size(199, 20);
            this.txt_tienphong.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(151, 315);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Ngày thanh toán:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Tiền phòng:";
            // 
            // txt_tenphong
            // 
            this.txt_tenphong.Location = new System.Drawing.Point(129, 70);
            this.txt_tenphong.Name = "txt_tenphong";
            this.txt_tenphong.ReadOnly = true;
            this.txt_tenphong.Size = new System.Drawing.Size(205, 20);
            this.txt_tenphong.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Tên phòng:";
            // 
            // txt_nguoithanhtoan
            // 
            this.txt_nguoithanhtoan.Location = new System.Drawing.Point(129, 30);
            this.txt_nguoithanhtoan.Name = "txt_nguoithanhtoan";
            this.txt_nguoithanhtoan.ReadOnly = true;
            this.txt_nguoithanhtoan.Size = new System.Drawing.Size(205, 20);
            this.txt_nguoithanhtoan.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Người thanh toán:";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(94, 262);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(271, 20);
            this.txt_tongtien.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tổng tiền:";
            // 
            // txt_tien_internet
            // 
            this.txt_tien_internet.Location = new System.Drawing.Point(94, 218);
            this.txt_tien_internet.Name = "txt_tien_internet";
            this.txt_tien_internet.ReadOnly = true;
            this.txt_tien_internet.Size = new System.Drawing.Size(113, 20);
            this.txt_tien_internet.TabIndex = 13;
            // 
            // txt_tiennuoc
            // 
            this.txt_tiennuoc.Location = new System.Drawing.Point(288, 168);
            this.txt_tiennuoc.Name = "txt_tiennuoc";
            this.txt_tiennuoc.ReadOnly = true;
            this.txt_tiennuoc.Size = new System.Drawing.Size(113, 20);
            this.txt_tiennuoc.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Tiền điện:";
            // 
            // txt_tiendien
            // 
            this.txt_tiendien.Location = new System.Drawing.Point(94, 171);
            this.txt_tiendien.Name = "txt_tiendien";
            this.txt_tiendien.ReadOnly = true;
            this.txt_tiendien.Size = new System.Drawing.Size(113, 20);
            this.txt_tiendien.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tiền internet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tiền nước:";
            // 
            // btn_thanhtoan
            // 
            this.btn_thanhtoan.Location = new System.Drawing.Point(305, 401);
            this.btn_thanhtoan.Name = "btn_thanhtoan";
            this.btn_thanhtoan.Size = new System.Drawing.Size(137, 42);
            this.btn_thanhtoan.TabIndex = 16;
            this.btn_thanhtoan.Text = "Thanh toán";
            this.btn_thanhtoan.UseVisualStyleBackColor = true;
            this.btn_thanhtoan.Click += new System.EventHandler(this.btn_thanhtoan_Click);
            // 
            // combo_tienphong
            // 
            this.combo_tienphong.FormattingEnabled = true;
            this.combo_tienphong.Location = new System.Drawing.Point(87, 25);
            this.combo_tienphong.Name = "combo_tienphong";
            this.combo_tienphong.Size = new System.Drawing.Size(199, 21);
            this.combo_tienphong.TabIndex = 4;
            this.combo_tienphong.SelectedIndexChanged += new System.EventHandler(this.combo_tienphong_SelectedIndexChanged);
            // 
            // frm_tinhtien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 464);
            this.Controls.Add(this.btn_thanhtoan);
            this.Controls.Add(this.group_hoadon);
            this.Controls.Add(this.group_chitietdichvu);
            this.Controls.Add(this.group_thongtinthanhtoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(815, 503);
            this.MinimumSize = new System.Drawing.Size(815, 503);
            this.Name = "frm_tinhtien";
            this.Text = "Thanh toán tiền trọ";
            this.Load += new System.EventHandler(this.frm_tinhtien_Load);
            this.group_thongtinthanhtoan.ResumeLayout(false);
            this.group_thongtinthanhtoan.PerformLayout();
            this.group_chitietdichvu.ResumeLayout(false);
            this.group_chitietdichvu.PerformLayout();
            this.group_hoadon.ResumeLayout(false);
            this.group_hoadon.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox group_thongtinthanhtoan;
        private System.Windows.Forms.ComboBox combo_nguoithanhtoan;
        private System.Windows.Forms.ComboBox combo_Phong;
        private System.Windows.Forms.GroupBox group_chitietdichvu;
        private System.Windows.Forms.TextBox txt_gia_internet;
        private System.Windows.Forms.TextBox txt_sodien;
        private System.Windows.Forms.TextBox txt_sonuoc;
        private System.Windows.Forms.GroupBox group_hoadon;
        private System.Windows.Forms.TextBox txt_tenphong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_nguoithanhtoan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tien_internet;
        private System.Windows.Forms.TextBox txt_tiennuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_tiendien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_thanhtoan;
        private System.Windows.Forms.DateTimePicker picktime;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_tienphong;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_NgayThanhToan;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox combo_tienphong;
    }
}