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
    public partial class frm_MAIN : Form
    {
        public frm_MAIN()
        {
            InitializeComponent();
            
        }
        
        private void quanlythietbiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_THIETBI"] == null)
            {
                frm_THIETBI qltb = new frm_THIETBI();
                qltb.MdiParent = this;
                qltb.Show();
            }
            else Application.OpenForms["frm_THIETBI"].Activate();
        }

        private void quanlykhachhangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_KHACHHANG"] == null)
            {
                frm_KHACHHANG qlkh = new frm_KHACHHANG();
                qlkh.MdiParent = this;
                qlkh.Show();
            }
            else Application.OpenForms["frm_KHACHHANG"].Activate();
        }

        private void quanlynhavienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NHANVIEN"] == null)
            {
                frm_NHANVIEN qlnv = new frm_NHANVIEN();
                qlnv.MdiParent = this;
                qlnv.Show();
            }
            else Application.OpenForms["frm_NHANVIEN"].Activate();
        }
    }
}
