using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPOdev2._4.Sekiller
{
    public class Silindir
    {
        private Point3D m; // Merkez noktası
        private int r; // Taban yarıçapı
        private int h; // Yükseklik

        public Silindir()
        {
            M = new Point3D();
            R = 0;
            H = 0;
        }

        public Silindir(Point3D p, int r, int h)
        {
            M = p;
            R = r;
            H = h;
        }

        public int R { get => r; set => r = value; } // Taban yarıçapı
        public int H { get => h; set => h = value; } // Yükseklik
        internal Point3D M { get => m; set => m = value; } // Merkez noktası

        public void SilindirCiz(Graphics g, Pen pen, Brush brush, Silindir cylinder)
        {
            // Silindirin yüksekliği
            int h = cylinder.H;

            // Silindirin tabanının ve üstünün çizimi
            Rectangle baseCircle = new Rectangle(cylinder.M.x - cylinder.R, cylinder.M.y - cylinder.R, cylinder.R * 2, cylinder.R * 2);
            g.FillEllipse(brush, baseCircle);
            g.DrawEllipse(pen, baseCircle);

            Rectangle topCircle = new Rectangle(cylinder.M.x - cylinder.R, cylinder.M.y + h - cylinder.R * 2, cylinder.R * 2, cylinder.R * 2);
            g.FillEllipse(brush, topCircle);
            g.DrawEllipse(pen, topCircle);

            // Silindirin yan yüzeylerinin çizimi
            g.DrawLine(pen, cylinder.M.x - cylinder.R, cylinder.M.y, cylinder.M.x - cylinder.R, cylinder.M.y + h);
            g.DrawLine(pen, cylinder.M.x + cylinder.R, cylinder.M.y, cylinder.M.x + cylinder.R, cylinder.M.y + h);
        }
    }
}