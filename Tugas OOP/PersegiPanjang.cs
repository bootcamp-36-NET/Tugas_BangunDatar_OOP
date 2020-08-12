using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_OOP
{
    class PersegiPanjang : Persegi
    {
        private double Lebar;

        public PersegiPanjang(double panjang, double lebar) : base(panjang)
        {
            x = panjang;
            this.Lebar = lebar;
        }

        public override double Keliling()
        {
            return (x + this.Lebar) * 2;
        }

        public override double Luas()
        {
            return x * this.Lebar;
        }
    }
}
