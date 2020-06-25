using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;



namespace QUANLY_NHATRO
{
    public partial class frm_dangki : Form
    {
        public frm_dangki()
        {
            InitializeComponent();
        }
        bool status;
        private void frm_dangki_Load(object sender, EventArgs e)
        {
            Connect _conn = new Connect();

            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                _conn.Create_connect();

                cm = new SqlCommand("select MaKhach, Hoten from KHACHTRO", _conn.conn);
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "KHACHTRO");

                cm = new SqlCommand("SELECT MaPhong, TenPhong FROM PHONGTRO", _conn.conn);
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "PHONGTRO");
            }
            catch (Exception E)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // combo họ tên
            combo_Hoten.DataSource = ds.Tables["KHACHTRO"];
            combo_Hoten.DisplayMember = "Hoten"; // hiển thị tên trên combobox
            combo_Hoten.ValueMember = "MaKhach"; // 

            // combo phòng
            combo_Phong.DataSource = ds.Tables["PHONGTRO"];
            combo_Phong.DisplayMember = "TenPhong";
            combo_Phong.ValueMember = "MaPhong";

        }

        private void btn_kiemtra_Click(object sender, EventArgs e)
        {
            
            //tạo kết nối
            Connect _conn = new Connect();
            SqlConnection conn = new SqlConnection();
            conn = _conn.conn;
            conn = new SqlConnection(_conn.conn_str);
            conn.Open();


            SqlCommand cm = new SqlCommand();

            //string query = "select SoNguoiHienTai from PHONGTRO WHERE MaPhong = '@ma_phong'";
            cm.Connection = conn;
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "sp_SoNguoiHienTai";
            cm.Parameters.AddWithValue("@ma_phong", combo_Phong.SelectedValue.ToString());

            try
            {
                int a = (int)cm.ExecuteScalar();
                if(a < 3) // 
                {
                    MessageBox.Show(combo_Phong.Text + " có thể đăng kí ! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    status = true;   
                }
                else
                {
                    MessageBox.Show(combo_Phong.Text + " đã đầy !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    status = false;
                }
            }
            catch(Exception E)
            {
                
                MessageBox.Show("Có lỗi ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_dangki_Click(object sender, EventArgs e)
        {
            if(!status)
            {
                MessageBox.Show("Phòng đã đầy, hãy chọn phòng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Connect _conn = new Connect();
                _conn.Create_connect();
                _conn.cm.CommandType = CommandType.StoredProcedure;
                _conn.cm.Connection = _conn.conn;
                _conn.cm.CommandText = "sp_DANGKY_THUEPHONG";

                _conn.cm.Parameters.AddWithValue("@makhach", combo_Hoten.SelectedValue);
                _conn.cm.Parameters.AddWithValue("@maphong", combo_Phong.SelectedValue);
                _conn.cm.Parameters.AddWithValue("@ngaythue", Picktime1.Text);
                _conn.cm.Parameters.AddWithValue("@ngayvao", Picktime2.Text);
                _conn.cm.Parameters.AddWithValue("@tiendatcoc", comboTiencoc.Text);

                _conn.cm.ExecuteNonQuery();
                MessageBox.Show("Đăng kí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _conn.Disconnect();
            }
        }
    }
}