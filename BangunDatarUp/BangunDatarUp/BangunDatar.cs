using System;

namespace BangunDatarUp
{
    public abstract class BangunDatar
    {
        public double Luas, Kel, a, b;
        public abstract void set_a(double a);
        public abstract void set_b(double b);
        public abstract void setLuas();
        public abstract void setKel();
        public abstract double get_a();
        public abstract double get_b();
        public abstract double getLuas();
        public abstract double getKel();
        public abstract void hasil();
    }
}