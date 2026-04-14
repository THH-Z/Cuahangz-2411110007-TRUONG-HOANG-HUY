using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;

namespace BUS
{
    public class KhachHangBUS
    {
        KhachHangData dal = new KhachHangData();

        public DataTable LayDanhSachKhachHang()
        {
            return dal.LayDanhSachKhachHang();
        }

        public void themkhachhang( string tenkhachhang, string dienthoai)
        {
            dal.themkhachhang(tenkhachhang, dienthoai);
        }

        public void xoakhachhang(string makhachhang)
        {
            dal.xoakhachhang(makhachhang);
        }

        public DataTable TimKhachHang(string makh)
        {
            return dal.TimKhachHang(makh);
        }


        public void SuaKhachHang(string makhachhang, string tenkhachhang, string dienthoai)
        {
            dal.SuaKhachHang(makhachhang, tenkhachhang, dienthoai);
        }

    }
}
