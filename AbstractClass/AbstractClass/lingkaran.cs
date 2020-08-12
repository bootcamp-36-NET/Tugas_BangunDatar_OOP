using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class lingkaran : bentuk
    {
        public double Radius { get; set; }

        public lingkaran(double r)
        {
            Nama = "Lingkaran";
            Radius = r;

        }

        public override double Luas()
        {
            return Math.PI * (Math.Pow(Radius, 2.0));
        }

        public override double Keliling()
        {
            return 2*Math.PI * Radius;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Mempunyai radius ={Radius}");
        }

    }
}
