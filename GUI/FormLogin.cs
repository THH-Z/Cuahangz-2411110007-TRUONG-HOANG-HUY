using BUS;
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

namespace GUI
{
    public partial class FormLogin : Form
    {
        TaiKhoanBUS tkbus = new TaiKhoanBUS();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txttentaikhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            TaiKhoanBUS tkbus = new TaiKhoanBUS();

            string user = txttentaikhoan.Text;
            string pass = txtmatkhau.Text;

            DataTable dt = tkbus.LayTaiKhoanBUS(user, pass);

            if (dt.Rows.Count > 0)
            {
                string quyen = dt.Rows[0]["Quyen"].ToString();
                string tentaikhoan = txttentaikhoan.Text;
                FormMain f = new FormMain(quyen,tentaikhoan);// tạo form chính
                this.Hide();          // ẩn form login
                f.ShowDialog();       // form chính chạy độc lập
                this.Close();         // tắt form login
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void FormLogin_Load(object sender, EventArgs e)
        {/* test kết nối DATEBASE
            SqlConnection conn = new SqlConnection(
                @"Server=LAPTOP-JRFGPP05;Database=CuaHangz;Integrated Security=True;"
            );

            try
            {
                conn.Open();
                MessageBox.Show("Kết nối thành công!");
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Kết nối thất bại!");
            }*/
        }

        private void lbldangnhap_Click(object sender, EventArgs e)
        {

        }
    }
}
