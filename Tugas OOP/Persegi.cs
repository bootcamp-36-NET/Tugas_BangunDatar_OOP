using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_OOP
{
    class Persegi : Shape
    {
        public Persegi(double Sisi) :base(Sisi)
        {
        }

        public override double Keliling()
        {
            return 4 * x;
        }

        public override double Luas()
        {
            return x * x;
        }
    }
 

    
}
