using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucKhackhang : UserControl
    {
        public ucKhackhang()
        {
            InitializeComponent();
        }
        KhachHangBUS bus = new KhachHangBUS();
        public   string Quyen;
        private void ucKhackhang_Load(object sender, EventArgs e)
        {
             if (Quyen == "admin")
            {
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                //btnthem.Enabled = false; nhân viên không được phép xoá dữ liệu
                btnSua.Enabled = false;
                btnXoa.Enabled= false;
            }
            dataGridView1.DataSource = bus.LayDanhSachKhachHang();

        }

        private void lblKhachHang_Click(object sender, EventArgs e)
        {
            
        }

        private void txtmakhachhang_leave(object sender, EventArgs e)
        {
            DataTable dt = bus.TimKhachHang(txtmakhachhang.Text);

            if (dt.Rows.Count > 0)
            {
                txttenkhachhang.Text = dt.Rows[0]["TenKhachHang"].ToString();
                txtdienthoai.Text = dt.Rows[0]["DienThoai"].ToString();
            }
        }

        private void txttenkhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdienthoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                txtmakhachhang.Text = row.Cells[0].Value.ToString();
                txttenkhachhang.Text = row.Cells[1].Value.ToString();
                txtdienthoai.Text = row.Cells[2].Value.ToString();
            }
        }
        void LoadKhachHang()//dùng để cập nhật lại hiển thị data sau khi cập nhật
        {
            dataGridView1.DataSource = bus.LayDanhSachKhachHang();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            bus.themkhachhang(txttenkhachhang.Text, txtdienthoai.Text);
            LoadKhachHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bus.xoakhachhang(txtmakhachhang.Text);
            LoadKhachHang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            bus.SuaKhachHang(txtmakhachhang.Text, txttenkhachhang.Text, txtdienthoai.Text);

            LoadKhachHang(); // refresh bảng
        }

        private void txtmakhachhang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
