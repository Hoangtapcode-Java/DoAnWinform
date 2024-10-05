using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANMAYTINH.BLL
{
    class bllKHACHHANG
    {
        DAL.dalKHACHHANG dal_KH;
        frm_KHACHHANG KH;
        public bllKHACHHANG(frm_KHACHHANG fKH)
        {
            dal_KH = new DAL.dalKHACHHANG();
            KH = fKH;
        }
        public void Bll_LoadGrid()
        {
            KH.dataGridView1_KH.DataSource = dal_KH.Dal_LoadGrid();
        }
        public void Bll_Them()
        {
            dal_KH.Dal_Them(KH.txt_MaKH.Text, KH.txt_TenKH.Text, KH.dateTimePicker1_KH.Value, KH.txt_GioiTinhKH.Text, KH.txt_DiaChiKH.Text, KH.txt_SoDienThoaiKH.Text, KH.txt_TenHinhKH.Text);
        }
        public void BLL_Xoa()
        {
            dal_KH.Dal_Xoa(KH.txt_MaKH.Text);
        }
        public void BLL_Sua()
        {
            dal_KH.Dal_Sua(KH.txt_MaKH.Text, KH.txt_TenKH.Text, KH.dateTimePicker1_KH.Value, KH.txt_GioiTinhKH.Text, KH.txt_DiaChiKH.Text, KH.txt_SoDienThoaiKH.Text, KH.txt_TenHinhKH.Text);
        }
        
    }
}
