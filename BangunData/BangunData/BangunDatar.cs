using System;
using System.Collections.Generic;
using System.Text;

namespace BangunDatar
{
    abstract public class BangunDatar
    {
        public abstract double p { set; }
        public abstract double l { set; }
        public abstract double t { set; }
        public abstract double area();
        public abstract double perimeter();
    }
}
