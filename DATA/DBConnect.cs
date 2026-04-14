using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DATA
{
    public class DBConnect
    {
        public SqlConnection conn = new SqlConnection(
            @"Server=LAPTOP-JRFGPP05;Database=CuaHangz;Integrated Security=True;"
        );

        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        public void Close()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();//tạo bảng dữ liệu tạm trong Ram

            Open();//mở kết nối

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);//tạo adapter (SqlDataAdapter đây là tên công cụ)
            da.Fill(dt);//đổ dữ liệu vào bảng

            Close();//đóng kết nối

            return dt;//trả về dữ liệu
        }
    }
}
