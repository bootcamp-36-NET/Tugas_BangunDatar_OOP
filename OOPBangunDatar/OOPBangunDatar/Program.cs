using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBangunDatar
{
    class Program
    {
        static void Main(string[] args)
        {
            BangunDatar[] BD ={new Lingkaran(4), new Persegi(7),
                new PersegiPanjang(9,5), new Segitiga(4,5,6)};
            int angka;
            BangunDatar L = new Lingkaran(4);
            BangunDatar PP = new PersegiPanjang(9, 5);
            BangunDatar S = new Segitiga(4, 5, 6);
            BangunDatar P = new Persegi(7);

            bool lanjut = true;
            while (true)
            {
                Console.WriteLine("======================");
                Console.WriteLine("Pilih Bangun Datar : ");
                Console.WriteLine("1. Persegi Panjang");
                Console.WriteLine("2. Persegi ");
                Console.WriteLine("3. Segitiga ");
                Console.WriteLine("4. Lingkaran ");
                Console.WriteLine("5. Selesai");
                angka = Convert.ToInt16(Console.ReadLine());
                switch (angka)
                {
                    case 1:
                        PP.GetData();
                        Console.WriteLine("Luas {0} : {1:f2}",
                                          PP.NamaBD, PP.HitungLuas());
                        Console.WriteLine("Keliling {0} : {1:f2}",
                                          PP.NamaBD, PP.HitungKeliling());
                        Console.WriteLine();

                        break;
                    case 2:
                        P.GetData();
                        Console.WriteLine("Luas {0} : {1:f2}",
                                          P.NamaBD, P.HitungLuas());
                        Console.WriteLine("Keliling {0} : {1:f2}",
                                          P.NamaBD, P.HitungKeliling());
                        Console.WriteLine();
                        break;
					case 3:
                        S.GetData();
                        Console.WriteLine("Luas {0} : {1:f2}",
                                          S.NamaBD, S.HitungLuas());
                        Console.WriteLine("Keliling {0} : {1:f2}",
                                          S.NamaBD, S.HitungKeliling());
                        Console.WriteLine();
                        break;
					case 4:
                        L.GetData();
                        Console.WriteLine("Luas {0} : {1:f2}",
                                          L.NamaBD, L.HitungLuas());
                        Console.WriteLine("Keliling {0} : {1:f2}",
                                          L.NamaBD, L.HitungKeliling());
                        Console.WriteLine();
                        break;
					case 5:
                    default:
                        lanjut = false;
                        break;
                }
            }

        }
    }
}
