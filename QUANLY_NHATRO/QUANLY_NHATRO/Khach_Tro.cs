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
    public partial class Khach_Tro : Form
    {
        Connect _conn = new Connect();
        DataSet ds = new DataSet();
        bool modenew;
        
        public Khach_Tro()
        {
            InitializeComponent();
        }

        public void SetConTrol(bool ok)
        {
            txtHoTen.Enabled = ok;
            bombo_GioiTinh.Enabled = ok;
            txtCMND.Enabled = ok;
            txtNgheNghiep.Enabled = ok;
            txtSDT.Enabled = ok;

            btnThem.Enabled = !ok;
            btnSua.Enabled = !ok;
            btnXoa.Enabled = !ok;
            btnLuu.Enabled = ok;
            btn_Huy.Enabled = ok;

        }
        

        private void Khach_Tro_Load(object sender, EventArgs e)
        {
            SetConTrol(false);
            string query = "Select HoTen, SDT, CMND, GioiTinh, NgheNghiep from KHACHTRO";
            _conn.Create_connect();
            // lay data
            ds = _conn.GetData_SQL(query);
            data_KhachTro.DataSource = ds.Tables[0];

            txtHoTen.DataBindings.Add("text", ds.Tables[0], "HoTen");
            txtSDT.DataBindings.Add("text", ds.Tables[0], "SDT");
            txtCMND.DataBindings.Add("text", ds.Tables[0], "CMND");
            bombo_GioiTinh.DataBindings.Add("text", ds.Tables[0], "GioiTinh");
            txtNgheNghiep.DataBindings.Add("text", ds.Tables[0], "NgheNghiep");

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dl == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SetConTrol(true);
            modenew = false;
            data_KhachTro.Enabled = false;
            // không được sửa số cmnd
            txtCMND.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SetConTrol(true);
            modenew = true;
            data_KhachTro.Enabled = false;

            // làm rỗng text box
            txtHoTen.Text = string.Empty; // = ""
            txtCMND.Text = string.Empty;
            txtSDT.Text = string.Empty;
            txtNgheNghiep.Text = string.Empty;
            // ---------------------
            txtHoTen.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Connect _conn = new Connect();// tạo biến connect
            _conn.Create_connect(); // mở kết nối

            if (modenew)
            {
                // lưu thêm mới
                // Tạo command
                SqlCommand cm = new SqlCommand();

                //Thiết lập các thuộc tính cho đối tượng Command
                cm.Connection = _conn.conn;
                cm.CommandType = CommandType.StoredProcedure; // dạng câu lệnh StoredProcedure
                cm.CommandText = "sp_THEM_THONGTIN_KHACHTRO";  // tên câu lệnh

                // Gắn các giá trị vào biến trong StoredProcedure
                cm.Parameters.Add(new SqlParameter("@hoten", txtHoTen.Text));
                //cm.Parameters.AddWithValue("@hoten", txtHoTen.Text);
                cm.Parameters.Add(new SqlParameter("@sdt", txtSDT.Text));
                cm.Parameters.Add(new SqlParameter("@cmnd", txtCMND.Text));
                cm.Parameters.Add(new SqlParameter("@gt", bombo_GioiTinh.Text));
                cm.Parameters.Add(new SqlParameter("@nghenghiep", txtNgheNghiep.Text));

                // chạy command
                try
                {
                    cm.ExecuteNonQuery();
                }
                catch(Exception E)
                {
                    MessageBox.Show("Lỗi thêm khách trọ !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

                // đặtl lại trạng thái
                data_KhachTro.Enabled = true;
                SetConTrol(false);
                _conn.Disconnect();
            }
            else
            {
                // lưu sửa
                // Tạo command
                SqlCommand cm = _conn.cm;

                //Thiết lập các thuộc tính cho đối tượng Command
                cm.Connection = _conn.conn;
                cm.CommandType = CommandType.StoredProcedure; // dạng câu lệnh StoredProcedure
                cm.CommandText = "sp_SUA_THONGTIN_KHACHTRO";  // tên câu lệnh

                // Gắn các giá trị vào biến trong StoredProcedure
                cm.Parameters.Add(new SqlParameter("@hoten", txtHoTen.Text));
                cm.Parameters.Add(new SqlParameter("@sdt", txtSDT.Text));
                cm.Parameters.Add(new SqlParameter("@cmnd", txtCMND.Text));
                cm.Parameters.Add(new SqlParameter("@gt", bombo_GioiTinh.Text));
                cm.Parameters.Add(new SqlParameter("@nghenghiep", txtNgheNghiep.Text));

                // chạy command
                cm.ExecuteNonQuery();

                // đặt lại trạng thái
                data_KhachTro.Enabled = true;
                SetConTrol(false);
                _conn.Disconnect();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan = MessageBox.Show("Bạn có chắc chắn muốn xóa?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(xacnhan == DialogResult.No)
            {
                return;
            }
            Connect _conn = new Connect();
            _conn.Create_connect();
            SqlCommand cm = _conn.cm;

            //Thiết lập các thuộc tính cho đối tượng Command
            cm.Connection = _conn.conn;
            cm.CommandType = CommandType.StoredProcedure;
            cm.CommandText = "sp_XOA_THONGTIN_KHACHTRO";

            // Thêm giá trị cho biến trong StoredProcedure
            cm.Parameters.Add(new SqlParameter("cmnd", txtCMND.Text));
            // chạy lệnh
            cm.ExecuteNonQuery();
            _conn.Disconnect();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Khach_Tro f = new Khach_Tro();
            f.Show();
            this.Close();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            // đặt lại trạng thái
            data_KhachTro.Enabled = true;
            SetConTrol(false);
        }
    }
}
