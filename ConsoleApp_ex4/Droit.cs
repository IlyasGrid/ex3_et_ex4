using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp_ex3;

namespace ConsoleApp_ex4
{
    internal class Droit : Point
    {


        double coefficiant;
        double rest;

        Droit(double a ,double b)
        {
            this.coefficiant = a;
            this.rest = b;
        }
        public double A {
            get 
            { return coefficiant; }

            set {
                coefficiant = value;
            } }
        public double B
        {
            get
            { return rest; }

            set
            {
                rest = value;
            }
        }




        public bool Egalite(Droit d)
        {
            if ((d.coefficiant == this.coefficiant) && (d.rest == this.rest))
                return true;
            return false;
        }
        public bool parallelisme(Droit d)
        {
            if ((d.coefficiant == this.coefficiant))
                return true;
            return false;
        }
        public Point? intersection(Droit d)
        {
            if (this.parallelisme(d))
                return null;

            
            double x, y;

            x = (d.rest - this.rest)/(this.coefficiant -  d.coefficiant);
            y = this.coefficiant * x + this.rest;

            Point point = new Point(x,y);

            return point;
        }
        public bool perpendicularité(Droit d)
        {
            if (this.coefficiant * d.coefficiant == -1)
            return true;

            return false;
        }
    }
}
