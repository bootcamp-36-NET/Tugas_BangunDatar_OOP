using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_OOP
{
    abstract class Shape
    {
        protected double x;

        public Shape(double x)
        {
            this.x = x;
        }

        public abstract double Luas();
    
        public abstract double Keliling();
    }
}
