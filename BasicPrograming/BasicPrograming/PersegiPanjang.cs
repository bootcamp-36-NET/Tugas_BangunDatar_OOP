using System;
using System.Collections.Generic;
using System.Text;

namespace BasicPrograming
{
    class PersegiPanjang : Persegi
    {
        private int lebar;
        private int panjang;
        public PersegiPanjang(int sisi, int lebar) : base(sisi)
        {
            this.lebar = lebar; 
            this.panjang = sisi;
            luas();
            keliling();

        }
        public override void luas()
        {
            int hasil = panjang * this.lebar;
            Console.WriteLine("Luas Persegi Panjang Adalah : " + hasil);
        }

        public override void keliling()
        {
            int hasil = panjang + panjang + lebar + lebar;
            Console.WriteLine("Keliling Persegi Panjang Adalah : " + hasil);
        }
    }
}
