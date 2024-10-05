using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANMAYTINH
{
    public partial class frm_DANGNHAP : Form
    {
        public frm_DANGNHAP()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bll_DN = new BLL.bllDANGNHAP(this);
            
        }
        LopDungChung lopchung;
        BLL.bllDANGNHAP bll_DN;

        private void btn_ThoatDN_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
            bll_DN.Bll_DangNhap();
        }

        private void frm_DANGNHAP_Load(object sender, EventArgs e)
        {

        }
    }
}
