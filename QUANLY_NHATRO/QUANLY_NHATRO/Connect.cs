using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QUANLY_NHATRO
{
    public class Connect
    {
        public string conn_str = @"Data Source=ADMIN;Initial Catalog=QuanLy_NhaTro;Integrated Security=True;Connect Timeout=60";
        public SqlConnection conn = new SqlConnection();
        public SqlDataAdapter da = new SqlDataAdapter();
        public SqlCommand cm = new SqlCommand();
        public DataSet ds = new DataSet();
        public DataTable tb = new DataTable();

       public void Create_connect()
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
        public void Disconnect()
        {
            conn.Close();
            da.Dispose();
            da = null;
        }
        public DataSet GetData_SQL(string query)
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
            Disconnect();
            return ds;
        }

        
    }
}
