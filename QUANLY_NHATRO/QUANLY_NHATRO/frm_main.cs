﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLY_NHATRO
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        bool login_status = false;
        private void frm_main_Load(object sender, EventArgs e)
        {
            Connect _conn = new Connect();
            _conn.Create_connect();
            _conn.ds = _conn.GetData_SQL("SELECT HoTen, GioiTinh, TenPhong, NgayVaoO FROM view_THONGTIN_KHACHTRO_PHONGTRO");
            DATA_VIEW.DataSource = _conn.ds.Tables[0];
            DATA_VIEW.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DATA_VIEW.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl =  MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dl == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void thôngTinKháchTrọToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Khach_Tro f = new Khach_Tro();
            f.ShowDialog();
        }

        private void đăngKíThuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_dangki f = new frm_dangki();
            f.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void btn_ThongTinKhachTro_Click(object sender, EventArgs e)
        {
            Khach_Tro f = new Khach_Tro();
            f.Show();
        }

        private void btn_DangKiThuePhong_Click(object sender, EventArgs e)
        {
            frm_dangki f = new frm_dangki();
            f.ShowDialog();
        }

        private void btn_TraPhong_Click(object sender, EventArgs e)
        {
            frm_traphong f = new frm_traphong();
            f.ShowDialog();
        }

        private void btn_ThanhToan_Click(object sender, EventArgs e)
        {
            frm_tinhtien f = new frm_tinhtien();
            f.ShowDialog();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            frm_main main = new frm_main();
            main.Show();
            this.Close();
        }

        
    }
}
