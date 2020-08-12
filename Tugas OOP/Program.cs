using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_OOP
{
    class Program
    {
        static void Menu()
        {
            Console.WriteLine("Pilihan :");
            Console.WriteLine("1. Lingkaran");
            Console.WriteLine("2. Persegi");
            Console.WriteLine("3. Persegi Panjang");
            Console.Write("Pilihan :[1-3] ");
        }

        static void Lingkaran()
        {
            string input;
            double outcome = 0;
            double radius;

            Cls();
            do
            {
                Console.Write("Radius : ");
                input = Console.ReadLine();
            } while (!double.TryParse(input, out outcome));
            radius = double.Parse(input);

            Shape lingkaran = new Lingkaran(radius);

            Cls();
            Console.WriteLine("Keliling Lingkaran: " + lingkaran.Keliling());
            Console.WriteLine("Luas Lingkaran: " + lingkaran.Luas());
        }

        static void PersegiPanjang()
        {
            
            double panjang, lebar;

            Cls();
            Console.Write("Panjang : ");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Lebar : ");
            lebar = Convert.ToDouble(Console.ReadLine());

            Persegi persegiPanjang = new PersegiPanjang(panjang, lebar);

            Cls();
            Console.WriteLine("Keliling Persegi Panjang: " + persegiPanjang.Keliling());
            Console.WriteLine("Luas Persegi Panjang: " + persegiPanjang.Luas());
        }

        static void Persegi()
        {
            double sisi;

            Cls();
            Console.Write("Sisi : ");
            sisi = Convert.ToDouble(Console.ReadLine());

            Persegi persegi = new Persegi(sisi);

            Cls();
            Console.WriteLine("Keliling Persegi: " + persegi.Keliling());
            Console.WriteLine("Luas Persegi: " + persegi.Luas());
        }

        static void Cls()
        {
            for (int i = 0; i < 29; i++)
            {
                Console.WriteLine("");
            }
        }

        static void Main(string[] args)
        {
            int bentuk;

            do
            {
                do
                {
                    Cls();
                    Menu();

                    bentuk = int.Parse(Console.ReadLine());
                } while (bentuk < 1 || bentuk > 3);


                switch (bentuk)
                {
                    case 1:
                        Lingkaran();
                        break;
                    case 2:
                        Persegi();
                        break;
                    case 3:
                        PersegiPanjang();
                        break;
                }

                Console.Write("Press [y] to restart... ");

            } while (Console.ReadKey().Key == ConsoleKey.Y);



        }
    }
}
