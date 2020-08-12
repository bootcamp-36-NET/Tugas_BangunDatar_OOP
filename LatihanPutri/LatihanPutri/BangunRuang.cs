using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanPutri
{
    class BangunRuang
    {
        public int pilihan;
        


        public void bangunruang()
        {
            Console.WriteLine("1.Lingkaran");
            Console.WriteLine("2.Persegi");
            Console.WriteLine("3.Persegi Panjang");
            
            Console.WriteLine("Masukkan Pilihan: ");
            
            //  pilihan = int.Parse(Console.ReadLine());
            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    {
                        Ligkaran a = new Ligkaran();
                        Console.WriteLine("Menghitung Lingkaran:");
                        Console.Write("Jari-jari:");

                        a.jari_jari = (double.Parse(Console.ReadLine()));

                        Console.WriteLine("Luas={0} cm", a.luas_lingkaran());
                        Console.WriteLine("Keliling={0} cm", a.keliling_lingkaran());
                        break;
                    }
                case "2":
                    {
                        Persegi b = new Persegi();

                        Console.WriteLine("Menghitung Persegi:");
                        Console.Write("Sisi:");
                        b.sisi = (int.Parse(Console.ReadLine()));

                        Console.WriteLine("Luas={0} cm", b.luas_persegi());
                        Console.WriteLine("Keliling={0} cm", b.keliling_persegi());

                        break;
                    }
                case "3":
                    {
                        PersegiPanjang c = new PersegiPanjang();

                        Console.WriteLine("Menghitung Persegi Panjang:");
                        Console.WriteLine("Panjang:");
                        c.panjang = (int.Parse(Console.ReadLine()));
                        Console.WriteLine("Lebar:");
                        c.lebar = (int.Parse(Console.ReadLine()));

                        Console.WriteLine("Luas={0} cm", c.luas_pp());
                        Console.WriteLine("Keliling={0} cm", c.keliling_pp());
                        break;
                    }

                default:
                    break;
            }
            
        }

    }
}
