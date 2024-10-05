using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANMAYTINH
{
    public partial class frm_THIETBI : Form
    {
        public frm_THIETBI()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bll_TB = new BLL.bllTHIETBI(this);
        }
        LopDungChung lopchung;
        BLL.bllTHIETBI bll_TB;
        private void frm_THIETBI_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadGrid();
            
        }
        public void LoadGrid()
        {

            bll_TB.Bll_LoadGrid();
        }
        public void LoadCombo()
        {

            bll_TB.Bll_LoadComBo();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";
        private void btn_ThemTB_Click(object sender, EventArgs e)
        {
            bll_TB.Bll_Them();
            pictureBox1.Image.Save(duongdan + txt_TenHinhTB.Text);
            LoadGrid();
        }

        private void btn_XoaTB_Click(object sender, EventArgs e)
        {
            bll_TB.BLL_Xoa();
            File.Delete(duongdan + txt_TenHinhTB.Text);
            LoadGrid();
        }

        private void btn_SuaTB_Click(object sender, EventArgs e)
        {

            bll_TB.BLL_Sua();
            pictureBox1.Image.Save(duongdan + txt_TenHinhTB.Text);
            LoadGrid();
        }

        private void btn_TimTB_Click(object sender, EventArgs e)
        {
            string content = Interaction.InputBox("Nhap vao ma  hoac ten");
            string sqlLoad = "select * from THIETBI where MaTB like '%" + content + "%' or TenTB like N'%" + content + "%'";
            dataGridView1_TB.DataSource = lopchung.LoadDuLieu(sqlLoad);
        }

        private void btn_ThoatTB_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_LoadTB_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
        int tim = 0;
        private void cb_TenLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tim == 0)
            {
                string sqlLoad = "select * from THIETBI where MaLoai ='" + cb_TenLoai.SelectedValue.ToString() + "'";
                dataGridView1_TB.DataSource = lopchung.LoadDuLieu(sqlLoad);
            }
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaThietBi.Text = dataGridView1_TB.CurrentRow.Cells["MaTB"].Value.ToString();
            txt_TenThietBi.Text = dataGridView1_TB.CurrentRow.Cells[1].Value.ToString();
            txt_SoLuong.Text = dataGridView1_TB.CurrentRow.Cells[2].Value.ToString();
            txt_DonGia.Text = dataGridView1_TB.CurrentRow.Cells[3].Value.ToString();
            txt_DVT.Text = dataGridView1_TB.CurrentRow.Cells[4].Value.ToString();
            tim = 1;
            cb_TenLoai.SelectedValue = dataGridView1_TB.CurrentRow.Cells[5].Value.ToString();
            tim = 0;
            txt_TenHinhTB.Text = dataGridView1_TB.CurrentRow.Cells[6].Value.ToString();
            pictureBox1.ImageLocation = (duongdan + txt_TenHinhTB.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Hay chon hinh anh";
            OFD.Filter = "Tat ca duoi hinh |*.*|PNG|*.png|*.JPG|*.jpg|JPEG|*.jpeg";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(OFD.FileName);
            }
        }
    }
}
