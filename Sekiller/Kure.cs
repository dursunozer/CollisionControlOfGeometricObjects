using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPOdev2._4.Sekiller
{
    public class Kure
    {
        Point3D m; int r;
        public Kure()
        {
            M = new Point3D();// merkez noktası
            R = 0;
        }
        public Kure(Point3D p, int r)
        { M = p; R = r; }
        public int R { get => r; set => r = value; }
        internal Point3D M { get => m; set => m = value; }
    }
}
