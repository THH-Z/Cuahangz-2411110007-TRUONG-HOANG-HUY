using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BUS
{
    public class SanPhamBUS
    {
        SanPhamData sp = new SanPhamData();

        public DataTable LayDanhSachSanPham()
        {
            return sp.LayDanhSachSanPham();
        }


        public void themsanpham( string tensanpham, int soluongsanpham, decimal giasanpham)
        {
            sp.themsanpham( tensanpham, soluongsanpham, giasanpham);
        }

        public void xoasanpham(string masanpham)
        {
            sp.xoasanpham(masanpham);
        }

        public DataTable TimSanpham(string masanpham)
        {

            return sp.TimSanpham(masanpham);
        }



        public void SuaSanPham(string masanpham, string tensanpham, int soluongsanpham, decimal gia)
        {
            sp.SuaSanPham( masanpham,  tensanpham,  soluongsanpham, gia);
        }
    }
}
