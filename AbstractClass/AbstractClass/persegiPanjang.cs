using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class persegiPanjang : bentuk
    {
        public double p { get; set; }
        public double l { get; set; }

        public persegiPanjang(double panjang,
            double lebar)
        {
            Nama = "Persegi Panjang";
            p = panjang;
            l = lebar;
        }

        public override double Luas()
        {
            return p * l;
        }

        public override double Keliling()
        {
            return (2 * p) + (2 * l);
        }

        // You can replace the method using override
        public override void GetInfo()
        {
            // Execute the base version
            base.GetInfo();
            Console.WriteLine($"Mempunyai panjang = {p} dan Lebar = {l}");
        }
    }
}
