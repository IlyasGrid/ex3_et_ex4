using ConsoleApp_ex3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ex4
{
    internal class Circle
    {
        Point centre = new();
        double radius;
        Circle(Point point, double r )
        {
            this.centre = point;
            this.radius = r;
        }
        public double r
        {
            get
            { return radius; }

            set
            {
                radius = value;
            }
        }
        public Point p
        {
            get
            { return centre; }

            set
            {
                centre = value;
            }
        }

        public bool Egalite(Circle d)
        {
            if ((d.radius == this.radius) && (d.centre == this.centre))
                return true;
            return false;
        }
        public bool intersection(Circle c)
        {
            if (centre.Distance(c.centre) < (c.radius+this.radius))
                return true;
            return false;
        }
        public double Circonférence()
        {
            return 3.14 * this.radius * 2;
        }
        public double air()
        {
            return 3.14 * this.radius * this.radius;
        }
    }
}
