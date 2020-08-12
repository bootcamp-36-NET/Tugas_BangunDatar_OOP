using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatarOOP
{
    public class Lingkaran : BangunDatar
    {
        protected double Luas, Kell, r;

        public override void set_a(double a)
        {
            this.r = a;
        }

        public override void set_b(double b)
        {
            this.r = b;
        }
        public override void setKell()
        {
            Kell = 2 * r * 3.14;
        }

        public override void setLuas()
        {
            Luas = r * r * 3.14;
        }

        public override double get_a()
        {
            return r;
        }

        public override double get_b()
        {
            return r;
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
            Console.WriteLine("Luas Lingkaran = " + r + " * " + r + " * 3.14 = " + Luas + " cm2");
            Console.WriteLine("Kell Lingkaran = 2 * " + r + " / " + " * 3.14 = " + Kell + " cm2");
        }
    }
}
