using System;

namespace BangunDatar
{
    public class Lingkaran : BangunDatar
    {
        protected double Luas, Kel, r;

        public override void set_a(double a)
        {
            this.r = a;
        }

        public override void set_b(double b)
        {
            this.r = b;
        }
        public override void setKel()
        {
            Kel = 2 * r * 3.14;
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
        public override double getKel()
        {
            return Kel;
        }

        public override double getLuas()
        {
            return Luas;
        }

        public override void hasil()
        {
            try
            {
                Console.WriteLine("Lingkaran");
                Console.WriteLine("Luas = " + r + " * " + r + " * 3.14 = " + Luas);
                Console.WriteLine("Keliling = " + 2 + " * " + r + " * 3.14 = " + Kel);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}