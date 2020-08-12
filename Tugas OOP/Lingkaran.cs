using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_OOP
{
    class Lingkaran : Shape
    {
        private const double Pi = 3.14;
        
        public Lingkaran(double Radius) :base(Radius)
        {
        }

        public override double Keliling()
        {
            return x * Pi;
        }

        public override double Luas()
        {
            return 2 * x * Pi;
        }

    }
}
