using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPutri
{
    class Persegi: BangunRuang
    {
        private int s, luas, keliling;

        public int sisi
        {
            get { return s; }
            set {s = value; }
        }

        public int luas_persegi()
        {
            luas = s * s;
            return luas;
        }

        public int keliling_persegi()
        {
            keliling = s * 4;
            return keliling;
        }
    }
}
