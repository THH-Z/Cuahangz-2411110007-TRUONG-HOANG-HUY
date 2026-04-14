using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class SanPhamData
    {
        DBConnect db = new DBConnect();
        public DataTable LayDanhSachSanPham()
        {
            string sql = "SELECT * FROM SANPHAM";

            SqlDataAdapter da = new SqlDataAdapter(sql, db.conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void themsanpham( string tensanpham,int soluongsanpham,decimal giasanpham)
        {
            string sql = "INSERT INTO SANPHAM (TenSanPham, SoLuongSanPham, Gia) VALUES (@tensanpham, @soluongsanpham, @gia)";

            SqlCommand cmd = new SqlCommand(sql, db.conn);//Tạo một command gửi lệnh SQL tới database.
                                                          //db.conn kết nối tới SQL Server
                                                          //sql câu lệnh SQL
                                                          //SqlCommand = lá thư gửi database
                                                          //makhachhang là cột tự tăng IDENTITY(1,1) không cần nhập
            //chuyền dữ liệu vào tham số mã khách hàng do mình nhập vào biến 'tenkhachhang'
            cmd.Parameters.AddWithValue("@tensanpham", tensanpham);//  ==
            cmd.Parameters.AddWithValue("@soluongsanpham", soluongsanpham);
            cmd.Parameters.AddWithValue("@gia", giasanpham);

            db.conn.Open();//mở kết nối đến database
            cmd.ExecuteNonQuery();//QUAN TRỌNG dòng này dùng cho INSERT UPDATE DELETE
            db.conn.Close();//đóng kết nối đến database
        }

        
        public void xoasanpham(string masanpham)
        {
            string sql = "DELETE FROM SANPHAM WHERE masanpham = @masanpham";
            SqlCommand cmd = new SqlCommand(sql, db.conn);

            cmd.Parameters.AddWithValue("@masanpham", masanpham);

            db.conn.Open();
            cmd.ExecuteNonQuery();
            db.conn.Close();
        }
        
        public DataTable TimSanpham(string masanpham)
        {
            string sql = "SELECT * FROM SANPHAM WHERE masanpham = @masanpham";

            SqlCommand cmd = new SqlCommand(sql, db.conn);
            cmd.Parameters.AddWithValue("@masanpham", masanpham);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public void SuaSanPham(string masanpham, string tensanpham, int soluongsanpham, decimal gia)
        {
            string sql = "UPDATE SANPHAM SET TenSanPham = @tensanpham, soluongsanpham = @soluongsanpham, gia = @gia WHERE masanpham = @masanpham";

            SqlCommand cmd = new SqlCommand(sql, db.conn);

            cmd.Parameters.AddWithValue("@masanpham", masanpham);
            cmd.Parameters.AddWithValue("@tensanpham", tensanpham);
            cmd.Parameters.AddWithValue("@soluongsanpham", soluongsanpham);
            cmd.Parameters.AddWithValue("@gia", gia);

            db.conn.Open();
            cmd.ExecuteNonQuery();
            db.conn.Close();
        }

    }
}
