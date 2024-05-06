using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDPOdev2._4.Sekiller
{
    public class Point2D
    {
        public int x;
        public int y;
        public Point2D()
        { X = 0; Y = 0; }
        public Point2D(int x, int y)
        { X = x; Y = y; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
    }
    public class Point3D : Point2D
    {
        public int z;
        public Point3D() : base()
        { Z = 0; }
        public Point3D(int x, int y, int z)
        { Z = z; }
        public int Z { get => z; set => z = value; }
    }
}