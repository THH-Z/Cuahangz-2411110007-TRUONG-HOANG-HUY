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
    public partial class ucDonHang : UserControl
    {
        public ucDonHang()
        {
            InitializeComponent();
        }
        DonHangBUS dh = new DonHangBUS();
       public string Quyen;
        private void ucDonHang_Load(object sender, EventArgs e)
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
            dataGridView1.DataSource = dh.LayDanhSachDonHang();
        }

        private void txtmadonhang_leave(object sender, EventArgs e)
        {
            DataTable dt = dh.TimDonHang(txtmadonhang.Text);

            if (dt.Rows.Count > 0)
            {
                txtmadonhang.Text = dt.Rows[0]["madonhang"].ToString();
                chonngaytao.Text = dt.Rows[0]["ngaytao"].ToString();
                txtmakhachhang.Text = dt.Rows[0]["makhachhang"].ToString();
                txtmanhanvien.Text = dt.Rows[0]["manhanvien"].ToString();
            }
        }

        private void txtngaytao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmakhachhang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmanhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            dh.xoadonhang(txtmadonhang.Text);
            Loaddonhang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int makhachhang;//dùng kĩ thuật này để không bị xung đột kiểu dữ liệu
            int manhanvien;
            DateTime ngaytao;

            bool checkngaytao = DateTime.TryParse(chonngaytao.Text, out ngaytao);//Kiểm tra xem người dùng nhập có phải là số hợp lệ không, và nếu đúng thì chuyển sang kiểu số luôn
            bool checkmakhachhang = int.TryParse(txtmakhachhang.Text, out makhachhang);// ==  thử nếu dúng kiểu dữ liệu thì true không thì false
            bool checkmanhanvien = int.TryParse(txtmanhanvien.Text, out manhanvien);


            if (!checkngaytao)
            {
                MessageBox.Show("Chọn lại");
                return;
            }

            if (!checkmanhanvien)
            {
                MessageBox.Show("Mã Nhân Viên phải là số!");
                return;
            }

            if (!checkmakhachhang)
            {
                MessageBox.Show("Mã Khách Hàng phải là số!");
                return;
            }
           
            dh.themdonhang(
                ngaytao, 
                makhachhang, 
                manhanvien
            );
            Loaddonhang();
        }
        void Loaddonhang()//dùng để cập nhật lại hiển thị data sau khi cập nhật
        {
            dataGridView1.DataSource = dh.LayDanhSachDonHang();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            int makhachhang;//dùng kĩ thuật này để không bị xung đột kiểu dữ liệu
            int manhanvien;
            int madonhang;
            DateTime ngaytao;

            bool checkngaytao = DateTime.TryParse(chonngaytao.Text, out ngaytao);//Kiểm tra xem người dùng nhập có phải là số hợp lệ không, và nếu đúng thì chuyển sang kiểu số luôn
            bool checkmakhachhang = int.TryParse(txtmakhachhang.Text, out makhachhang);// ==  thử nếu dúng kiểu dữ liệu thì true không thì false
            bool checkmanhanvien = int.TryParse(txtmanhanvien.Text, out manhanvien);
            bool checkmadonhang = int.TryParse(txtmadonhang.Text, out madonhang);

            if (!checkngaytao)
            {
                MessageBox.Show("Chọn lại");
                return;
            }

            if (!checkmanhanvien)
            {
                MessageBox.Show("Mã Nhân Viên phải là số!");
                return;
            }

            if (!checkmakhachhang)
            {
                MessageBox.Show("Mã Khách Hàng phải là số!");
                return;
            }

            dh.suadonhang(
                txtmadonhang.Text,
                ngaytao,
                makhachhang,
                manhanvien
            );
            Loaddonhang();
        }

        private void chonngaytao_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                txtmadonhang.Text = row.Cells[0].Value.ToString();
                chonngaytao.Text = row.Cells[1].Value.ToString();
                txtmakhachhang.Text = row.Cells[2].Value.ToString();
                txtmanhanvien.Text = row.Cells[3].Value.ToString();
            }
        }
    }
}
