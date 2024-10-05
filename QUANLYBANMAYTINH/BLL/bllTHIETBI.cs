using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYBANMAYTINH.BLL
{
    class bllTHIETBI
    {
        DAL.dalTHIETBI dal_TB;
        frm_THIETBI TB;
        public bllTHIETBI(frm_THIETBI fTB)
        {
            dal_TB = new DAL.dalTHIETBI();
            TB = fTB;
        }
        public void Bll_LoadGrid()
        {
            TB.dataGridView1_TB.DataSource = dal_TB.Dal_LoadGrid();
        }
        public void Bll_LoadComBo()
        {
            TB.cb_TenLoai.DataSource = dal_TB.Dal_LoadComBo();
            TB.cb_TenLoai.DisplayMember = "TenLoai";
            TB.cb_TenLoai.ValueMember = "MaLoai";
        }
        public void Bll_Them()
        {
            dal_TB.Dal_Them(TB.txt_MaThietBi.Text, TB.txt_TenThietBi.Text, TB.txt_SoLuong.Text, TB.txt_DonGia.Text, TB.txt_DVT.Text, TB.cb_TenLoai.SelectedValue.ToString(), TB.txt_TenHinhTB.Text);
        }
        public void BLL_Xoa()
        {
            dal_TB.Dal_Xoa(TB.txt_MaThietBi.Text);
        }
        public void BLL_Sua()
        {
            dal_TB.Dal_Sua(TB.txt_MaThietBi.Text, TB.txt_TenThietBi.Text, TB.txt_SoLuong.Text, TB.txt_DonGia.Text, TB.txt_DVT.Text, TB.cb_TenLoai.SelectedValue.ToString(), TB.txt_TenHinhTB.Text);
        }
    }
}
