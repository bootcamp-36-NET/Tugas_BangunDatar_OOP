using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class segitiga : bentuk
    {
        public double a { get; set; }
        public double t { get; set; }
        public double s { get; set; }

        public segitiga(double alas,
            double tinggi, double sisi)
        {
            Nama = "Segitiga";
            a = alas;
            t = tinggi;
            s = sisi;
        }

        public override double Luas()
        {
            return (a * t)/2;
        }

        public override double Keliling()
        {
            return 3 * s;
        }

        // You can replace the method using override
        public override void GetInfo()
        {
            // Execute the base version
            base.GetInfo();
            Console.WriteLine($"Mempunyai alas = {a} dan tinggi = {t}");
        }
    }
}
