using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograming
{
    class Persegi : BangunDatar
    {
        private int panjang;
        private int lebar;

        public Persegi(int sisi)
        {
            this.panjang = sisi;
            this.lebar = sisi; 
        }

        public override void luas()
        {
            int hasil = panjang * lebar;
            Console.WriteLine("Luas Persegi Adalah : " + hasil);
        }

        public override void keliling()
        {
            int hasil = 4 * panjang;
            Console.WriteLine("Keliling Persegi Adalah : " + hasil);
        }

 
    }
}
