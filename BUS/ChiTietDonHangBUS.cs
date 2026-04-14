using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChiTietDonHangBUS
    {
        ChitietDonHangData sp = new ChitietDonHangData();

        public DataTable LayDanhSachChiTietDonHang()
        {
            return sp.LayDanhSachChiTietDonHang();
        }

        public void themchitietdonhang(int madonhang, int masanpham, int soluong)
        {
            sp.themchitietdonhang(madonhang, masanpham, soluong);
        }

        public void xoachitietdonhang(int madonhang, int masanpham)
        {
            sp.xoachitietdonhang(madonhang, masanpham);
        }

        public DataTable TimChiTietDonHang(int madonhang)
        {
            return sp.TimChiTietDonHang(madonhang);
        }

        public void suachitietdonhang(int madonhang, int masanpham, int soluong)
        {
            sp.suachitietdonhang(madonhang, masanpham, soluong);
        }
    }
}
