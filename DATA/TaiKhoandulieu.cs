using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class TaiKhoandulieu
    {   
           DBConnect db = new DBConnect();
        public DataTable Login(string user, string pass)
        {
            string sql = "SELECT Quyen FROM TAIKHOAN WHERE  TenDangNhap=@user AND MatKhau=@pass";

            SqlCommand cmd = new SqlCommand(sql, db.conn);//chuẩn bị chạy câu lệnh sql trong datbase

            cmd.Parameters.AddWithValue("@user", user);//gán giá trị mình nhập với đối tượng trong bảng data
            cmd.Parameters.AddWithValue("@pass", pass);

            SqlDataAdapter da = new SqlDataAdapter(cmd);//lấy dự liệu từ database đưa vào datatable
            DataTable dt = new DataTable();//tạo bản dữ liệu trong ram
            da.Fill(dt);//đổ dữ liệu và bảng

            return dt;
        }
    }
}
