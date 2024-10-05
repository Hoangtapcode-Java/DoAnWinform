using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYBANMAYTINH.BLL
{
    class bllDANGNHAP
    {
        DAL.dalDANGNHAP dal_DN;
        frm_DANGNHAP DN;
        public bllDANGNHAP(frm_DANGNHAP fDN)
        {
            dal_DN = new DAL.dalDANGNHAP();
            DN = fDN;
            Captcha();
        }
        public void Bll_DangNhap()
        {
            int kq = dal_DN.Dal_DangNhap(DN.txt_TenDN.Text, DN.txt_MK.Text);
            if (kq >= 1)
            {
                if (DN.txt_captcha.Text == captcha.ToString())
                {
                    frm_MAIN mt = new frm_MAIN();
                    mt.Show();
                }
                else MessageBox.Show("Nhap sai Captcha ");
            }
            else MessageBox.Show("Nhap sai ten DN hoac MK ");
            Captcha();

        }
        string captcha = "";
        string value;
        private void Captcha()
        {
            ////    Cách 1
            Random r1 = new Random();
            captcha = RandomString(5); // chữ
            //captcha = r1.Next(999,100000).ToString();//r1.Next(999, 10000); //số
            var image = new Bitmap(this.DN.pictureBox.Width, this.DN.pictureBox.Height);
            var font = new Font("Lucida Handwriting", 25, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.DrawString(captcha.ToString(), font, Brushes.Green, new Point(0, 5));
            int count = 0;
            // vẽ đường gạch ngang
            while (count < 20)
            {
                graphics.DrawLine(new Pen(Color.Red), r1.Next(0, image.Width), r1.Next(0, image.Height), r1.Next(0, image.Width), r1.Next(0, image.Height));
                count++;
            }
            this.DN.pictureBox.Image = image;

            ////    Cách 2
            //value = RandomString(5); // get a random value between any range
            //var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height); // Get a bitmap
            //var font = new Font("LucidaHandwriting", 25, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel); // Get a font
            //var graphics = Graphics.FromImage(image); // Get a graphics with the bitmap image
            //graphics.DrawString(value.ToString(), font, Brushes.Red, new PointF(0, 0)); // Add the value in the graphics
            //Pen p = new Pen(Brushes.Orange, 3.5f); // get pen width
            //graphics.DrawLine(p, new PointF(0, this.pictureBox1.Height), new Point(this.pictureBox1.Width, 0)); // draw a diagonal line
            //graphics.DrawLine(p, new PointF(0, 0), new Point(this.pictureBox1.Width, this.pictureBox1.Height)); // draw another diagonal line
            //p.Dispose(); // dispose the pen to avoid memory leak
            //graphics.SmoothingMode = SmoothingMode.AntiAlias; // Smoothing the pixel
            //graphics.TextRenderingHint = TextRenderingHint.AntiAlias; // Smoothing the text rendering because stem width may differ
            //this.pictureBox1.Image = image; // load the image in the picturebox
        }
        public string RandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}
