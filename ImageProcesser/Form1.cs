using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageProcesser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image imgOriginal;
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "图片文件|*.jpg";
            ofd.InitialDirectory = @"C:\Users\Allez\Documents\Visual Studio 2013\Projects\图像处理";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imgOriginal = Image.FromFile(ofd.FileName);
                picOriginal.BackgroundImage = imgOriginal;
            }
        }

        private void btnGray_Click(object sender, EventArgs e)
        {
            if (imgOriginal == null)
                return;
            Bitmap bmp = new Bitmap(imgOriginal);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    int x = (color.R + color.G + color.B) / 3;
                    bmp.SetPixel(i, j, Color.FromArgb(x, x, x));
                }
            }
            picAfter.BackgroundImage = bmp;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            if (imgOriginal == null)
                return;
            Bitmap bmp = new Bitmap(imgOriginal);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color color = bmp.GetPixel(i, j);
                    bmp.SetPixel(i, j, Color.FromArgb(255-color.R, 255-color.G, 255-color.B));
                }
            }
            picAfter.BackgroundImage = bmp;
        }

        private void btnRain_Click(object sender, EventArgs e)
        {
            if (imgOriginal == null)
                return;
            Bitmap bmp = new Bitmap(imgOriginal);
            Random r = new Random();
            int degree = 10;
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    int dx = i + r.Next() % degree;
                    int dy = j + r.Next() % degree;
                    if (dx > bmp.Width - 1)
                    {
                        dx = bmp.Width - 1;
                    }
                    if (dy > bmp.Height - 1)
                    {
                        dy = bmp.Height - 1;
                    }
                    Color color = bmp.GetPixel(dx, dy);
                    bmp.SetPixel(i, j, color);
                }
            }
            picAfter.BackgroundImage = bmp;
        }

        private void btnRelief_Click(object sender, EventArgs e)
        {
            if (imgOriginal == null)
                return;
            Bitmap bmp = new Bitmap(imgOriginal);
            for (int i = 0; i < bmp.Width-1; i++)
            {
                for (int j = 0; j < bmp.Height-1; j++)
                {
                    Color color1 = bmp.GetPixel(i, j);
                    Color color2 = bmp.GetPixel(i + 1, j + 1);
                    int r = Math.Abs(color1.R - color2.R);
                    int g = Math.Abs(color1.G - color2.G);
                    int b = Math.Abs(color1.B - color2.B);
                    if (r > 255) r = 255;
                    if (g > 255) g = 255;
                    if (b > 255) b = 255;
                    bmp.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            picAfter.BackgroundImage = bmp;
        }
    }
}
