using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPOdev2._4.Sekiller
{
    public class Cember
    {
        Point2D m; int r;
        public Cember()
        {
            M = new Point2D();// merkez noktası
            R = 0;
        }
        public Cember(Point2D p, int r)

        { M = p; R = r; }

        public int R { get => r; set => r = value; }
        public Point2D M { get => m; set => m = value; }

    }
}