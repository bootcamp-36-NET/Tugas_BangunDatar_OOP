using System;
using System.Collections.Generic;
using System.Text;

namespace BangunDatar
{
    public class Lingkaran : BangunDatar
    {
        public double radius;
        private double lebar;
        private double tinggi;
        public Lingkaran(double radius)
        {
            this.radius = radius;
        }
        public override double p
        {
            set => radius = value;
        }
        public override double l
        {
            set => lebar = value;
        }
        public override double t { set => tinggi =value; }
        public override double area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public override double perimeter()
        {
            return 2 * Math.PI * radius;
        }
        
    }
}
