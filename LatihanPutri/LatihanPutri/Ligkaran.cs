using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPutri
{
    class Ligkaran : BangunRuang
    {
        private double r, luas, keliling;

        public double jari_jari
        {
            get { return r; }
            set {r = value; }
        }

        public double luas_lingkaran()
        {
            luas = 3.14 * r * r;
            return luas;
        }

        public double keliling_lingkaran()
        {
            keliling = 2 * 3.14 * r;
            return keliling;
        }
    }
}

