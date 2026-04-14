using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class KhachHangData
    {
        DBConnect db = new DBConnect();
        public DataTable LayDanhSachKhachHang()
        {
            string sql = "SELECT * FROM KHACHHANG";

            SqlDataAdapter da = new SqlDataAdapter(sql, db.conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public void themkhachhang(string tenkhachhang, string dienthoai)
        {
            string sql = "INSERT INTO KhachHang (TenKhachHang, DienThoai) VALUES (@ten, @dt)";

            SqlCommand cmd = new SqlCommand(sql, db.conn);//Tạo một command gửi lệnh SQL tới database.
                                                          //db.conn kết nối tới SQL Server
                                                          //sql câu lệnh SQL
                                                          //SqlCommand = lá thư gửi database
            //makhachhang là cột tự tăng IDENTITY(1,1) không cần nhập
            cmd.Parameters.AddWithValue("@ten", tenkhachhang); //chuyền dữ liệu vào tham số mã khách hàng do mình nhập vào biến 'tenkhachhang'
            cmd.Parameters.AddWithValue("@dt", dienthoai);//  ==

            db.conn.Open();//mở kết nối đến database
            cmd.ExecuteNonQuery();//QUAN TRỌNG dòng này dùng cho INSERT UPDATE DELETE
            db.conn.Close();//đóng kết nối đến database
        }
         

        public void xoakhachhang(string makhachhang)
        {
            string sql = "DELETE FROM KhachHang WHERE makhachhang = @ma";
            SqlCommand cmd = new SqlCommand(sql, db.conn);

            cmd.Parameters.AddWithValue("@ma", makhachhang);

            db.conn.Open();
            cmd.ExecuteNonQuery();
            db.conn.Close();
        }

        public DataTable TimKhachHang(string makh)
        {
            string sql = "SELECT * FROM KhachHang WHERE makhachhang = @ma";

            SqlCommand cmd = new SqlCommand(sql, db.conn);
            cmd.Parameters.AddWithValue("@ma", makh);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public void SuaKhachHang(string makhachhang, string tenkhachhang, string dienthoai)
        {
            string sql = "UPDATE KhachHang SET TenKhachHang = @ten, DienThoai = @dt WHERE makhachhang = @ma";

            SqlCommand cmd = new SqlCommand(sql, db.conn);

            cmd.Parameters.AddWithValue("@ma", makhachhang);
            cmd.Parameters.AddWithValue("@ten", tenkhachhang);
            cmd.Parameters.AddWithValue("@dt", dienthoai);

            db.conn.Open();
            cmd.ExecuteNonQuery();
            db.conn.Close();
        }


    }
}
