using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatarOOP
{
    class Program
    {
        private void cetak_semua(BangunDatar OB, double a, double b)
        {
            OB.set_a(a);
            OB.set_b(b);
            OB.setLuas();
            OB.setKell();
            OB.tampil();
        }
        static void Main(string[] args)
        {
            Program p = new Program();        

            while (true)
            {
                Console.WriteLine("=== Menghitung Luas Bangun Datar ===");
                Console.WriteLine("1. Hitung Luas Lingkaran");
                Console.WriteLine("[1] Persegi");
                Console.WriteLine("[2] Persegi Panjang");
                Console.WriteLine("[3] Lingkaran");
                Console.WriteLine("[4] Keluar Program");
                Console.Write("Masukkan pilihan : ");
                int aksi = Convert.ToInt32(Console.ReadLine()); ;

                    switch (aksi)
                    {
                        case 1:
                            Persegi persegi = new Persegi();
                            Console.WriteLine(" ");
                            Console.Write("Masukan sisi : ");
                            double s = Convert.ToDouble(Console.ReadLine());
                            p.cetak_semua(persegi, s, s);
                            Console.WriteLine("");
                            break;

                        case 2:
                            PersegiPanjang persegi_panjang = new PersegiPanjang();
                            Console.WriteLine(" ");
                            Console.Write("Masukan Panjang : ");
                            double panjang = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukan Lebar : ");
                            double lebar = Convert.ToDouble(Console.ReadLine());
                            p.cetak_semua(persegi_panjang, panjang, lebar);
                            Console.WriteLine("");
                            break;

                        case 3:
                            Lingkaran bulat = new Lingkaran();
                            Console.WriteLine("");
                            Console.Write("Masukan Jari - Jari : ");
                            double r = Convert.ToDouble(Console.ReadLine());
                            p.cetak_semua(bulat, r, r);
                            Console.WriteLine("");
                            break;

                        case 4:
                            Console.WriteLine("Exiting Program...");
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine(aksi + " Inputan anda salah ");
                            break;
                    }

            }
        }
    }
}
