using System;

namespace BasicPrograming
{
    class Program
    {
        public bool ex(bool loop)
        {
            Console.WriteLine("===================================");
            Console.WriteLine("Apakah Anda Ingin Menggunakan Program Lagi ?(y/n) ");
            string get = Console.ReadLine();
            if (get == "y")
            {
                return loop = false;
            }
            else if(get == "n")
            {
                return loop = true;
            }
            else
            {
                return loop = ex(loop);
            }
        }
        static void Main(string[] args)
        {
            
            bool loop = false;

            while(loop != true)
            {
                try
                {
                    //  Block of code to try
                    Console.WriteLine("======= PILIHAN =========");
                    Console.WriteLine("1. Lingkaran");
                    Console.WriteLine("2. Persegi");
                    Console.WriteLine("3. Persegi Panjang");
                    Console.WriteLine("4. Keluar");
                    string get = Console.ReadLine();
                    int x = int.Parse(get);
                    Program pr = new Program();
                    switch (x)
                    {
                        case 1:
                            // code block
                            try
                            {
                                Console.WriteLine("===================================");
                                Console.WriteLine("Masukan Jari Jari : ");
                                string get1 = Console.ReadLine();
                                int x1 = int.Parse(get1);
                                Lingkaran l = new Lingkaran(x1);
                                loop = pr.ex(loop);
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("===================================");
                                Console.WriteLine("Masukan Salah");
                                break;
                            }

                        case 2:
                            try
                            {
                                //  Block of code to try
                                Console.WriteLine("===================================");
                                Console.WriteLine("Masukan Sisi : ");
                                string get2 = Console.ReadLine();
                                int x2 = int.Parse(get2);
                                Persegi p = new Persegi(x2);
                                p.luas();
                                p.keliling();
                                loop = pr.ex(loop);
                                break;
                            }
                            catch (Exception e)
                            {
                                //  Block of code to handle errors
                                Console.WriteLine("===================================");
                                Console.WriteLine("Masukan Salah");
                                break;
                            }
                        case 3:
                            try
                            {
                                //  Block of code to try
                                Console.WriteLine("===================================");
                                Console.WriteLine("Masukan Panjang : ");
                                string get3 = Console.ReadLine();
                                int x3 = int.Parse(get3);
                                Console.WriteLine("Masukan Lebar : ");
                                string get4 = Console.ReadLine();
                                int x4 = int.Parse(get4);
                                PersegiPanjang pp = new PersegiPanjang(x3, x4);
                                loop = pr.ex(loop);
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("===================================");
                                Console.WriteLine("Masukan Salah");
                                break;
                            }

                        case 4:
                            loop = true;
                            break;
                        default:
                            // code block
                            Console.WriteLine("===================================");
                            Console.WriteLine("Masukan Salah");
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("===================================");
                    Console.WriteLine("harap masukan code menu");
                }
                
            } 

        }
    }
}