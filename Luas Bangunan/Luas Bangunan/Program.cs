using System;

namespace Luas_Bangunan
{
    class Program
    {
        static void Main(string[] args)
        {
            string continues;
            try
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Pilih Bangunan : ");
                    Console.WriteLine("1. Bulat");
                    Console.WriteLine("2. Persegi");
                    Console.WriteLine("3. Persegi Panjang");

                    int answer = Convert.ToInt16(Console.ReadLine());

                    switch (answer)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Insert your radius");
                            double input = Convert.ToDouble(Console.ReadLine());
                            // Instance
                            Bulat l1 = new Bulat(input);
                            Bulat.Print();
                            Console.WriteLine(l1.Area() + " " + l1.Length());
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Insert your side");
                            input = Convert.ToDouble(Console.ReadLine());
                            // Instance
                            Persegi p1 = new Persegi(input);
                            Persegi.Print();
                            Console.WriteLine(p1.Area() + " " + p1.Length());
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("Insert your length and height");
                            double length = Convert.ToDouble(Console.ReadLine());
                            double height = Convert.ToDouble(Console.ReadLine());
                            // Instance
                            PersegiPanjang pp1 = new PersegiPanjang(length, height);
                            PersegiPanjang.Print();
                            Console.WriteLine(pp1.Area() + " " + pp1.Length());
                            break;
                        default:
                            Console.WriteLine("Wrong input.");
                            break;
                    }

                    Console.WriteLine("Do you want to continue? (Press y to continue)");
                    continues = Console.ReadLine();
                } while (continues.ToLower() == "y") ;           
            }

            catch (FormatException)
            {
                Console.WriteLine("Wrong Input");
            }
            
            catch (OverflowException)
            {
                Console.WriteLine("Too big");
            }
        }
    }
}
