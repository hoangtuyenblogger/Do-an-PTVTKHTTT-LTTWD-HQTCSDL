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

        public bool Login(string taikhoan, string matkhau)
        {
            Connect _conn = new Connect();
            _conn.Create_connect();
            _conn.cm.CommandType = CommandType.StoredProcedure;
            _conn.cm.Connection = _conn.conn;
            _conn.cm.CommandText = "Login";
            _conn.cm.Parameters.AddWithValue("@username", txtTaiKhoan.Text.ToString());
            _conn.cm.Parameters.AddWithValue("@password", txtMatKhau.Text.ToString());

            SqlDataReader dr = _conn.cm.ExecuteReader();
            if(dr.Read()) //
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
            if(Login(tk, mk) == true)
            {
                frm_main f = new frm_main();
                f.Show();
                this.Hide();
                
            }
            else
            {
                //
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }

        private void Form_Login_MouseEnter(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
        }
    }
}
