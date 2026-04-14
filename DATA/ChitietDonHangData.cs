using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class ChitietDonHangData
    {
        DBConnect db = new DBConnect();
        public DataTable LayDanhSachChiTietDonHang()
        {
            string sql = "SELECT DISTINCT * FROM CHITIETDONHANG";

            SqlDataAdapter da = new SqlDataAdapter(sql, db.conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void themchitietdonhang(string masanpham,int soluong)
        {
            string sql = "INSERT INTO CHITIETDONHANG ( MaSanPham, SoLuong) " +
                         "VALUES (@masanpham, @soluong)";

            SqlCommand cmd = new SqlCommand(sql, db.conn);

           
            cmd.Parameters.AddWithValue("@masanpham", masanpham);
            cmd.Parameters.AddWithValue("@soluong", soluong);

            db.conn.Open();
            cmd.ExecuteNonQuery();
            db.conn.Close();
        }



        public void themchitietdonhang(int madonhang, int masanpham, int soluong)
        {
            string sql = "INSERT INTO CHITIETDONHANG (MaDonHang, MaSanPham, SoLuong) " +
                         "VALUES (@madonhang, @masanpham, @soluong)";

            SqlCommand cmd = new SqlCommand(sql, db.conn);

            cmd.Parameters.AddWithValue("@madonhang", madonhang);
            cmd.Parameters.AddWithValue("@masanpham", masanpham);
            cmd.Parameters.AddWithValue("@soluong", soluong);

            db.conn.Open();
            cmd.ExecuteNonQuery();
            db.conn.Close();
        }

        public void xoachitietdonhang(int madonhang, int masanpham)
        {
            string sql = "DELETE FROM CHITIETDONHANG WHERE MaDonHang = @madonhang AND MaSanPham = @masanpham";

            SqlCommand cmd = new SqlCommand(sql, db.conn);

            cmd.Parameters.AddWithValue("@madonhang", madonhang);
            cmd.Parameters.AddWithValue("@masanpham", masanpham);

            db.conn.Open();
            cmd.ExecuteNonQuery();
            db.conn.Close();
        }

        public DataTable TimChiTietDonHang(int madonhang)
        {
            string sql = "SELECT * FROM CHITIETDONHANG WHERE MaDonHang = @madonhang";

            SqlCommand cmd = new SqlCommand(sql, db.conn);
            cmd.Parameters.AddWithValue("@madonhang", madonhang);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            return dt;
        }

        public void suachitietdonhang(int madonhang, int masanpham, int soluong)
        {
            string sql = "UPDATE CHITIETDONHANG SET SoLuong = @soluong " +
                         "WHERE MaDonHang = @madonhang AND MaSanPham = @masanpham";

            SqlCommand cmd = new SqlCommand(sql, db.conn);

            cmd.Parameters.AddWithValue("@madonhang", madonhang);
            cmd.Parameters.AddWithValue("@masanpham", masanpham);
            cmd.Parameters.AddWithValue("@soluong", soluong);

            db.conn.Open();
            cmd.ExecuteNonQuery();
            db.conn.Close();
        }




    }
}
