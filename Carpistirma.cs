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
    public partial class Carpistirma : Form
    {
        Dikdortgen dikdortgen1 = new Dikdortgen();
        Dikdortgen dikdortgen2 = new Dikdortgen();
        Rectangle a;
        Rectangle b;
        Rectangle merkez1;
        Rectangle merkez2;
        Kure kure1 = new Kure();
        Kure kure2 = new Kure();
        Silindir silindir1 = new Silindir();
        Silindir silindir2 = new Silindir();
        Cember cember1 = new Cember();
        Cember cember2 = new Cember();
        public Carpistirma()
        {
            InitializeComponent();
        }

        private void btnDikdortgenDikdortgen_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(500, 500);
            form.Text = "Dikdörtgen-Dikdörtgen";


            form.Load += (object sender, EventArgs e) =>
            {
                dikdortgen1.M.x = 200;
                dikdortgen1.M.y = 200;
                dikdortgen1.En = 75;
                dikdortgen1.Boy = 120;
                dikdortgen2.M.x = 300;
                dikdortgen2.M.y = 300;
                dikdortgen2.En = 100;
                dikdortgen2.Boy = 75;
                a = new Rectangle(dikdortgen1.M.x, dikdortgen1.M.y, dikdortgen1.En, dikdortgen1.Boy);
                b = new Rectangle(dikdortgen2.M.x, dikdortgen2.M.y, dikdortgen2.En, dikdortgen2.Boy);
            };

            form.Paint += (object sender, PaintEventArgs e) =>
            {
                e.Graphics.FillRectangle(Brushes.OrangeRed, a);
                e.Graphics.FillRectangle(Brushes.DarkGray, b);
            };
            form.MouseMove += (object sender, MouseEventArgs e) =>
            {
                dikdortgen2.M.x = e.X - dikdortgen2.En / 2;
                dikdortgen2.M.y = e.Y - dikdortgen2.Boy / 2;
                b = new Rectangle(dikdortgen2.M.x, dikdortgen2.M.y, dikdortgen2.En, dikdortgen2.Boy);
                CarpismaKontrol.dikdortgenDikdortgen(dikdortgen1, dikdortgen2);
                form.Invalidate();
            };
            form.Show();
        }

        private void btnKureKure_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(500, 500);
            form.Text = "Küre-Küre";


            form.Load += (object sender, EventArgs e) =>
            {
                kure1.M.x = 100;
                kure1.M.y = 100;
                kure1.R = 25;
                kure2.M.x = 300;
                kure2.M.y = 300;
                kure2.R = 50;
            };

            form.Paint += (object sender, PaintEventArgs e) =>
            {
                Color color1 = Color.Blue;

                GraphicsPath gPath1 = new GraphicsPath();

                Rectangle rect1 = new Rectangle(kure1.M.x - kure1.R, kure1.M.y - kure1.R, kure1.R * 2, kure1.R * 2);
                gPath1.AddEllipse(rect1);

                PathGradientBrush pathGradientBrush1 = new PathGradientBrush(gPath1);
                pathGradientBrush1.CenterPoint = new PointF(kure1.M.x, kure1.M.y);
                pathGradientBrush1.CenterColor = color1;
                pathGradientBrush1.SurroundColors = new Color[] { Color.Gray };

                e.Graphics.FillPath(pathGradientBrush1, gPath1);
                Color color2 = Color.Red;
                GraphicsPath gPath2 = new GraphicsPath();
                Rectangle rect2 = new Rectangle(kure2.M.x - kure2.R, kure2.M.y - kure2.R, kure2.R * 2, kure2.R * 2);
                gPath2.AddEllipse(rect2);

                PathGradientBrush pathGradientBrush2 = new PathGradientBrush(gPath2);
                pathGradientBrush2.CenterPoint = new PointF(kure2.M.x, kure2.M.y);
                pathGradientBrush2.CenterColor = color2;
                pathGradientBrush2.SurroundColors = new Color[] { Color.Gray };

                e.Graphics.FillPath(pathGradientBrush2, gPath2);
                gPath1.Dispose();
                gPath2.Dispose();
            };
            form.MouseMove += (object sender, MouseEventArgs e) =>
            {
                kure1.M.x = e.X;
                kure1.M.y = e.Y;

                kure2.M.x = 300;
                kure2.M.y = 300;

                form.Invalidate();
                CarpismaKontrol.KureKure(kure1, kure2);
                Invalidate();
            };
            form.Show();
        }

        private void btnDaireDikdortgen_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(500, 500);
            form.Text = "Cember-Dikdörtgen";


            form.Load += (object sender, EventArgs e) =>
            {
                cember1.M.x = 200;
                cember1.M.y = 200;
                cember1.R = 40;
                dikdortgen1.M.x = 100;
                dikdortgen1.M.y = 100;
                dikdortgen1.En = 50;
                dikdortgen1.Boy = 100;
                b = new Rectangle(cember1.M.x, cember1.M.y, 80, 100);
                a = new Rectangle(dikdortgen1.M.x, dikdortgen1.M.y, dikdortgen1.En, dikdortgen1.Boy);
                merkez1 = new Rectangle((cember1.M.x + 40 - 2), (cember1.M.y + 40 - 2), 4, 4);
                merkez2 = new Rectangle();
            };

            form.Paint += (object sender, PaintEventArgs e) =>
            {
                e.Graphics.FillEllipse(Brushes.DarkGreen, a);
                e.Graphics.FillRectangle(Brushes.Gold, b);
                e.Graphics.FillEllipse(Brushes.Black, merkez1);
                e.Graphics.FillEllipse(Brushes.Red, merkez2);            
            };
            form.MouseMove += (object sender, MouseEventArgs e) =>
            {
                dikdortgen1.M.x = e.X - 25;
                dikdortgen1.M.y = e.Y - 50;
                a = new Rectangle(dikdortgen1.M.x, dikdortgen1.M.y, dikdortgen1.En, dikdortgen1.Boy);
                merkez2 = new Rectangle((e.X), (e.Y), 8, 8);
                CarpismaKontrol.DaireDikdortgen(cember1, dikdortgen1);
                form.Invalidate();
            };
            form.Show();
        }

        private void btnSilindirSilindir_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(500, 500);
            form.Text = "Silindir-Silindir";


            form.Load += (object sender, EventArgs e) =>
            {
                silindir1.M.x = 150;
                silindir1.M.y = 150;
                silindir1.M.z = 150;
                silindir1.H = 200;
                silindir1.R = 50;
                silindir2.M.x = 250;
                silindir2.M.y = 250;
                silindir2.M.z = 200;
                silindir2.H = 200;
                silindir2.R = 50;
            };

            form.Paint += (object sender, PaintEventArgs e) =>
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.DarkBlue, 2);
                Brush brush = new SolidBrush(Color.Beige);

                silindir1.SilindirCiz(g, pen, brush, silindir1);

                silindir2.SilindirCiz(g, pen, brush, silindir2);
            };
            form.MouseMove += (object sender, MouseEventArgs e) =>
            {
                silindir2.M.x = e.X;
                silindir2.M.y = e.Y;
                CarpismaKontrol.SilindirSilindir(silindir1, silindir2);
                form.Invalidate();
            };
            form.Show();
        }

        private void btnDikdörtgenNokta_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(500, 500);
            form.Text = "Dikdörtgen-Nokta";


            form.Load += (object sender, EventArgs e) =>
            {
                cember1.M.x = 200;
                cember1.M.y = 200;
                cember1.R = 15;
                dikdortgen1.M.x = 100;
                dikdortgen1.M.y = 100;
                dikdortgen1.En = 50;
                dikdortgen1.Boy = 100;
                b = new Rectangle(cember1.M.x, cember1.M.y, 80, 100);
                a = new Rectangle(dikdortgen1.M.x, dikdortgen1.M.y, dikdortgen1.En, dikdortgen1.Boy);
                merkez1 = new Rectangle((cember1.M.x + 40), (cember1.M.y + 50), 4, 4);
                merkez2 = new Rectangle();
            };

            form.Paint += (object sender, PaintEventArgs e) =>
            {
                e.Graphics.FillRectangle(Brushes.BlueViolet, b);
                e.Graphics.FillEllipse(Brushes.DarkOrange, merkez2);
            };
            form.MouseMove += (object sender, MouseEventArgs e) =>
            {
                dikdortgen1.M.x = e.X - 25;
                dikdortgen1.M.y = e.Y - 50;
                a = new Rectangle(dikdortgen1.M.x, dikdortgen1.M.y, dikdortgen1.En, dikdortgen1.Boy);
                merkez2 = new Rectangle((e.X - 4), (e.Y - 4), 8, 8);
                CarpismaKontrol.DikdörtgenNokta(cember1, dikdortgen1);
                form.Invalidate();
            };
            form.Show();
        }

        private void btnKureNokta_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(500, 500);
            form.Text = "Küre-Nokta";


            form.Load += (object sender, EventArgs e) =>
            {
                kure1.M.x = 200;
                kure1.M.y = 200;
                kure1.R = 50;
                kure2.M.x = 300;
                kure2.M.y = 300;
                kure2.R = 10;
            };

            form.Paint += (object sender, PaintEventArgs e) =>
            {
                Color renk = Color.Red;

                GraphicsPath gPath1 = new GraphicsPath();

                Rectangle rect1 = new Rectangle(kure1.M.x - kure1.R, kure1.M.y - kure1.R, kure1.R * 2, kure1.R * 2);
                gPath1.AddEllipse(rect1);

                PathGradientBrush pathGradientBrush1 = new PathGradientBrush(gPath1);
                pathGradientBrush1.CenterPoint = new PointF(kure1.M.x, kure1.M.y);
                pathGradientBrush1.CenterColor = renk;
                pathGradientBrush1.SurroundColors = new Color[] { Color.White };

                e.Graphics.FillPath(pathGradientBrush1, gPath1);

                Color color2 = Color.RebeccaPurple;

                GraphicsPath gPath2 = new GraphicsPath();

                Rectangle rect2 = new Rectangle(kure2.M.x - kure2.R, kure2.M.y - kure2.R, kure2.R * 2, kure2.R * 2);
                gPath2.AddEllipse(rect2);

                PathGradientBrush pathGradientBrush2 = new PathGradientBrush(gPath2);
                pathGradientBrush2.CenterPoint = new PointF(kure2.M.x, kure2.M.y);
                pathGradientBrush2.CenterColor = color2;
                pathGradientBrush2.SurroundColors = new Color[] { Color.White };

                e.Graphics.FillPath(pathGradientBrush2, gPath2);
                gPath1.Dispose();
                gPath2.Dispose();
            };
            form.MouseMove += (object sender, MouseEventArgs e) =>
            {
                kure2.M.x = e.X - 4;
                kure2.M.y = e.Y - 4;
                CarpismaKontrol.KureNokta(kure1, kure2);
                form.Invalidate();
            };

            form.Show();
        }

        private void btnCemberNokta_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(500, 500);
            form.Text = "Cember-Nokta";


            form.Load += (object sender, EventArgs e) =>
            {
                cember1.M.x = 200;
                cember1.M.y = 200;
                cember1.R = 50;
            };
            Point nokta = Point.Empty;
            form.Paint += (object sender, PaintEventArgs e) =>
            {
                Pen pen = new Pen(Color.Red, 2); 
                e.Graphics.DrawEllipse(pen, cember1.M.x - cember1.R, cember1.M.y - cember1.R, cember1.R * 2, cember1.R * 2);

                int noktaBoyutu = 10;
                Point nokta = Cursor.Position;
                nokta = form.PointToClient(nokta); 
                e.Graphics.FillEllipse(Brushes.Blue, nokta.X - noktaBoyutu / 2, nokta.Y - noktaBoyutu / 2, noktaBoyutu, noktaBoyutu);
            };
            
            form.MouseMove += (object sender, MouseEventArgs e) =>
            {
                Point nokta = e.Location;
                CarpismaKontrol.CemberNokta(cember1, nokta);
                form.Invalidate();
            };

            form.Show();
        }

        private void btnSilindirNokta_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Size = new Size(500, 500);
            form.Text = "Silindir-Nokta";

            Silindir silindir1 = new Silindir();
            Point nokta = Point.Empty;

            form.Load += (object sender, EventArgs e) =>
            {

                silindir1.M.x = 150;
                silindir1.M.y = 150;
                silindir1.M.z = 150;
                silindir1.H = 200;
                silindir1.R = 50;

                nokta.X = 200;
                nokta.Y = 200;
            };

            form.Paint += (object sender, PaintEventArgs e) =>
            {
                Graphics g = e.Graphics;
                Pen pen = new Pen(Color.DarkBlue, 2);
                Brush brush = new SolidBrush(Color.Beige);

                silindir1.SilindirCiz(g, pen, brush, silindir1);

                int noktaBoyutu = 10;
                e.Graphics.FillEllipse(Brushes.Blue, nokta.X - noktaBoyutu / 2, nokta.Y - noktaBoyutu / 2, noktaBoyutu, noktaBoyutu);
            };

            form.MouseMove += (object sender, MouseEventArgs e) =>
            {
                nokta = e.Location;
                CarpismaKontrol.SilindirNokta(silindir1, nokta);
                form.Invalidate();
            };

            form.Show();
        }
    }
}
