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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinKháchTrọToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKíThuêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tínhTiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPhong = new System.Windows.Forms.DataGridView();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNguoiHienTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLToiDa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhong)).BeginInit();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(821, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            // dataPhong
            // 
            this.dataPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPhong,
            this.MaKV,
            this.TrangThai,
            this.SoNguoiHienTai,
            this.SLToiDa});
            this.dataPhong.Location = new System.Drawing.Point(0, 305);
            this.dataPhong.Name = "dataPhong";
            this.dataPhong.Size = new System.Drawing.Size(821, 178);
            this.dataPhong.TabIndex = 2;
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Tên Phòng";
            this.TenPhong.Name = "TenPhong";
            // 
            // MaKV
            // 
            this.MaKV.DataPropertyName = "MaKV";
            this.MaKV.HeaderText = "Khu vực";
            this.MaKV.Name = "MaKV";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            // 
            // SoNguoiHienTai
            // 
            this.SoNguoiHienTai.DataPropertyName = "SoNguoiHienTai";
            this.SoNguoiHienTai.HeaderText = "Số người hiện tại";
            this.SoNguoiHienTai.Name = "SoNguoiHienTai";
            // 
            // SLToiDa
            // 
            this.SLToiDa.DataPropertyName = "SLToiDa";
            this.SLToiDa.HeaderText = "Số người tối đa";
            this.SLToiDa.Name = "SLToiDa";
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUANLY_NHATRO.Properties.Resources._56119374_755644631497949_2115918769405558784_n;
            this.ClientSize = new System.Drawing.Size(821, 483);
            this.Controls.Add(this.dataPhong);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_main";
            this.Text = "Phần mềm quản lí nhà trọ - Trang Chủ";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKháchTrọToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKíThuêPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tínhTiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNguoiHienTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLToiDa;
    }
}