using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
   public class NhanvienData
    {
        DBConnect db = new DBConnect();
        public DataTable LayDanhSachNhanvien()
        {
            string sql = "SELECT * FROM NHANVIEN";

            SqlDataAdapter da = new SqlDataAdapter(sql, db.conn);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public void themnhanvien(string tennhanvien, string dienthoai,string vaitro)
        {
            string sql = "INSERT INTO NHANVIEN (TenNhanVien, DienThoai, VaiTro) VALUES (@tennv, @dt,@vaitro)";

            SqlCommand cmd = new SqlCommand(sql, db.conn);//Tạo một command gửi lệnh SQL tới database.
                                                          //db.conn kết nối tới SQL Server
                                                          //sql câu lệnh SQL
                                                          //SqlCommand = lá thư gửi database
                                                          //makhachhang là cột tự tăng IDENTITY(1,1) không cần nhập
            cmd.Parameters.AddWithValue("@tennv", tennhanvien); //chuyền dữ liệu vào tham số mã khách hàng do mình nhập vào biến 'tenkhachhang'
            cmd.Parameters.AddWithValue("@dt", dienthoai);//  ==
            cmd.Parameters.AddWithValue("@vaitro", vaitro);

            db.conn.Open();//mở kết nối đến database
            cmd.ExecuteNonQuery();//QUAN TRỌNG dòng này dùng cho INSERT UPDATE DELETE
            db.conn.Close();//đóng kết nối đến database
        }

        
        public void xoanhanvien(int manhanvien)
        {
            string sql = "DELETE FROM NHANVIEN WHERE manhanvien = @manhanvien";
            SqlCommand cmd = new SqlCommand(sql, db.conn);

            cmd.Parameters.AddWithValue("@manhanvien", manhanvien);

            db.conn.Open();
            cmd.ExecuteNonQuery();
            db.conn.Close();
        }
        
        public DataTable Timnhanvien(string manhanvien)
        {
            string sql = "SELECT * FROM  NHANVIEN WHERE manhanvien = @manhanvien";

            SqlCommand cmd = new SqlCommand(sql, db.conn);
            cmd.Parameters.AddWithValue("@manhanvien", manhanvien);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);

            return dt;
        }

        public void Suanhanvien(int manhanvien, string tennhanvien, string dienthoai, string vaitro)
        {
            string sql = "UPDATE NHANVIEN SET TenNhanVien = @tennv, DienThoai = @dt, VaiTro = @vaitro WHERE MaNhanVien = @manhanvien";

            SqlCommand cmd = new SqlCommand(sql, db.conn);

            cmd.Parameters.AddWithValue("@manhanvien", manhanvien);
            cmd.Parameters.AddWithValue("@tennv", tennhanvien);
            cmd.Parameters.AddWithValue("@dt", dienthoai);
            cmd.Parameters.AddWithValue("@vaitro", vaitro);

            db.conn.Open();
            cmd.ExecuteNonQuery();
            db.conn.Close();
        }

    }
}
