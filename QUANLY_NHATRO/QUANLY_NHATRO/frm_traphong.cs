using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLY_NHATRO
{
    public partial class frm_traphong : Form
    {
        public frm_traphong()
        {
            InitializeComponent();
        }

        

        private void frm_traphong_Load(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            try
            {
                Connect _conn = new Connect();
                SqlCommand cm = new SqlCommand();
                SqlDataAdapter da = new SqlDataAdapter();
                _conn.Create_connect();

                cm = new SqlCommand("SELECT MaKhach, HoTen FROM view_THONGTIN_KHACHTRO_PHONGTRO", _conn.conn);
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "KHACHTRO");

                cm = new SqlCommand("SELECT MaPhong, TenPhong FROM view_PHONG_DANGDUOC_THUE", _conn.conn);
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "PHONGTRO");

                cm = new SqlCommand("SELECT TienDatCoc FROM DANGKYTHUEPHONG", _conn.conn);
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "TIENDATCOC");
                _conn.Disconnect();

            }
            catch (Exception E)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // combo họ tên
            combo_hoten.DataSource = ds.Tables["KHACHTRO"];
            combo_hoten.DisplayMember = "HoTen";
            combo_hoten.ValueMember = "Makhach";

            //COMBO PHÒNG
            combo_Phong.DataSource = ds.Tables["PHONGTRO"];
            combo_Phong.DisplayMember = "TenPhong";
            combo_Phong.ValueMember = "MaPhong";


            //combo tien tra lai
            combo_tientralai.DataSource = ds.Tables["TIENDATCOC"];
            combo_tientralai.DisplayMember = "TienDatCoc";
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {

            Connect _conn = new Connect();
            _conn.Create_connect();

            try
            {
                _conn.cm.Connection = _conn.conn;
                _conn.cm.CommandType = CommandType.StoredProcedure;
                _conn.cm.CommandText = "sp_TRAPHONG";
                _conn.cm.Parameters.AddWithValue("@ma_phong", combo_Phong.SelectedValue);
                _conn.cm.Parameters.AddWithValue("@ma_khach", combo_hoten.SelectedValue);
                _conn.cm.Parameters.AddWithValue("@ngay_tra", dateTimePicker1.Text);
                _conn.cm.Parameters.AddWithValue("@tien_tralai", combo_tientralai.Text);
                _conn.cm.Parameters.AddWithValue("@ghi_chu", txtGhichu.Text);

                _conn.cm.ExecuteNonQuery();
                MessageBox.Show("Trả phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception E)
            {
                //MessageBox.Show("Đã có lỗi cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();

        }

        private void combo_hoten_SelectedIndexChanged(object sender, EventArgs e)
        {

            Connect _conn = new Connect();
            _conn.Create_connect();
            SqlCommand cm;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                cm = new SqlCommand("SELECT * FROM view_TIENCOC_CHUATRA WHERE MaKhach = '"+ combo_hoten.SelectedValue +"'", _conn.conn);
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "TIENTRALAI");

                cm = new SqlCommand("SELECT MaPhong, TenPhong FROM view_THONGTIN_KHACHTRO_PHONGTRO WHERE MaKhach = '"+ combo_hoten.SelectedValue +"'", _conn.conn);
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "PHONGTRO_KHACHTRO");




                combo_Phong.DataSource = ds.Tables["PHONGTRO_KHACHTRO"];
                combo_tientralai.DataSource = ds.Tables["TIENTRALAI"];   
            }
            catch (Exception E)
            {
                //MessageBox.Show("Lỗi kết nối cơ sở dữ liệu tại combo_hoten_SelectedIndexChanged", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _conn.Disconnect();
        }


    }
}
