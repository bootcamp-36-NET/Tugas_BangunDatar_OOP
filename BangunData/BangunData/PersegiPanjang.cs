using System;
using System.Collections.Generic;
using System.Text;

namespace BangunDatar
{
    public class PersegiPanjang: BangunDatar
    {
        public double panjang;
        public double lebar;
        private double tinggi;
        public PersegiPanjang(double panjang, double lebar)
        {
            this.panjang = panjang;
            this.lebar = lebar;
        }
        public override double p { set => panjang = value; }
        public override double l { set => lebar = value; }
        public override double t { set => tinggi = value; }
        public override double area()
        {
            return this.panjang * this.lebar;
        }
        public override double perimeter()
        {
            return 2 * (panjang + lebar);
        }
    }
}
