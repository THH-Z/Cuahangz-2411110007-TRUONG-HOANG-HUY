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
    public partial class ucSanPham : UserControl
    {
        public ucSanPham()
        {
            InitializeComponent();
        }
         public  string Quyen;
        SanPhamBUS sp = new SanPhamBUS();
        private void ucSanPham_Load(object sender, EventArgs e)
        {

            if (Quyen == "admin")
             {
                 btnThem.Enabled = true;
                 btnSua.Enabled = true;
                 btnxoa.Enabled = true;
             }
             else
             {
                 //btnthem.Enabled = false; nhân viên chỉ không được xoá
                 btnSua.Enabled = false;
                 btnxoa.Enabled= false;
             }
            dataGridView1.DataSource = sp.LayDanhSachSanPham();
        }

        private void lblTensanpham_Click(object sender, EventArgs e)
        {

        }

        private void lblsoluong_Click(object sender, EventArgs e)
        {

        }

        private void lblmasanpham_Click(object sender, EventArgs e)
        {

        }

        private void lblgia_Click(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            sp.xoasanpham(txtmasanpham.Text);
            Loadsanpham();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int soluong;//dùng kĩ thuật này để không bị xung đột kiểu dữ liệu
            decimal gia;

            bool checkSoLuong = int.TryParse(txtsoluongsanpham.Text, out soluong);//Kiểm tra xem người dùng nhập có phải là số hợp lệ không, và nếu đúng thì chuyển sang kiểu số luôn
            bool checkGia = decimal.TryParse(txtgia.Text, out gia);// ==  thử nếu dúng kiểu dữ liệu thì true không thì false

            if (!checkSoLuong)
            {
                MessageBox.Show("Số lượng phải là số nguyên!");
                return;
            }

            if (!checkGia)
            {
                MessageBox.Show("Giá phải là số!");
                return;
            }

            sp.themsanpham(
                txttensanpham.Text,
                soluong,
                gia
            );
            Loadsanpham();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int soluong;//dùng kĩ thuật này để không bị xung đột kiểu dữ liệu
            decimal gia;

            bool checkSoLuong = int.TryParse(txtsoluongsanpham.Text, out soluong);//Kiểm tra xem người dùng nhập có phải là số hợp lệ không, và nếu đúng thì chuyển sang kiểu số luôn
            bool checkGia = decimal.TryParse(txtgia.Text, out gia);// ==  thử nếu dúng kiểu dữ liệu thì true không thì false

            if (!checkSoLuong)
            {
                MessageBox.Show("Số lượng phải là số nguyên!");
                return;
            }

            if (!checkGia)
            {
                MessageBox.Show("Giá phải là số!");
                return;
            }

            sp.SuaSanPham(
                txtmasanpham.Text, txttensanpham.Text, soluong, gia
            );
            Loadsanpham();
        }

        private void txtmasanpham_leave(object sender, EventArgs e)
        {
            DataTable dt = sp.TimSanpham(txtmasanpham.Text);

            if (dt.Rows.Count > 0)
            {
                txtmasanpham.Text = dt.Rows[0]["masanpham"].ToString();
                txttensanpham.Text = dt.Rows[0]["tensanpham"].ToString();
                txtsoluongsanpham.Text = dt.Rows[0]["soluongsanpham"].ToString();
                txtgia.Text = dt.Rows[0]["gia"].ToString();
            }
        }

        private void txttensanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsoluongsanpham_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgia_TextChanged(object sender, EventArgs e)
        {

        }

         void Loadsanpham()//dùng để cập nhật lại hiển thị data sau khi cập nhật
        {
            dataGridView1.DataSource = sp.LayDanhSachSanPham();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                txtmasanpham.Text = row.Cells[0].Value.ToString();
                txttensanpham.Text = row.Cells[1].Value.ToString();
                txtsoluongsanpham.Text = row.Cells[2].Value.ToString();
                txtgia.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
