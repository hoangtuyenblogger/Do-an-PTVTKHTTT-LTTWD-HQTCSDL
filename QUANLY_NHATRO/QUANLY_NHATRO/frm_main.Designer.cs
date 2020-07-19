namespace QUANLY_NHATRO
{
    partial class frm_main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.thôngTinKháchTrọToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKíThuêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DATA_VIEW = new System.Windows.Forms.DataGridView();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayVao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ThongTinKhachTro = new System.Windows.Forms.Button();
            this.btn_DangKiThuePhong = new System.Windows.Forms.Button();
            this.btn_TraPhong = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.group_menu = new System.Windows.Forms.GroupBox();
            this.combo_Phong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoNguoiHienTai = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATA_VIEW)).BeginInit();
            this.group_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // thôngTinKháchTrọToolStripMenuItem
            // 
            this.thôngTinKháchTrọToolStripMenuItem.Name = "thôngTinKháchTrọToolStripMenuItem";
            this.thôngTinKháchTrọToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.thôngTinKháchTrọToolStripMenuItem.Text = "Thông tin khách trọ";
            this.thôngTinKháchTrọToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKháchTrọToolStripMenuItem_Click);
            // 
            // đăngKíThuêPhòngToolStripMenuItem
            // 
            this.đăngKíThuêPhòngToolStripMenuItem.Name = "đăngKíThuêPhòngToolStripMenuItem";
            this.đăngKíThuêPhòngToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.đăngKíThuêPhòngToolStripMenuItem.Text = "Đăng kí thuê phòng";
            this.đăngKíThuêPhòngToolStripMenuItem.Click += new System.EventHandler(this.đăngKíThuêPhòngToolStripMenuItem_Click);
            // 
            // trảPhòngToolStripMenuItem
            // 
            this.trảPhòngToolStripMenuItem.Name = "trảPhòngToolStripMenuItem";
            this.trảPhòngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.trảPhòngToolStripMenuItem.Text = "Trả phòng";
            // 
            // tínhTiềnToolStripMenuItem
            // 
            this.tínhTiềnToolStripMenuItem.Name = "tínhTiềnToolStripMenuItem";
            this.tínhTiềnToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.tínhTiềnToolStripMenuItem.Text = "Tính tiền";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinKháchTrọToolStripMenuItem,
            this.đăngKíThuêPhòngToolStripMenuItem,
            this.trảPhòngToolStripMenuItem,
            this.tínhTiềnToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(826, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Timer";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(707, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thời gian hiện tại";
            // 
            // DATA_VIEW
            // 
            this.DATA_VIEW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DATA_VIEW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DATA_VIEW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DATA_VIEW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HoTen,
            this.GioiTinh,
            this.TenPhong,
            this.NgayVao});
            this.DATA_VIEW.Location = new System.Drawing.Point(238, 218);
            this.DATA_VIEW.Name = "DATA_VIEW";
            this.DATA_VIEW.Size = new System.Drawing.Size(583, 196);
            this.DATA_VIEW.TabIndex = 3;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ Tên";
            this.HoTen.Name = "HoTen";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên phòng";
            this.TenPhong.Name = "TenPhong";
            // 
            // NgayVao
            // 
            this.NgayVao.DataPropertyName = "NgayVaoO";
            this.NgayVao.HeaderText = "Ngày vào";
            this.NgayVao.Name = "NgayVao";
            // 
            // btn_ThongTinKhachTro
            // 
            this.btn_ThongTinKhachTro.Location = new System.Drawing.Point(41, 32);
            this.btn_ThongTinKhachTro.Name = "btn_ThongTinKhachTro";
            this.btn_ThongTinKhachTro.Size = new System.Drawing.Size(138, 43);
            this.btn_ThongTinKhachTro.TabIndex = 4;
            this.btn_ThongTinKhachTro.Text = "Thông tin khách trọ";
            this.btn_ThongTinKhachTro.UseVisualStyleBackColor = true;
            this.btn_ThongTinKhachTro.Click += new System.EventHandler(this.btn_ThongTinKhachTro_Click);
            // 
            // btn_DangKiThuePhong
            // 
            this.btn_DangKiThuePhong.Location = new System.Drawing.Point(41, 98);
            this.btn_DangKiThuePhong.Name = "btn_DangKiThuePhong";
            this.btn_DangKiThuePhong.Size = new System.Drawing.Size(138, 43);
            this.btn_DangKiThuePhong.TabIndex = 5;
            this.btn_DangKiThuePhong.Text = "Đăng kí thuê phòng";
            this.btn_DangKiThuePhong.UseVisualStyleBackColor = true;
            this.btn_DangKiThuePhong.Click += new System.EventHandler(this.btn_DangKiThuePhong_Click);
            // 
            // btn_TraPhong
            // 
            this.btn_TraPhong.Location = new System.Drawing.Point(41, 169);
            this.btn_TraPhong.Name = "btn_TraPhong";
            this.btn_TraPhong.Size = new System.Drawing.Size(138, 43);
            this.btn_TraPhong.TabIndex = 6;
            this.btn_TraPhong.Text = "Trả phòng";
            this.btn_TraPhong.UseVisualStyleBackColor = true;
            this.btn_TraPhong.Click += new System.EventHandler(this.btn_TraPhong_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Location = new System.Drawing.Point(41, 243);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(138, 43);
            this.btn_ThanhToan.TabIndex = 7;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // group_menu
            // 
            this.group_menu.Controls.Add(this.btn_ThanhToan);
            this.group_menu.Controls.Add(this.btn_TraPhong);
            this.group_menu.Controls.Add(this.btn_DangKiThuePhong);
            this.group_menu.Controls.Add(this.btn_ThongTinKhachTro);
            this.group_menu.Location = new System.Drawing.Point(12, 104);
            this.group_menu.Name = "group_menu";
            this.group_menu.Size = new System.Drawing.Size(206, 302);
            this.group_menu.TabIndex = 8;
            this.group_menu.TabStop = false;
            this.group_menu.Text = "Chức năng";
            // 
            // combo_Phong
            // 
            this.combo_Phong.FormattingEnabled = true;
            this.combo_Phong.Items.AddRange(new object[] {
            "Tất cả"});
            this.combo_Phong.Location = new System.Drawing.Point(336, 104);
            this.combo_Phong.Name = "combo_Phong";
            this.combo_Phong.Size = new System.Drawing.Size(176, 21);
            this.combo_Phong.TabIndex = 9;
            this.combo_Phong.Text = "Tất cả";
            this.combo_Phong.SelectionChangeCommitted += new System.EventHandler(this.combo_Phong_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chọn phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(549, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số người hiện tại:";
            // 
            // txt_SoNguoiHienTai
            // 
            this.txt_SoNguoiHienTai.Location = new System.Drawing.Point(644, 105);
            this.txt_SoNguoiHienTai.Name = "txt_SoNguoiHienTai";
            this.txt_SoNguoiHienTai.Size = new System.Drawing.Size(91, 20);
            this.txt_SoNguoiHienTai.TabIndex = 12;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 418);
            this.Controls.Add(this.txt_SoNguoiHienTai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combo_Phong);
            this.Controls.Add(this.group_menu);
            this.Controls.Add(this.DATA_VIEW);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(842, 457);
            this.MinimumSize = new System.Drawing.Size(842, 457);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lí nhà trọ - Trang Chủ";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DATA_VIEW)).EndInit();
            this.group_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchTrọToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKíThuêPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DATA_VIEW;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayVao;
        private System.Windows.Forms.Button btn_ThongTinKhachTro;
        private System.Windows.Forms.Button btn_DangKiThuePhong;
        private System.Windows.Forms.Button btn_TraPhong;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.GroupBox group_menu;
        private System.Windows.Forms.ComboBox combo_Phong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SoNguoiHienTai;
    }
}