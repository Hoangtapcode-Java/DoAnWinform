using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANMAYTINH.DAL
{
    class dalKHACHHANG
    {
        LopDungChung lopchung;
        public dalKHACHHANG()
        {
            lopchung = new LopDungChung();
        }
        public DataTable Dal_LoadGrid()
        {
            string sqlKH = "select * from KHACHHANG";
            return lopchung.LoadDuLieu(sqlKH);
        }
        public void Dal_Them(string MaKH, string TenKH, DateTime NgaySinh, string GioiTinh, string DiaChi, string SDT,string TenHinh)
        {
            string sqlThem = "insert into KHACHHANG values('" + MaKH + "', N'" + TenKH +
               "',Convert(Datetime ,'" + NgaySinh + "',103), N'" + GioiTinh + "', N'" + DiaChi + "', '" + SDT + "','"+TenHinh+"')";
            lopchung.Nonquery(sqlThem);
        }
        public void Dal_Xoa(String MaKH)
        {
            string sqlXoa = "delete KHACHHANG where MaKH = '" + MaKH + "'";
            lopchung.Nonquery(sqlXoa);
        }
        public void Dal_Sua(string MaKH, string TenKH, DateTime NgaySinh, string GioiTinh, string DiaChi, string SDT,string TenHinh)
        {
            String sqlSua = "update KHACHHANG set TenKH=N'" + TenKH + "',NgaySinh='" + NgaySinh + "', GioiTinh= N'"
                + GioiTinh + "', DiaChi = N'" + DiaChi + "',TenHinh ='" + TenHinh + "' where MaKH='" + MaKH + "'";
            lopchung.Nonquery(sqlSua);
        }
        
    }
}
