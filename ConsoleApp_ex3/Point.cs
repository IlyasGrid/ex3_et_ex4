using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_ex3
{
    internal class Point
    {
        double x;
        double y;

   
        Point(double x=0 , double y=0)
        {
            this.x = x;
            this.y = y;
        }

        public void setAbsciss(int x)
        {
            this.x = x;
        }
        public void setOrdonne(int y)
        {
            this.y = y;
        }
        public double getAbsciss()
        {
            return this.x;
        }

        public double getOrdonne()
        {
            return this.y;
        }

        public double Distance(Point p1,Point p2)
        {
            return Math.Sqrt(Math.Pow(  (p1.x - p2.x),2) + Math.Pow((p1.y - p2.y), 2) );
        }

        public bool Egalite(Point p1, Point p2)
        {
            if ((p1.x == p2.x )&& (p1.y == p2.y))
                return true;
            return false;
        }

        public Point Translation(double newX,double newY)
        {
            this.y = newY;
            this.x = newX;
            return this;
        }
        public bool Linairite(Point p1, Point p2)
        {
            double m;
            double rest;
            m = (p1.y - p2.y) / (p1.x - p2.x);
            rest = p1.y - (m *p1.x );


            if( (this.y - (m * this.x)-rest) == 0)
                return true;
            return false;
        }

    }
}
