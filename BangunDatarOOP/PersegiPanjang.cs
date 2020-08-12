using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatarOOP
{
    public class PersegiPanjang : Persegi
    {
        protected double Luas, Kell, p, l;
        public override void set_a(double a)
        {
            this.p = a;
        }
        public override void set_b(double b)
        {
            this.l = b;
        }
        public override void setKell()
        {
            Kell = 2 * (p + l);
        }

        public override void setLuas()
        {
            Luas = p * l;
        }

        public override double get_a()
        {
            return p;
        }

        public override double get_b()
        {
            return l;
        }
        public override double getKell()
        {
            return Kell;
        }

        public override double getLuas()
        {
            return Luas;
        }

        public override void tampil()
        {
             Console.WriteLine("Luas Persegi Panjang = " + p + " * " + l + " = " + Luas + " cm2");
             Console.WriteLine("Kell Persegi Panjang = 2 * (" + p + " + " + l + ") = " + Kell + " cm2");
        }
    }
}
