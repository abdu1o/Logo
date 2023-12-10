using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadLogo();
        }

        private void LoadLogo()
        {
            Bitmap logo = new Bitmap(200, 200);

            using (Graphics g = Graphics.FromImage(logo))
            {
                Brush borderBrush = new SolidBrush(Color.Black);
                Pen borderPen = new Pen(borderBrush, 12);

                g.DrawRectangle(borderPen, 0, 0, logo.Width - 1, logo.Height - 1);

                Brush triangleBrush = new SolidBrush(Color.Black);

                PointF[] trianglePoints = new PointF[]
                {
                    new PointF(logo.Width / 2, 10),
                    new PointF(10, logo.Height - 10),
                    new PointF(logo.Width - 10, logo.Height - 10)
                };

                g.FillPolygon(triangleBrush, trianglePoints);

                Brush textBrush = new SolidBrush(Color.White);
                Font textFont = new Font("Arial", 16, FontStyle.Bold);

                string companyName = "SHO?";
                SizeF textSize = g.MeasureString(companyName, textFont);
                float x = (logo.Width - textSize.Width) / 2;
                float y = (logo.Height - textSize.Height) / 2;
                g.DrawString(companyName, textFont, textBrush, x, y);
            }

            int pictureBoxX = (pictureBox1.Width - logo.Width) / 2;
            int pictureBoxY = (pictureBox1.Height - logo.Height) / 2;

            pictureBox1.Image = logo;
            pictureBox1.Location = new Point(pictureBoxX, pictureBoxY);
        }
    }
}
