using DATA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DonHangBUS
    {
        DonhangData sp = new DonhangData();

        public DataTable LayDanhSachDonHang()
        {
            return sp.LayDanhSachDonHang();
        }

        public void themdonhang(DateTime ngaytao, int makhachhang, int manhanvien)
        {
           sp.themdonhang(ngaytao,makhachhang,manhanvien);
          
        }

        public void xoadonhang(string madonhang)
        {
            sp.xoadonhang(madonhang);
        }

        public DataTable TimDonHang(string madonhang)
        {

            return sp.TimDonHang(madonhang);
        }



        public void suadonhang(string madonhang, DateTime ngaytao, int makhachhang, int manhanvien)
        {
            sp.suadonhang(madonhang,ngaytao,makhachhang,manhanvien);
        }
    }
}
