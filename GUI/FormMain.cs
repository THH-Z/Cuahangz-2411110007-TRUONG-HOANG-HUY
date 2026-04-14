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
    public partial class FormMain : Form
    {
        string Quyen;
        string TenDangNhap;
        public FormMain(string q, string user)
        {
            InitializeComponent();
            Quyen = q;
            TenDangNhap = user;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            txttenacc.Text = TenDangNhap;
        }

        private void btndangxuat_Click(object sender, EventArgs e)
        {
            FormLogin mainForm = new FormLogin();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void llblkhachhang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
       
            ucKhackhang uc = new ucKhackhang();
            uc.Quyen = Quyen;
            LoadUserControl(uc);
        }

       

        private void llblnhanvien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            ucNhanVien nv = new ucNhanVien();
            nv.Quyen = Quyen;
            LoadUserControl(nv);
        }

        private void llblsanpham_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            ucSanPham sp = new ucSanPham();
            sp.Quyen = Quyen;
            LoadUserControl(sp);
           
        }

        private void llblhoadon_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            ucDonHang donHang = new ucDonHang();
            donHang.Quyen = Quyen;
            LoadUserControl(donHang);
           
        }

        private void llblChitietdonhang_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
           ucChiTietDonHang ch = new ucChiTietDonHang();
            ch.Quyen = Quyen;
            LoadUserControl(ch);
        }

       
        public void LoadUserControl(UserControl uc)
        {
            panelchinh.Controls.Clear();      // xoá control cũ
            uc.Dock = DockStyle.Fill;        // fill toàn panel
            panelchinh.Controls.Add(uc);      // thêm vào panel
        } 

        private void panelchinh_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txttenacc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcuahangz_Click(object sender, EventArgs e)
        {

        } 
        private void paneltop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
