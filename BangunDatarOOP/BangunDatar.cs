using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatarOOP
{
    public abstract class BangunDatar
    {
        protected double Luas, Kell;
        public abstract void set_a(double a);
        public abstract void set_b(double b);
        public abstract void setKell();
        public abstract void setLuas();
        public abstract double get_a();
        public abstract double get_b();
        public abstract double getKell();
        public abstract double getLuas();
        public abstract void tampil();
    }
}
