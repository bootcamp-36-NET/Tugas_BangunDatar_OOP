using System;
using System.Collections.Generic;
using System.Text;

namespace Luas_Bangunan
{
    // Abstraction
    public abstract class Bangunan
    {
        // Abstraction
        public abstract double Area();
        public abstract double Length();
    }

    // Inheirtance
    public class Bulat : Bangunan
    {
        const double Pi = 3.14;
        // Encapsulation
        public double radius { get; set; }

        // Constructor
        public Bulat(double radius)
        {
            this.radius = radius;
        }

        // Polymorphism
        public override double Area()
        {
            return radius * radius * Pi;
        }

        // Polymorphism
        public override double Length()
        {
            return 2 * Pi * radius;
        }

        // Static
        public static void Print()
        {
            Console.WriteLine("Luas dan Keliling Lingkaran Masing - Masing :");
        }
    }

    // Inheirtance
    public class Persegi : Bangunan
    {
        // Encapsulation
        public double side { get; set; }

        // Constructor
        public Persegi(double side)
        {
            this.side = side;
        }

        // Polymorphism
        public override double Area()
        {
            return side * side;
        }

        // Polymorphism
        public override double Length()
        {
            return 4 * side;
        }

        // Static
        public static void Print()
        {
            Console.WriteLine("Luas dan Keliling Persegi Masing - Masing :");
        }
    }

    // Inheirtance
    public class PersegiPanjang : Persegi
    {
        // Encapsulation
        public double height { get; set; }

        // Constructor
        public PersegiPanjang(double side, double height) : base(side)
        {
            this.side = side;
            this.height = height;
        }

        // Polymorphism
        public override double Area()
        {
            return side * height;
        }

        // Polymorphism
        public override double Length()
        {
            return 2 * (side + height);
        }

        // Static
        public static void Print()
        {
            Console.WriteLine("Luas dan Keliling Persegi Panjang Masing - Masing :");
        }
    }
}
