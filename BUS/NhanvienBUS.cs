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
    public class NhanvienBUS
    {
        NhanvienData nv = new NhanvienData();

        public DataTable LayDanhSachNhanvien()
        {
            return nv.LayDanhSachNhanvien();
        }
        public void themnhanvien(string tennhanvien, string dienthoai,string vaitro)
        {
            nv.themnhanvien(tennhanvien, dienthoai,vaitro);
        }

        public void xoanhanvien(int manhanvien)
        {
            nv.xoanhanvien(manhanvien);
        }

        public DataTable Timnhanvien(string manhanvien)
        {
            return nv.Timnhanvien(manhanvien);
        }
        public void Suanhanvien(int manhanvien, string tennhanvien, string dienthoai,string vaitro)
        {
            nv.Suanhanvien(manhanvien, tennhanvien, dienthoai,vaitro);
        }
    }
}
