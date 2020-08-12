using BangunDatar;
using System;

namespace BangunData
{
    class Program
    {
        static void Main(string[] args)
        {
            Lingkaran l = new Lingkaran(7);
            PersegiPanjang pp = new PersegiPanjang(2, 4);
            Segitiga s = new Segitiga(2, 4, 8);
            try
            {
                for(int masuk = 1;; masuk++) {
                    Console.WriteLine("-- Kode Angka Operasi Luas & Keliling Bangun Datar --");
                    Console.WriteLine("1. Lingkaran");
                    Console.WriteLine("2. Persegi Panjang");
                    Console.WriteLine("3. Segitiga");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("Silakan Pilih Sodara: ");
                    masuk = Convert.ToInt32(Console.ReadLine());
                    switch (masuk)
                    {
                        case 1:
                            Console.WriteLine("- - - - - - - - - - -");
                            Console.WriteLine($"Luas Lingkaran (3.14 x {l.radius} x {l.radius}) = {l.area()}");
                            Console.WriteLine($" Keliling Lingkaran (2 x 3.14 x {l.radius})= {l.perimeter()}");
                            Console.WriteLine("- - - - - - - - - - - - - - -");
                            Console.WriteLine("Apakah Sodara mau ngitung lagi? Y/N");
                            Char pilih = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine("Y untuk Yes || N untuk No");
                            switch (Char.ToUpper(pilih))
                            {
                                case 'Y':
                                    Console.WriteLine(masuk);
                                    break;
                                case 'N':
                                    Console.WriteLine("--G O O D B Y E--");
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("-- Pilih Y atau N--");
                                    break;
                            }
                            break;
                        case 2:
                            Console.WriteLine("- - - - - - - - - - -");
                            Console.WriteLine($"Luas Persegi Panjang ({pp.panjang} x {pp.lebar})= {pp.area()}");
                            Console.WriteLine($"Keliling Persegi Panjang (2 x ({pp.panjang} + {pp.lebar})) = {pp.perimeter()}");
                            Console.WriteLine("- - - - - - - - - - - - - - -");
                            Console.WriteLine("Apakah Sodara mau ngitung lagi? Y/N");
                            Char pilih2 = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine("Y untuk Yes || N untuk No");
                            switch (Char.ToUpper(pilih2))
                            {
                                case 'Y':
                                    Console.WriteLine(masuk);
                                    break;
                                case 'N':
                                    Console.WriteLine("--G O O D B Y E--");
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("-- Pilih Y atau N--");
                                    break;
                            }
                            break;
                        case 3:
                            Console.WriteLine("- - - - - - - - - - -");
                            Console.WriteLine($"Luas Segitiga (({s.alas} x {s.tinggi}) / 2) = {s.area()}");
                            Console.WriteLine($"Keliling Segitiga ({s.alas} + {s.c} + {s.tinggi}) = {s.perimeter()}");
                            Console.WriteLine("- - - - - - - - - - - - - - -");
                            Console.WriteLine("Apakah Sodara mau ngitung lagi? Y/N");
                            Char pilih3 = Convert.ToChar(Console.ReadLine());
                            Console.WriteLine("Y untuk Yes || N untuk No");
                            switch (Char.ToUpper(pilih3))
                            {
                                case 'Y':
                                    Console.WriteLine(masuk);
                                    break;
                                case 'N':
                                    Console.WriteLine("--G O O D B Y E--");
                                    Environment.Exit(0);
                                    break;
                                default:
                                    Console.WriteLine("-- Pilih Y atau N--");
                                    break;
                            }
                            break;
                        case 4:
                            Console.WriteLine("--G O O D B Y E--");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("- - - - - - - - - - -");
                            Console.WriteLine($"Angka harus sesuai kode tjuy");
                            break;
                    }
                    Console.ReadKey();
                }
            }
            catch (InputMissMatchException err)
            {
                Console.WriteLine("Exception: " + err.Message);
            }
        }
    }
}
