using System;

namespace BangunDatar
{
    class Program
    {
        private void cetak_semua(BangunDatar L_BD, double a, double b){
            L_BD.set_a(a);
            L_BD.set_b(b);
            L_BD.setLuas();
            L_BD.setKell();
            L_BD.hasil();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int choose;
            Console.WriteLine("Hello World!");

            

            while(true){
                Console.WriteLine("1. Hitung Luas Lingkaran");
                Console.WriteLine("2. Hitung Luas Persegi");
                Console.WriteLine("3. Hitung Luas Persegi Panjang");
                Console.WriteLine("4. Keluar Program");
                Console.Write("Masukkan pilihan anda [1-6] : ");
                int pilih = Convert.ToInt32(Console.ReadLine());;

                try {
                    switch(pilih){
                        case 1:
                            Bulat bulat = new Bulat();
                            Console.WriteLine("========================================");
                            Console.WriteLine("");
                            Console.Write("Masukan Jari - Jari : ");
                            double r = Convert.ToDouble(Console.ReadLine());
                            p.cetak_semua(bulat, r, r);
                            Console.WriteLine("");
                            Console.WriteLine("========================================");
                            break;

                        case 2: 
                            Persegi persegi = new Persegi();
                            Console.WriteLine("========================================");
                            Console.WriteLine("");
                            Console.Write("Masukan sisi : ");
                            double s = Convert.ToDouble(Console.ReadLine());
                            p.cetak_semua(persegi, s, s);
                            Console.WriteLine("");
                            Console.WriteLine("========================================");
                            
                            break;

                        case 3:
                            PersegiPanjang persegi_panjang = new PersegiPanjang();
                            Console.WriteLine("========================================");
                            Console.WriteLine("");
                            Console.Write("Masukan Panjang : ");
                            double panjang = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Masukan Lebar : ");
                            double lebar = Convert.ToDouble(Console.ReadLine());
                            p.cetak_semua(persegi_panjang, panjang, lebar);
                            Console.WriteLine("");
                            Console.WriteLine("========================================");
                            break;

                        case 4: 
                            Console.WriteLine("Exiting Program...");
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine(pilih + " is not a valid Menu Option! Please Select Another.");
                            break;
                    }

                } catch (Exception e) {
                    Console.WriteLine(e);
                    Console.WriteLine("Input can't use string");

                }

            }
        }
    }
}
