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
        bool status = true;
        private void frm_dangki_Load(object sender, EventArgs e)
        {
            Connect _conn = new Connect();

            SqlCommand cm = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            try
            {
                _conn.Create_connect();

                cm = new SqlCommand("SELECT * FROM VIEW_KHACHTRO_CHUATRO", _conn.conn);
                da = new SqlDataAdapter(cm);
                da.Fill(ds, "KHACHTRO");

                cm = new SqlCommand("SELECT * FROM VIEW_PHONGTRO_CONTRONG", _conn.conn);
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

                _conn.cm.Parameters.AddWithValue("@makhach", combo_Hoten.SelectedValue.ToString());
                _conn.cm.Parameters.AddWithValue("@maphong", combo_Phong.SelectedValue.ToString());
                _conn.cm.Parameters.AddWithValue("@ngaythue", Picktime1.Text);
                _conn.cm.Parameters.AddWithValue("@ngayvao", Picktime2.Text);
                _conn.cm.Parameters.AddWithValue("@tiendatcoc", comboTiencoc.Text);
                try
                {
                    _conn.cm.ExecuteNonQuery();
                }
                catch(Exception E)
                {
                    MessageBox.Show("Có lỗi cơ sở dữ liệu ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                MessageBox.Show("Đăng kí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _conn.Disconnect();
                frm_dangki f = new frm_dangki();
               
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}