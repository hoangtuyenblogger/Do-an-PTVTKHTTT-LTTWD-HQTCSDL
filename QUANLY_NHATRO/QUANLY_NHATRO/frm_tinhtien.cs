using System;
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
    public partial class frm_tinhtien : Form
    {
        public frm_tinhtien()
        {
            InitializeComponent();
        }

        private void group_hoadon_Enter(object sender, EventArgs e)
        {

        }

        private void frm_tinhtien_Load(object sender, EventArgs e)
        {
            Connect _conn = new Connect();
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                _conn.Create_connect();

                // load họ tên người thanh toán
                cm = new SqlCommand("SELECT MaKhach, HoTen FROM view_THONGTIN_KHACHTRO_PHONGTRO", _conn.conn);
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "NGUOITHANHTOAN");

                // load tên phòng cần thanh toán
                cm = new SqlCommand("SELECT * FROM view_PHONG_DANGDUOC_THUE", _conn.conn);
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "PHONGTRO");

                // load tất cả giá tiền phòng 
                cm = new SqlCommand("SELECT * FROM VIEW_TATCA_GIATIENPHONG", _conn.conn);
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "TATCA_TIENPHONG");

                //==================//
                _conn.Disconnect();
            }
            catch (Exception E)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu tại LOAD frm_tinhtien ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // combo phòng
            combo_Phong.DataSource = ds.Tables["PHONGTRO"];
            combo_Phong.DisplayMember = "TenPhong";
            combo_Phong.ValueMember = "MaPhong";

            // combo người thanh toán
            combo_nguoithanhtoan.DataSource = ds.Tables["NGUOITHANHTOAN"];
            combo_nguoithanhtoan.DisplayMember = "Hoten"; // hiển thị tên trên combobox
            combo_nguoithanhtoan.ValueMember = "MaKhach"; // 

            // combo tiền phòng
            combo_tienphong.DataSource = ds.Tables["TATCA_TIENPHONG"];
            combo_tienphong.DisplayMember = "GiaTien";
        }

        private void combo_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            // lấy tên phòng sang thông tin hóa đơn
            txt_tenphong.Text = combo_Phong.Text;

            Connect _conn = new Connect();
            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                _conn.Create_connect();

                // lấy tên người thanh toán tương ứng với khách trong phòng đó
                cm = new SqlCommand("SELECT MaKhach, HoTen FROM view_THONGTIN_KHACHTRO_PHONGTRO WHERE MaPhong = '" + combo_Phong.SelectedValue.ToString() + "'", _conn.conn);
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "NGUOITHANHTOAN_THEOPHONG");
                combo_nguoithanhtoan.DataSource = ds.Tables["NGUOITHANHTOAN_THEOPHONG"];
                //============================================================================
                // lấy giá phòng tương ứng với phòng 
                cm = new SqlCommand("SELECT * FROM VIEW_GIATIEN_THEOPHONG WHERE MaPhong = '''" + combo_Phong.SelectedValue.ToString() + "'", _conn.conn);
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "GIAPHONG_THEOPHONG");
                combo_tienphong.DataSource = ds.Tables["GIAPHONG_THEOPHONG"];
                _conn.Disconnect();
            }
            catch (Exception E)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu tại combo_Phong_SelectedIndexChanged", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void combo_nguoithanhtoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_nguoithanhtoan.Text = combo_nguoithanhtoan.Text;
        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            if (check_null())
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_sodien.Focus();
                return;
            }

            //----------------------------------------
            double dongia_dien = 3000;
            double dongia_nuoc = 4000;
            double sodien;
            double sonuoc;
            double tiendien;
            double tiennuoc;
            double tienInternet;
            double tongtien;

            // tính tiền
            sodien = double.Parse(txt_sodien.Text);
            sonuoc = double.Parse(txt_sonuoc.Text);
            //---------------------------------------//
            tiendien = dongia_dien * sodien;
            tiennuoc = dongia_nuoc * sonuoc;
            tienInternet = double.Parse(txt_gia_internet.Text);
            tongtien = tiendien + tiennuoc + tienInternet;
            // in ra text box
            txt_tien_internet.Text = txt_gia_internet.Text;
            txt_tiendien.Text = tiendien.ToString();
            txt_tiennuoc.Text = tiennuoc.ToString();
            txt_tongtien.Text = tongtien.ToString();

            //lưu vào cơ sở dữ liệu
            Connect _conn = new Connect();
            _conn.Create_connect();
            SqlCommand cm = new SqlCommand();
            cm.Connection = _conn.conn;
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "sp_TINHTIEN_THEOTHANG";
            cm.Parameters.AddWithValue("@MaPhong",combo_Phong.SelectedValue);
            cm.Parameters.AddWithValue("@MaKhach", combo_nguoithanhtoan.SelectedValue);
            cm.Parameters.AddWithValue("@TienDien", txt_tiendien.Text);
            cm.Parameters.AddWithValue("@TienNuoc", txt_tiennuoc.Text);
            cm.Parameters.AddWithValue("@TienInternet", txt_tien_internet.Text);
            cm.Parameters.AddWithValue("@TienPhong", txt_tienphong.Text);
            cm.Parameters.AddWithValue("@TongTien", txt_tongtien.Text);
            cm.Parameters.AddWithValue("@ThangThu", txt_NgayThanhToan.Text);

            try
            {
                cm.ExecuteNonQuery();
                MessageBox.Show("Đã xong!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch(Exception E)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu trong lúc thêm vào CSDL ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picktime_ValueChanged(object sender, EventArgs e)
        {
            txt_NgayThanhToan.Text = picktime.Text;
        }

        private void combo_tienphong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_tienphong.Text = combo_tienphong.Text;
        }

        private bool check_null() // kiểm tra xem txt nhập vào có rỗng hay không
        {
            if (txt_sodien.Text == "" || txt_sonuoc.Text == "" || txt_gia_internet.Text == "")
            {
                return true;
            }
            return false;
        }
    }
}
