using System;
namespace BangunDatar
{
    public class PersegiPanjang : Persegi
    {
        protected double Luas, Kell, p,l;
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

        public override void hasil()
        {
            try {
                Console.WriteLine("Luas Bangun Datar Persegi");
                Console.WriteLine("Luas = "+p+" * "+l+" = "+Luas+" cm2");
                Console.WriteLine("Kell = 2 * ("+p+" + "+l+") = "+Kell+" cm2");
            } catch (ArithmeticException e) {
                Console.WriteLine(e);
            }  
        }
    }
}