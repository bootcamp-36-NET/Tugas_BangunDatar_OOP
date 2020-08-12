using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bentuk[] bentuk = { new lingkaran(7), new persegiPanjang(4, 5), new segitiga(4,6,3), new persegi(3) };
                //, new belahKetupat(4, 6)
                int input;



                bentuk bl = new lingkaran(7);
                bentuk bpp = new persegiPanjang(4, 5);
                bentuk bs = new segitiga(4, 6, 3);
                bentuk bp = new persegi(3);

                bool conti = true;

                while (conti)
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Pilihan Luas Bangun Datar");
                    Console.WriteLine("1. Lingkaran");
                    Console.WriteLine("2. Persegi Panjang");
                    Console.WriteLine("3. Segitiga");
                    Console.WriteLine("4. Persegi");
                    Console.WriteLine("5. Exit");
                    //Console.WriteLine("Pilihan : " + input);
                    input = Convert.ToInt32(Console.ReadLine());

                    switch (input)
                    {
                        case 1:
                            // code block
                            bl.GetInfo();

                            Console.WriteLine("Luas {0} : {1:f2}",
                            bl.Nama, bl.Luas());

                            Console.WriteLine("Keliling {0} : {1:f2}",
                            bl.Nama, bl.Keliling());
                            Console.WriteLine();
                            break;
                        case 2:
                            // code block
                            bpp.GetInfo();

                            Console.WriteLine("Luas {0} : {1:f2}",
                            bpp.Nama, bpp.Luas());

                            Console.WriteLine("Keliling {0} : {1:f2}",
                            bpp.Nama, bpp.Keliling());
                            break;
                        case 3:
                            // code block
                            bs.GetInfo();

                            Console.WriteLine("Luas {0} : {1:f2}",
                            bs.Nama, bs.Luas());

                            Console.WriteLine("Keliling {0} : {1:f2}",
                            bs.Nama, bs.Keliling());
                            break;
                        case 4:
                            // code block
                            bp.GetInfo();

                            Console.WriteLine("Luas {0} : {1:f2}",
                            bp.Nama, bp.Luas());

                            Console.WriteLine("Keliling {0} : {1:f2}",
                            bp.Nama, bp.Keliling());
                            break;
                        case 5:
                        default:
                            conti = false;
                            break;
                    }

                    //Console.WriteLine("Apakah ingin mengulang lagi? (y/n)");
                    //if (Console.ReadLine() == "y")
                    //{
                    //    conti = true;
                    //}
                    //else if(Console.ReadLine() == "y")
                    //{
                    //    conti = false;
                    //}
                }

                

                //foreach (bentuk b in bentuk)
                //{

                    
                //    b.GetInfo();

                //    Console.WriteLine("Luas {0} : {1:f2}",
                //    b.Nama, b.Luas());

                //    Console.WriteLine("Keliling {0} : {1:f2}",
                //    b.Nama, b.Keliling());

                    
                    //Lingkaran testlingkaran = b as Lingkaran;
                    //if (testlingkaran == null)
                    //{
                    //    Console.WriteLine("Ini bukan lingkaran");
                    //}
                    //if (b is Lingkaran)
                    //{
                    //    Console.WriteLine("ini bukan persegi panjang");
                    //}

                //    Console.WriteLine();
                //}
                //object ling1 = new Lingkaran(4);

                //Lingkaran ling2 = (Lingkaran)ling1;
                //Console.WriteLine("Luas {0} adalah {1:f2}",
                //    ling2.Nama, ling2.Luas());


                //Console.ReadLine();

            }
            catch (DivideByZeroException err)
            {
                Console.WriteLine(err.Message);
            }

        }
    }
}
