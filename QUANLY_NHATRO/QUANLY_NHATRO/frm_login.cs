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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        bool Login(string taikhoan, string matkhau)
        {
            Connect _conn = new Connect();
            _conn.Create_connect();
           
            string query = "SELECT * FROM TaiKhoan Where Username = '"+ taikhoan +"'  and Password = '" + matkhau + "'";
            _conn.cm = new SqlCommand(query, _conn.conn);
            SqlDataReader dr = _conn.cm.ExecuteReader();
            if(dr.Read()) //nếu tồn tại
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _conn.Disconnect();
                return true;
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _conn.Disconnect();
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tk = txtTaiKhoan.Text.ToString();
            string mk = txtMatKhau.Text.ToString();
            if(Login(tk,mk))
            {
                frm_main main = new frm_main();              
                main.Show();
                this.Visible = false;
            }
            else
            {
                // 
            }
        }
    }
}
