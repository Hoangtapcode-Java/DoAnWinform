using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANMAYTINH.BLL
{
    class bllNHANVIEN
    {
        DAL.dalNHANVIEN dal_NV;
        frm_NHANVIEN NV;
        public bllNHANVIEN(frm_NHANVIEN fNV)
        {
            dal_NV = new DAL.dalNHANVIEN();
            NV = fNV;
        }
        public void Bll_LoadGrid()
        {
            NV.dataGridView1_NV.DataSource = dal_NV.Dal_LoadGrid();
        }
        public void Bll_Them()
        {
            dal_NV.Dal_Them(NV.txt_MaNV.Text, NV.txt_TenNV.Text, NV.dateTimePicker1_NV.Value, NV.txt_GioiTinh_NV.Text, NV.txt_DiaChiNV.Text, NV.txt_SoDienThoaiNV.Text,NV.txt_TenHinhNV.Text);
        }
        public void BLL_Xoa()
        {
            dal_NV.Dal_Xoa(NV.txt_MaNV.Text);
        }
        public void BLL_Sua()
        {
            dal_NV.Dal_Sua(NV.txt_MaNV.Text, NV.txt_TenNV.Text, NV.dateTimePicker1_NV.Value, NV.txt_GioiTinh_NV.Text, NV.txt_DiaChiNV.Text,NV.txt_SoDienThoaiNV.Text,NV.txt_TenHinhNV.Text);
        }
    }
}
