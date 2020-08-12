using System;

namespace BangunDatar
{
    class Program
    {
        private void cetak_semua(BangunDatar BD, double a, double b)
        {
            BD.set_a(a);
            BD.set_b(b);
            BD.setLuas();
            BD.setKel();
            BD.hasil();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int choose;
            Console.WriteLine("Silahkan Pilih Bangun Datar");



            while (true)
            {
                Console.WriteLine("1. Lingkaran");
                Console.WriteLine("2. Persegi");
                Console.WriteLine("3. Panjang");
                Console.WriteLine("4. Keluar");
                Console.Write("Masukkan pilihan anda : ");
                int pilih = Convert.ToInt32(Console.ReadLine()); ;

                try
                {
                    switch (pilih)
                    {
                        case 1:
                            Lingkaran lingkaran = new Lingkaran();
                            Console.WriteLine("________________________________________");
                            Console.Write("Masukan Jari - Jari : ");
                            double r = Convert.ToDouble(Console.ReadLine());
                            p.cetak_semua(lingkaran, r, r);
                            Console.WriteLine("");
                            Console.WriteLine("_______________________________________");
                            break;

                        case 2:
                            Persegi persegi = new Persegi();
                            Console.WriteLine("_______________________________________");
                            Console.Write("sisi : ");
                            double s = Convert.ToDouble(Console.ReadLine());
                            p.cetak_semua(persegi, s, s);
                            Console.WriteLine("");
                            Console.WriteLine("_______________________________________");

                            break;

                        case 3:
                            PersegiPanjang persegi_panjang = new PersegiPanjang();
                            Console.WriteLine("_______________________________________");
                            Console.WriteLine("");
                            Console.Write("Panjang : ");
                            double panjang = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Lebar : ");
                            double lebar = Convert.ToDouble(Console.ReadLine());
                            p.cetak_semua(persegi_panjang, panjang, lebar);
                            Console.WriteLine("_______________________________________");
                            break;

                        case 4:
                            Console.WriteLine("Exiting Program...");
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine(pilih + " Tidak Ada Di Menu");
                            break;
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("Inputan Salah");

                }

            }
        }
    }
}