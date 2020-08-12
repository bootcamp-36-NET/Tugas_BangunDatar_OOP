using System;

namespace BangunDatar
{
    public class Bulat : BangunDatar
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
            Luas = 2 * r * 3.14;
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

        public override void hasil()
        {
            try {
                Console.WriteLine("Luas Bangun Datar Lingkaran");
                Console.WriteLine("Luas = "+r+" * "+r+" * 3.14 = "+Luas+" cm2");
            } catch (ArithmeticException e) {
                Console.WriteLine(e);
            }  
        }        
    }
}