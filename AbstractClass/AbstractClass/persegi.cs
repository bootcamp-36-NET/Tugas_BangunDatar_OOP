using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    //inheritance
    class persegi : bentuk
    {
        public double s { get; set; }

        public persegi(double sisi)
        {
            Nama = "Persegi";
            s = sisi;
        }

        public override double Luas()
        {
            return s * s;
        }

        public override double Keliling()
        {
            return 4 * s;
        }
        // You can replace the method using override
        public override void GetInfo()
        {
            // Execute the base version
            base.GetInfo();
            Console.WriteLine($"Mempunyai sisi = {s}");
        }
    }
}
