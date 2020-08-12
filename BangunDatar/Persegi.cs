using System;
namespace BangunDatar
{
    public class Persegi : BangunDatar
    {
        protected double Luas, Kell, s;

        public override void set_a(double a)
        {
            this.s = a;
        }

        public override void set_b(double b)
        {
            this.s = b;
        }
        public override void setKell()
        {
            Kell = 4 * s;
        }

        public override void setLuas()
        {
            Luas = s * s;
        }

        public override double get_a()
        {
            return s;
        }

        public override double get_b()
        {
            return s;
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
                Console.WriteLine("Luas = "+s+" * "+s+" = "+Luas+" cm2");
                Console.WriteLine("Kell = 4 * "+s+" = "+Kell+" cm2");
            } catch (ArithmeticException e) {
                Console.WriteLine(e);
            }  
        }
    }
}