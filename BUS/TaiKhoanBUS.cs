using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DATA;

namespace BUS
{
    public class TaiKhoanBUS
    {
        TaiKhoandulieu tk = new TaiKhoandulieu();

        public DataTable LayTaiKhoanBUS(string user, string pass)
        {
            return tk.Login(user, pass);
        }
    }
}
