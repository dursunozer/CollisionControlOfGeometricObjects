using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPOdev2._4.Sekiller
{
    public class Dikdortgen
    {
        Point2D m;
        int en; int boy;
        public Dikdortgen()
        {
            M = new Point2D(); //köşe noktası
            En = 0; Boy = 0;
        }
        public Dikdortgen(Point2D p, int en, int boy)
        { M = p; En = en; Boy = boy; }
        public Point2D M { get => m; set => m = value; }
        public int En { get => en; set => en = value; }
        public int Boy { get => boy; set => boy = value; }

    }
}