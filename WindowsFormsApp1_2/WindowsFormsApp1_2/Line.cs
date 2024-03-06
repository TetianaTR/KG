using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1_2
{
    public class Line
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }

        public Line(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
        }
    }

}
