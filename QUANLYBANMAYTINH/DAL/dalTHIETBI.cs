using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANMAYTINH.DAL
{
    class dalTHIETBI
    {
        LopDungChung lopchung;
        public dalTHIETBI()
        {
            lopchung = new LopDungChung();
        }
        public DataTable Dal_LoadGrid()
        {
            string sqlTB = "select * from THIETBI";
            return lopchung.LoadDuLieu(sqlTB);
        }
        public DataTable Dal_LoadComBo()
        {
            string sqlTB = "select * from LOAITHIETBI";
            return lopchung.LoadDuLieu(sqlTB);
        }
        public void Dal_Them(string MaTB, string TenTB, string SoLuong, string DonGia, string DVT,string MaLoai,string TenHinh)
        {
            string sqlThem = "insert into THIETBI values('" + MaTB + "', N'" + TenTB +
               
                "','" + SoLuong + "','" + DonGia + "', N'" + DVT + "','" + MaLoai + "','"+TenHinh+"')";
            lopchung.Nonquery(sqlThem);
        }
        public void Dal_Xoa(String MaTB)
        {
            string sqlXoa = "delete THIETBI where MaTB = '" + MaTB + "'";
            lopchung.Nonquery(sqlXoa);
        }
        public void Dal_Sua(string MaTB, string TenTB, string SoLuong, string DonGia, string DVT, string MaLoai,string TenHinh)
        {
            String sqlSua = "update THIETBI set TenTB=N'" + TenTB + "',SoLuong='" + SoLuong + "', DonGia='"
                + DonGia + "', DVT = '" + DVT + "', TenHinh = '" + TenHinh + "' where MaTB='" + MaTB + "'";
            lopchung.Nonquery(sqlSua);
        }
    }
}
