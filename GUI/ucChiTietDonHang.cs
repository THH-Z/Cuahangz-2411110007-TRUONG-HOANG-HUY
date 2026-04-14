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
    public partial class ucChiTietDonHang : UserControl
    {
        public ucChiTietDonHang()
        {
            InitializeComponent();
        }
        ChiTietDonHangBUS ctdh = new ChiTietDonHangBUS();
       public string Quyen;
        private void ucChiTietDonHang_Load(object sender, EventArgs e)
        {
             if (Quyen == "admin")
            {
               
                btnSua.Enabled = true;
            
            }
            else
            {
                //btnthem.Enabled = false; nhân viên chỉ không được xoá
                btnSua.Enabled = false;
              
            }
            dataGridView1.DataSource = ctdh.LayDanhSachChiTietDonHang();
        }

        private void txtmadonhang_leave(object sender, EventArgs e)
        {
            int madonhang;
            int.TryParse(txtmadonhang.Text, out madonhang);
            DataTable dt = ctdh.TimChiTietDonHang(madonhang);

            if (dt.Rows.Count > 0)
            {
                txtmadonhang.Text = dt.Rows[0]["madonhang"].ToString();
                txtmasanpham.Text = dt.Rows[0]["masanpham"].ToString();
                txtsoluong.Text = dt.Rows[0]["soluong"].ToString();
                
            }
        }

        private void txtmasanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {

        }

       
       
        void Loadchitietdonhang()//dùng để cập nhật lại hiển thị data sau khi cập nhật
        {
            dataGridView1.DataSource = ctdh.LayDanhSachChiTietDonHang();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int madonhang, masanpham, soluong;

            if (!int.TryParse(txtmadonhang.Text, out madonhang))
            {
                MessageBox.Show("Mã đơn hàng phải là số!");
                return;
            }

            if (!int.TryParse(txtmasanpham.Text, out masanpham))
            {
                MessageBox.Show("Mã sản phẩm phải là số!");
                return;
            }

            if (!int.TryParse(txtsoluong.Text, out soluong))
            {
                MessageBox.Show("Số lượng phải là số!");
                return;
            }

            ctdh.suachitietdonhang(madonhang, masanpham, soluong);

            MessageBox.Show("Sửa thành công!");
            LoadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int madonhang, masanpham;

            if (!int.TryParse(txtmadonhang.Text, out madonhang))
            {
                MessageBox.Show("Mã đơn hàng phải là số!");
                return;
            }

            if (!int.TryParse(txtmasanpham.Text, out masanpham))
            {
                MessageBox.Show("Mã sản phẩm phải là số!");
                return;
            }

            ctdh.xoachitietdonhang(madonhang, masanpham);

            MessageBox.Show("Xóa thành công!");
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int madonhang, masanpham, soluong;

            if (!int.TryParse(txtmadonhang.Text, out madonhang))
            {
                MessageBox.Show("Mã đơn hàng phải là số!");
                return;
            }

            if (!int.TryParse(txtmasanpham.Text, out masanpham))
            {
                MessageBox.Show("Mã sản phẩm phải là số!");
                return;
            }

            if (!int.TryParse(txtsoluong.Text, out soluong))
            {
                MessageBox.Show("Số lượng phải là số!");
                return;
            }

            ctdh.themchitietdonhang(madonhang, masanpham, soluong);

            MessageBox.Show("Thêm thành công!");
            LoadData();
        }

        public void LoadData()
        {
            int madonhang;

            if (int.TryParse(txtmadonhang.Text, out madonhang))
            {
                dataGridView1.DataSource = ctdh.TimChiTietDonHang(madonhang);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtmadonhang.Text = dataGridView1.Rows[e.RowIndex].Cells["MaDonHang"].Value.ToString();
                txtmasanpham.Text = dataGridView1.Rows[e.RowIndex].Cells["MaSanPham"].Value.ToString();
                txtsoluong.Text = dataGridView1.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
