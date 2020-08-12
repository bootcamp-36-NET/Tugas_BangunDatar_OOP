using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPutri
{
    class PersegiPanjang : BangunRuang
    {
        private int p, l, luas, keliling;

        public int panjang
        {
            get { return p; }
            set { p = value;}
        }


        public int lebar
        {
            get { return l; }
            set{l = value;}
        }

        public int luas_pp()
        {
            luas = p * l;
            return luas;
        }

        public int keliling_pp()
        {
            keliling = (p*2)+(l*2);
            return keliling;
        }
    }
}
