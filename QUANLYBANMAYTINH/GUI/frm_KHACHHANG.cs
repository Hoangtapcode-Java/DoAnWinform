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
    public partial class frm_KHACHHANG : Form
    {
        public frm_KHACHHANG()
        {
            InitializeComponent();
            lopchung = new LopDungChung();
            bll_KH = new BLL.bllKHACHHANG(this);
        }
        
        LopDungChung lopchung;
        BLL.bllKHACHHANG bll_KH;
        private void frm_KHACHHANG_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            bll_KH.Bll_LoadGrid();
        }
        string duongdan = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\HINHANH\\";
        private void btn_ThemKH_Click(object sender, EventArgs e)
        {
            bll_KH.Bll_Them();
            pictureBox1.Image.Save(duongdan + txt_TenHinhKH.Text);
            LoadGrid();
        }

        private void btn_XoaKH_Click(object sender, EventArgs e)
        {
            bll_KH.BLL_Xoa();
            File.Delete(duongdan + txt_TenHinhKH.Text);
            LoadGrid();
        }

        private void btn_SuaKH_Click(object sender, EventArgs e)
        {
            bll_KH.BLL_Sua();
            pictureBox1.Image.Save(duongdan + txt_TenHinhKH.Text);
            LoadGrid();
        }

        private void btn_TimKH_Click(object sender, EventArgs e)
        {
            string content = Interaction.InputBox("Nhap vao ma  hoac ten");
            string sqlLoad = "select * from KHACHHANG where MaKH like '%" + content + "%' or TenKH like N'%" + content + "%'";
            dataGridView1_KH.DataSource = lopchung.LoadDuLieu(sqlLoad);
        }

        private void btn_ThoatKH_Click(object sender, EventArgs e)
        {
            DialogResult DR = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DR == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_LoadKH_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void dataGridView1_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaKH.Text = dataGridView1_KH.CurrentRow.Cells["MaKH"].Value.ToString();
            txt_TenKH.Text = dataGridView1_KH.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1_KH.Text = dataGridView1_KH.CurrentRow.Cells[2].Value.ToString();
            txt_GioiTinhKH.Text = dataGridView1_KH.CurrentRow.Cells[3].Value.ToString();
            txt_DiaChiKH.Text = dataGridView1_KH.CurrentRow.Cells[4].Value.ToString();
            txt_SoDienThoaiKH.Text = dataGridView1_KH.CurrentRow.Cells[5].Value.ToString();
            txt_TenHinhKH.Text = dataGridView1_KH.CurrentRow.Cells[6].Value.ToString();
            pictureBox1.ImageLocation = (duongdan + txt_TenHinhKH.Text);
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
