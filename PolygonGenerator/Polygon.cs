
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace PolygonGenerator
{
    public class Polygon
    {
        public Polygon(Point[] points)
        {
            Points = points.ToList();
        }

        public List<Point> Points { get; set; }
    }
}
