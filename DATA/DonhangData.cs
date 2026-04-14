using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class DonhangData
    {
        DBConnect db = new DBConnect();
        public DataTable LayDanhSachDonHang()
        {
            string sql = "SELECT * FROM DONHANG";

            SqlDataAdapter da = new SqlDataAdapter(sql, db.conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public void themdonhang(DateTime ngaytao, int makhachhang, int manhanvien)
        {
            string sql = "INSERT INTO DONHANG (NgayTao, MaKhachHang, MaNhanVien) " +
                         "VALUES (@ngaytao, @makhachhang, @manhanvien)";

            SqlCommand cmd = new SqlCommand(sql, db.conn);

            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@makhachhang", makhachhang);
            cmd.Parameters.AddWithValue("@manhanvien", manhanvien);

            db.conn.Open();
            cmd.ExecuteNonQuery();
            db.conn.Close();
        }


        public void xoadonhang(string madonhang)
        {
            string sql = "DELETE FROM DONHANG WHERE MaDonHang = @madonhang";

            SqlCommand cmd = new SqlCommand(sql, db.conn);
            cmd.Parameters.AddWithValue("@madonhang", madonhang);

            db.conn.Open();
            cmd.ExecuteNonQuery();
            db.conn.Close();
        }

        public DataTable TimDonHang(string madonhang)
        {
            string sql = "SELECT * FROM DONHANG WHERE MaDonHang = @madonhang";

            SqlCommand cmd = new SqlCommand(sql, db.conn);
            cmd.Parameters.AddWithValue("@madonhang", madonhang);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }

        public void suadonhang(string madonhang, DateTime ngaytao, int makhachhang, int manhanvien)
        {
            string sql = "UPDATE DONHANG SET NgayTao = @ngaytao, MaKhachHang = @makhachhang, MaNhanVien = @manhanvien WHERE MaDonHang = @madonhang";

            SqlCommand cmd = new SqlCommand(sql, db.conn);

            cmd.Parameters.AddWithValue("@madonhang", madonhang);
            cmd.Parameters.AddWithValue("@ngaytao", ngaytao);
            cmd.Parameters.AddWithValue("@makhachhang", makhachhang);
            cmd.Parameters.AddWithValue("@manhanvien", manhanvien);

            db.conn.Open();
            cmd.ExecuteNonQuery();
            db.conn.Close();
        }






    }
}
