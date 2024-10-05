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
    public partial class frm_NHANVIEN : Form
    {
        public frm_NHANVIEN()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bll_NV = new BLL.bllNHANVIEN(this);
        }
        LopDungChung lopchung;
        BLL.bllNHANVIEN bll_NV;
        private void frm_NHANVIEN_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            bll_NV.Bll_LoadGrid();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";
        private void btn_ThemNV_Click(object sender, EventArgs e)
        {
            bll_NV.Bll_Them();
            pictureBox1.Image.Save(duongdan + txt_TenHinhNV.Text);
            LoadGrid();
        }

        private void btn_XoaNV_Click(object sender, EventArgs e)
        {
            bll_NV.BLL_Xoa();
            File.Delete(duongdan + txt_TenHinhNV.Text);
            LoadGrid();
        }

        private void btn_SuaNV_Click(object sender, EventArgs e)
        {

            bll_NV.BLL_Sua();
            pictureBox1.Image.Save(duongdan + txt_TenHinhNV.Text);
            LoadGrid();
        }

        private void btn_TimNV_Click(object sender, EventArgs e)
        {
            string content = Interaction.InputBox("Nhap vao ma  hoac ten");
            string sqlLoad = "select * from NHANVIEN where MaNV like '%" + content + "%' or TenNV like N'%" + content + "%'";
            dataGridView1_NV.DataSource = lopchung.LoadDuLieu(sqlLoad);
        }

        private void btn_ThoatNV_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_LoadNV_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dataGridView1_NV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaNV.Text = dataGridView1_NV.CurrentRow.Cells["MaNV"].Value.ToString();
            txt_TenNV.Text = dataGridView1_NV.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1_NV.Text = dataGridView1_NV.CurrentRow.Cells[2].Value.ToString();
            txt_GioiTinh_NV.Text = dataGridView1_NV.CurrentRow.Cells[3].Value.ToString();
            txt_DiaChiNV.Text = dataGridView1_NV.CurrentRow.Cells[4].Value.ToString();
            txt_SoDienThoaiNV.Text = dataGridView1_NV.CurrentRow.Cells[5].Value.ToString();
            txt_TenHinhNV.Text = dataGridView1_NV.CurrentRow.Cells[6].Value.ToString();
            pictureBox1.ImageLocation = (duongdan + txt_TenHinhNV.Text);
        }

        

        private void pictureBox1_Click_1(object sender, EventArgs e)
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
