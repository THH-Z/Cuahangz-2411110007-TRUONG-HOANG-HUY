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
    public partial class ucNhanVien : UserControl
    {
        public ucNhanVien()
        {
            InitializeComponent();
        }
        NhanvienBUS nl = new NhanvienBUS();
          public     string Quyen;
        private void lblnhanvien_Click(object sender, EventArgs e)
        {

        }

        private void ucNhanVien_Load(object sender, EventArgs e)
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
            cbbQuyen.Items.Add("admin");
            cbbQuyen.Items.Add("quanly");
            cbbQuyen.Items.Add("nhanvien");

            cbbQuyen.SelectedIndex = 0; // chọn mặc định
            dataGridView1.DataSource = nl.LayDanhSachNhanvien();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells["MaNhanVien"].Value.ToString());
                nl.xoanhanvien(id);

                dataGridView1.DataSource = nl.LayDanhSachNhanvien(); // reload
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int id;

            if (int.TryParse(txtmanhanvien.Text, out id))
            {
                nl.Suanhanvien(
                    id,
                    txttennhanvien.Text,
                    txtdienthoai.Text,
                    cbbQuyen.SelectedItem.ToString()
                );

                Loadnhanvien();
            }
            else
            {
                MessageBox.Show("Mã nhân viên phải là số!");
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            nl.themnhanvien(txttennhanvien.Text,txtdienthoai.Text,cbbQuyen.SelectedItem.ToString());
            Loadnhanvien();
        }

        private void txtmanhanvien_leave(object sender, EventArgs e)
        {
            DataTable dt = nl.Timnhanvien(txtmanhanvien.Text);

            if (dt.Rows.Count > 0)
            {
                txtmanhanvien.Text = dt.Rows[0]["manhanvien"].ToString();
                txttennhanvien.Text = dt.Rows[0]["tennhanvien"].ToString();
                txtdienthoai.Text = dt.Rows[0]["DienThoai"].ToString();
                cbbQuyen.Text = dt.Rows[0]["vaitro"].ToString();
            }
        }


        private void txtmanhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttennhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdienthoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtquyen_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbbQuyen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        void Loadnhanvien()//dùng để cập nhật lại hiển thị data sau khi cập nhật
        {
            dataGridView1.DataSource = nl.LayDanhSachNhanvien();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;

                txtmanhanvien.Text = row.Cells[0].Value.ToString();
                txttennhanvien.Text = row.Cells[1].Value.ToString();
                txtdienthoai.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
