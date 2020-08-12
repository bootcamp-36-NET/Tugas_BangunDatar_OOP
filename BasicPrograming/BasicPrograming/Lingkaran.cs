using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograming
{
    class Lingkaran : BangunDatar
    {
        private int jari;
        private const double PI = 3.1415926535897931;
        public Lingkaran(int jari)
        {
            this.jari = jari;
            luas();
            keliling();
        }
        public override void keliling()
        {
            double hasil = 2 * PI * jari;
            Console.WriteLine("Keliling Lingkaran Adalah : " + hasil);
        }

        public override void luas()
        {
            double hasil = PI * jari * jari;
            Console.WriteLine("Luas Lingakran Adalah : " + hasil);
        }
    }
}
