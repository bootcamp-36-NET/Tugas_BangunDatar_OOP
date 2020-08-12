using System;
using System.Collections.Generic;
using System.Text;

namespace BangunDatar
{
    public class Segitiga : BangunDatar
    {
        public double alas;
        public double tinggi;
        public double c;
        public Segitiga(int alas, int tinggi, int c)
        {
            this.alas = alas;
            this.tinggi = tinggi;
            this.c = c;
        }
        public override double p { set => alas = value; }
        public override double l { set => tinggi=value; }
        public override double t { set => c =value ; }
        public override double area()
        {
            return (alas * tinggi) / 2;
        }
        public override double perimeter()
        {
            return alas + c + tinggi;
        }
    }
}
