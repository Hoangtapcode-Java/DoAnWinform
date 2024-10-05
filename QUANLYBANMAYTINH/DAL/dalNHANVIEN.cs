using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANMAYTINH.DAL
{
    class dalNHANVIEN
    {
        LopDungChung lopchung;
        public dalNHANVIEN()
        {
            lopchung = new LopDungChung();
        }
        public DataTable Dal_LoadGrid()
        {
            string sqlNV = "select * from NHANVIEN";
            return lopchung.LoadDuLieu(sqlNV);
        }
        public void Dal_Them(string MaNV, string TenNV, DateTime NgaySinh, string GioiTinh, string DiaChi, string SDT,string TenHinh)
        {
            string sqlThem = "insert into NHANVIEN values('" + MaNV + "', N'" + TenNV +
               "',Convert(Datetime ,'" + NgaySinh + "',103),N'" + GioiTinh 
               + "',N'" + DiaChi + "', '" + SDT + "','"+TenHinh+"')";
            lopchung.Nonquery(sqlThem);
        }
        public void Dal_Xoa(String MaNV)
        {
            string sqlXoa = "delete NHANVIEN where MaNV = '" + MaNV + "'";
            lopchung.Nonquery(sqlXoa);
        }
        public void Dal_Sua(string MaNV, string TenNV, DateTime NgaySinh, string GioiTinh, string DiaChi, string SDT,string TenHinh)
        {
            string sqlSua = "update NHANVIEN set TenNV=N'" + TenNV + "',NgaySinh= Convert(DateTime, '" + NgaySinh + "',103), GioiTinh=N'"
                + GioiTinh + "', DiaChi = N'" + DiaChi + "', SDT = '"+SDT+"',TenHinh ='"+TenHinh+"' where MaNV='" + MaNV + "'";
            lopchung.Nonquery(sqlSua);
        }
    }

}
