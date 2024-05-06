using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NDPOdev2._4.Sekiller;

namespace NDPOdev2._4
{
    public partial class Cizdirme : Form
    {
        Point2D nokta1 = new Point2D();
        Point2D nokta2 = new Point2D();
        Point2D nokta3 = new Point2D();
        Point2D nokta4 = new Point2D();
        Kure kure = new Kure();
        Dikdortgen dikdortgen = new Dikdortgen();
        Rectangle r;
        public Cizdirme()
        {
            InitializeComponent();
        }

        private void btnNokta_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(400, 400);
            form.Text = "Nokta";

            form.Paint += (object sender, PaintEventArgs e) =>
            {
                e.Graphics.FillEllipse(Brushes.Black, r);
            };
            form.Load += (object sender, EventArgs e) =>
            {
                nokta1.x = 100;
                nokta1.y = 100;
                r = new Rectangle(nokta1.x, nokta1.y, 15, 15);
            };

            form.ShowDialog();
        }

        private void btnDikdortgen_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(400, 400);
            form.Text = "Dikdörtgen";

            form.Paint += (object sender, PaintEventArgs e) =>
            {
                e.Graphics.DrawRectangle(Pens.Black, r);
            };
            form.Load += (object sender, EventArgs e) =>
            {
                nokta1.x = 100;
                nokta1.y = 100;
                r = new Rectangle(nokta1.x, nokta1.y, 150, 75);
            };

            form.ShowDialog();
        }

        private void btnCember_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(400, 400);
            form.Text = "Çember";

            form.Paint += (s, args) =>
            {
                Graphics g = args.Graphics;

                int merkezX = form.Width / 2;
                int merkezY = form.Height / 2;
                int r = 100; 

                g.DrawEllipse(Pens.Red, merkezX - r, merkezY - r, 2 * r, 2 * r);
            };

            form.ShowDialog();
        }

        private void btnKure_Click(object sender, EventArgs e)
        {
            // Yeni form oluştur
            Form form = new Form();
            form.Size = new Size(400, 400);
            form.Text = "Küre";

            form.Paint += (object sender, PaintEventArgs e) =>
            {
                Color color = Color.Black;
                GraphicsPath gPath = new GraphicsPath();            
                Rectangle rect = new Rectangle(kure.M.x - kure.R, kure.M.y - kure.R, kure.R * 2, kure.R * 2);   //Dikdörtgen oluşturur.
                gPath.AddEllipse(rect);                           
                PathGradientBrush pathGradientBrush = new PathGradientBrush(gPath);
                pathGradientBrush.CenterPoint = new PointF(kure.M.x, kure.M.y);
                pathGradientBrush.CenterColor = color;
                pathGradientBrush.SurroundColors = new Color[] { Color.White };

                e.Graphics.FillPath(pathGradientBrush, gPath);
                gPath.Dispose();
            };
            form.Load += (object sender, EventArgs e) =>
            {
                kure.M.x = 200;
                kure.M.y = 200;
                kure.R = 100;
            };

            form.ShowDialog();
        }

        private void btnPrizma_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(400, 400);
            form.Text = "Dikdörtgen Prizma";

            form.Paint += (object sender, PaintEventArgs e) =>
            {
                Graphics graphics = e.Graphics;

                float en = 150;
                float boy = 100;
                float derinlik = 75;

                nokta1.x = 50;
                nokta1.y = 50;

                GraphicsPath path = new GraphicsPath();
                path.AddPolygon(new PointF[] {      
                new PointF(nokta1.x, nokta1.y),
                new PointF(nokta1.x + en, nokta1.y),
                new PointF(nokta1.x + en + derinlik, nokta1.y + derinlik),
                new PointF(nokta1.x + derinlik, nokta1.y + derinlik)});
                path.CloseFigure();                 
                path.AddPolygon(new PointF[] {
                new PointF(nokta1.x, nokta1.y),
                new PointF(nokta1.x + derinlik, nokta1.y + derinlik),
                new PointF(nokta1.x + derinlik, nokta1.y + boy + derinlik),
                new PointF(nokta1.x, nokta1.y + boy) });
                path.CloseFigure();
                path.AddPolygon(new PointF[] {
                new PointF(nokta1.x + derinlik, nokta1.y + boy + derinlik),
                new PointF(nokta1.x + en + derinlik, nokta1.y + boy + derinlik),
                new PointF(nokta1.x + en, nokta1.y + boy),
                new PointF(nokta1.x, nokta1.y + boy)});
                path.CloseFigure();
                path.AddPolygon(new PointF[] {
                new PointF(nokta1.x + en, nokta1.y),
                new PointF(nokta1.x + en + derinlik, nokta1.y + derinlik),
                new PointF(nokta1.x + en + derinlik, nokta1.y + boy + derinlik),
                new PointF(nokta1.x + en, nokta1.y + boy)});
                path.CloseFigure();

                SolidBrush brush = new SolidBrush(Color.Black);
                graphics.FillPath(brush, path);

                graphics.DrawPath(Pens.Black, path);

            };
            form.Load += (object sender, EventArgs e) =>
            {

            };

            form.ShowDialog();
        }

        private void btnSilindir_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(400, 400);
            form.Text = "Silindir";

            form.Paint += (object sender, PaintEventArgs e) =>
            {

                Graphics graphics = e.Graphics;

                float centerX = 200; // Silindirin merkezinin X koordinatı
                float centerY = 150; // Silindirin merkezinin Y koordinatı
                float radius = 50; // Silindirin tabanının yarıçapı
                float height = 100; // Silindirin yüksekliği

                // Silindirin tabanını çiz
                graphics.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, radius * 2, radius * 2);

                // Silindirin üst tabanını çiz
                graphics.DrawEllipse(Pens.Black, centerX - radius, centerY - radius - height, radius * 2, radius * 2);

                // Silindirin yan yüzeyini çiz
                graphics.DrawLine(Pens.Black, centerX - radius, centerY - radius, centerX - radius, centerY - radius - height);
                graphics.DrawLine(Pens.Black, centerX + radius, centerY - radius, centerX + radius, centerY - radius - height);
                graphics.DrawLine(Pens.Black, centerX - radius, centerY + radius, centerX - radius, centerY + radius - height);
                graphics.DrawLine(Pens.Black, centerX + radius, centerY + radius, centerX + radius, centerY + radius - height);
            };
            form.ShowDialog();
        }

        private void btnYuzey_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(400, 400);
            form.Text = "Yüzey";

            form.Paint += (object sender, PaintEventArgs e) =>
            {

                PointF point1 = new PointF(dikdortgen.M.x, dikdortgen.M.y);
                PointF point2 = new PointF(dikdortgen.M.x + dikdortgen.En, dikdortgen.M.y);
                PointF point3 = new PointF(200, 50);
                PointF point4 = new PointF(300, 50);
                PointF[] points = { point1, point3, point4, point2 };

                Pen pen = new Pen(Color.DarkBlue); 

                e.Graphics.DrawRectangle(Pens.Black, r);         
                e.Graphics.DrawPolygon(pen, points);                 
            };
            form.Load += (object sender, EventArgs e) =>
            {
                dikdortgen.M.x = 100;
                dikdortgen.M.y = 100;
                dikdortgen.En = 100;
                dikdortgen.Boy = 20;
                r = new Rectangle(dikdortgen.M.x, dikdortgen.M.y, dikdortgen.En, dikdortgen.Boy);
            };
            form.ShowDialog();
        }

        private void btnDortgen_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(400, 400);
            form.Text = "Dörtgen";

            form.Paint += (object sender, PaintEventArgs e) =>
            {
                e.Graphics.DrawLine(Pens.Black, nokta1.x, nokta1.y, nokta2.x, nokta2.y);
                e.Graphics.DrawLine(Pens.Black, nokta2.x, nokta2.y, nokta3.x, nokta3.y);
                e.Graphics.DrawLine(Pens.Black, nokta3.x, nokta3.y, nokta4.x, nokta4.y);
                e.Graphics.DrawLine(Pens.Black, nokta4.x, nokta4.y, nokta1.x, nokta1.y);
            };
            form.Load += (object sender, EventArgs e) =>
            {
                nokta1.x = 243; nokta1.y = 178;
                nokta2.x = 346; nokta2.y = 252;
                nokta3.x = 109; nokta3.y = 276;
                nokta4.x = 120; nokta4.y = 190;
            };
            form.ShowDialog();
        }
    }
}
