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
    public partial class frm_main : Form
    {
        string conn_str = @"Data Source=ADMIN;Initial Catalog=QuanLy_NhaTro;Integrated Security=True;Connect Timeout=60";
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cm = new SqlCommand();
        DataSet ds = new DataSet();
        DataTable tb = new DataTable();
        public frm_main()
        {
            InitializeComponent();
        }

        void Create_connect()
        {
            try
            {
                conn = new SqlConnection(conn_str);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void Disconnect()
        {
            conn.Close();
            da.Dispose();
            da = null;
        }
        DataSet GetData_SQL(string query)
        {
            try
            {
                Create_connect(); // mở kết nối
                cm = new SqlCommand(query, conn);
                da = new SqlDataAdapter(cm);
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            da.Fill(ds);
            conn.Close();
            Disconnect();
            return ds;
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            
            Create_connect();
            string query = "select TenPhong, MaKV, TrangThai, SoNguoiHienTai, SLToiDa from PHONGTRO";
            ds = GetData_SQL(query);
            dataPhong.DataSource = ds.Tables[0];
            dataPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            Khach_Tro khach_tro = new Khach_Tro();
            khach_tro.Visible = true;
        }

        private void đăngKíThuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_dangki dangki = new frm_dangki();
            dangki.Visible = true;
        }
    }
}
