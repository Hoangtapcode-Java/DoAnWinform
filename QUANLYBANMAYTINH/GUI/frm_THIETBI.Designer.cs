
namespace QUANLYBANMAYTINH
{
    partial class frm_THIETBI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cb_TenLoai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DVT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TenThietBi = new System.Windows.Forms.TextBox();
            this.txt_MaThietBi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_LoadTB = new System.Windows.Forms.Button();
            this.btn_ThoatTB = new System.Windows.Forms.Button();
            this.btn_TimTB = new System.Windows.Forms.Button();
            this.btn_SuaTB = new System.Windows.Forms.Button();
            this.btn_XoaTB = new System.Windows.Forms.Button();
            this.btn_ThemTB = new System.Windows.Forms.Button();
            this.dataGridView1_TB = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_TenHinhTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_TB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_TenLoai
            // 
            this.cb_TenLoai.FormattingEnabled = true;
            this.cb_TenLoai.Location = new System.Drawing.Point(111, 101);
            this.cb_TenLoai.Name = "cb_TenLoai";
            this.cb_TenLoai.Size = new System.Drawing.Size(121, 24);
            this.cb_TenLoai.TabIndex = 55;
            this.cb_TenLoai.SelectedIndexChanged += new System.EventHandler(this.cb_TenLoai_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "Tên Loại :";
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.Location = new System.Drawing.Point(411, 59);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.Size = new System.Drawing.Size(154, 22);
            this.txt_DonGia.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Đơn Giá :";
            // 
            // txt_SoLuong
            // 
            this.txt_SoLuong.Location = new System.Drawing.Point(411, 15);
            this.txt_SoLuong.Name = "txt_SoLuong";
            this.txt_SoLuong.Size = new System.Drawing.Size(154, 22);
            this.txt_SoLuong.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "Số Lượng :";
            // 
            // txt_DVT
            // 
            this.txt_DVT.Location = new System.Drawing.Point(411, 101);
            this.txt_DVT.Name = "txt_DVT";
            this.txt_DVT.Size = new System.Drawing.Size(154, 22);
            this.txt_DVT.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(313, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 48;
            this.label6.Text = "Đơn Vị Tính :";
            // 
            // txt_TenThietBi
            // 
            this.txt_TenThietBi.Location = new System.Drawing.Point(111, 58);
            this.txt_TenThietBi.Name = "txt_TenThietBi";
            this.txt_TenThietBi.Size = new System.Drawing.Size(154, 22);
            this.txt_TenThietBi.TabIndex = 47;
            // 
            // txt_MaThietBi
            // 
            this.txt_MaThietBi.Location = new System.Drawing.Point(111, 12);
            this.txt_MaThietBi.Name = "txt_MaThietBi";
            this.txt_MaThietBi.Size = new System.Drawing.Size(154, 22);
            this.txt_MaThietBi.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 45;
            this.label2.Text = "Tên Thiết Bị :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 44;
            this.label1.Text = "Mã Thiết Bị :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_LoadTB);
            this.panel1.Controls.Add(this.btn_ThoatTB);
            this.panel1.Controls.Add(this.btn_TimTB);
            this.panel1.Controls.Add(this.btn_SuaTB);
            this.panel1.Controls.Add(this.btn_XoaTB);
            this.panel1.Controls.Add(this.btn_ThemTB);
            this.panel1.Location = new System.Drawing.Point(12, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 85);
            this.panel1.TabIndex = 57;
            // 
            // btn_LoadTB
            // 
            this.btn_LoadTB.BackColor = System.Drawing.Color.DarkGray;
            this.btn_LoadTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadTB.Location = new System.Drawing.Point(646, 32);
            this.btn_LoadTB.Name = "btn_LoadTB";
            this.btn_LoadTB.Size = new System.Drawing.Size(87, 35);
            this.btn_LoadTB.TabIndex = 5;
            this.btn_LoadTB.Text = "LOAD";
            this.btn_LoadTB.UseVisualStyleBackColor = false;
            this.btn_LoadTB.Click += new System.EventHandler(this.btn_LoadTB_Click);
            // 
            // btn_ThoatTB
            // 
            this.btn_ThoatTB.BackColor = System.Drawing.Color.DarkGray;
            this.btn_ThoatTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThoatTB.Location = new System.Drawing.Point(521, 32);
            this.btn_ThoatTB.Name = "btn_ThoatTB";
            this.btn_ThoatTB.Size = new System.Drawing.Size(87, 35);
            this.btn_ThoatTB.TabIndex = 4;
            this.btn_ThoatTB.Text = "THOÁT";
            this.btn_ThoatTB.UseVisualStyleBackColor = false;
            this.btn_ThoatTB.Click += new System.EventHandler(this.btn_ThoatTB_Click);
            // 
            // btn_TimTB
            // 
            this.btn_TimTB.BackColor = System.Drawing.Color.DarkGray;
            this.btn_TimTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimTB.Location = new System.Drawing.Point(388, 32);
            this.btn_TimTB.Name = "btn_TimTB";
            this.btn_TimTB.Size = new System.Drawing.Size(87, 35);
            this.btn_TimTB.TabIndex = 3;
            this.btn_TimTB.Text = "TÌM";
            this.btn_TimTB.UseVisualStyleBackColor = false;
            this.btn_TimTB.Click += new System.EventHandler(this.btn_TimTB_Click);
            // 
            // btn_SuaTB
            // 
            this.btn_SuaTB.BackColor = System.Drawing.Color.DarkGray;
            this.btn_SuaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuaTB.Location = new System.Drawing.Point(259, 32);
            this.btn_SuaTB.Name = "btn_SuaTB";
            this.btn_SuaTB.Size = new System.Drawing.Size(87, 35);
            this.btn_SuaTB.TabIndex = 2;
            this.btn_SuaTB.Text = "SỬA";
            this.btn_SuaTB.UseVisualStyleBackColor = false;
            this.btn_SuaTB.Click += new System.EventHandler(this.btn_SuaTB_Click);
            // 
            // btn_XoaTB
            // 
            this.btn_XoaTB.BackColor = System.Drawing.Color.DarkGray;
            this.btn_XoaTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaTB.Location = new System.Drawing.Point(138, 32);
            this.btn_XoaTB.Name = "btn_XoaTB";
            this.btn_XoaTB.Size = new System.Drawing.Size(87, 35);
            this.btn_XoaTB.TabIndex = 1;
            this.btn_XoaTB.Text = "XÓA";
            this.btn_XoaTB.UseVisualStyleBackColor = false;
            this.btn_XoaTB.Click += new System.EventHandler(this.btn_XoaTB_Click);
            // 
            // btn_ThemTB
            // 
            this.btn_ThemTB.BackColor = System.Drawing.Color.DarkGray;
            this.btn_ThemTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTB.Location = new System.Drawing.Point(20, 32);
            this.btn_ThemTB.Name = "btn_ThemTB";
            this.btn_ThemTB.Size = new System.Drawing.Size(87, 35);
            this.btn_ThemTB.TabIndex = 0;
            this.btn_ThemTB.Text = "THÊM";
            this.btn_ThemTB.UseVisualStyleBackColor = false;
            this.btn_ThemTB.Click += new System.EventHandler(this.btn_ThemTB_Click);
            // 
            // dataGridView1_TB
            // 
            this.dataGridView1_TB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_TB.Location = new System.Drawing.Point(17, 278);
            this.dataGridView1_TB.Name = "dataGridView1_TB";
            this.dataGridView1_TB.RowHeadersWidth = 51;
            this.dataGridView1_TB.RowTemplate.Height = 24;
            this.dataGridView1_TB.Size = new System.Drawing.Size(1000, 150);
            this.dataGridView1_TB.TabIndex = 56;
            this.dataGridView1_TB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(815, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txt_TenHinhTB
            // 
            this.txt_TenHinhTB.Location = new System.Drawing.Point(866, 219);
            this.txt_TenHinhTB.Name = "txt_TenHinhTB";
            this.txt_TenHinhTB.Size = new System.Drawing.Size(100, 22);
            this.txt_TenHinhTB.TabIndex = 59;
            this.txt_TenHinhTB.Text = ".png.jpg";
            // 
            // frm_THIETBI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 644);
            this.Controls.Add(this.txt_TenHinhTB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1_TB);
            this.Controls.Add(this.cb_TenLoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_SoLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_DVT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_TenThietBi);
            this.Controls.Add(this.txt_MaThietBi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_THIETBI";
            this.Text = "frm_THIETBI";
            this.Load += new System.EventHandler(this.frm_THIETBI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_TB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cb_TenLoai;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_DonGia;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_SoLuong;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_DVT;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_TenThietBi;
        public System.Windows.Forms.TextBox txt_MaThietBi;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_LoadTB;
        public System.Windows.Forms.Button btn_ThoatTB;
        public System.Windows.Forms.Button btn_TimTB;
        public System.Windows.Forms.Button btn_SuaTB;
        public System.Windows.Forms.Button btn_XoaTB;
        public System.Windows.Forms.Button btn_ThemTB;
        public System.Windows.Forms.DataGridView dataGridView1_TB;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txt_TenHinhTB;
    }
}