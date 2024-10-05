
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANMAYTINH.DAL
{
    class dalDANGNHAP
    {
        LopDungChung lopchung;
        public dalDANGNHAP()
        {
            lopchung = new LopDungChung();
        }
        public int Dal_DangNhap(string TenDN, string MatKhau)
        {
            string sqlDN = "select count (*) from TAIKHOAN where TenDN='" + TenDN + "' and MatKhau='" + MatKhau + "'";
            return (int)lopchung.Scalar(sqlDN);
        }
    }
}
