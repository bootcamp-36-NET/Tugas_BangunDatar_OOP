using System;
namespace BangunDatar
{
    public class PersegiPanjang : Persegi
    {
        protected double Luas, Kel, p, l;
        public override void set_a(double a)
        {
            this.p = a;
        }
        public override void set_b(double b)
        {
            this.l = b;
        }
        public override void setKel()
        {
            Kel = 2 * (p + l);
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
                Console.WriteLine("Persegi Panjang");
                Console.WriteLine("Luas = " + p + " * " + l + " = " + Luas + " cm2");
                Console.WriteLine("Keliling = 2 * (" + p + " + " + l + ") = " + Kel + " cm2");
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}