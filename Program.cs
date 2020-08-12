using System;

namespace Bootcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Welcome--");
            string lanjut = "y";
            while(lanjut == "y")
            {
                Console.Write("Enter number : ");
                string pilihan = Console.ReadLine();
                String angka1, angka2, angka3;
                
                switch(pilihan)
                {
                    case "1":
                                Persegi a = new Persegi("---Ini ngitung persegi ya---");    //instantiate object a from class persegi
                                Console.WriteLine(a.text);                                  //print cunstructor
                                
                                Console.WriteLine("Masukkan nilai sisi : ");
                                angka1 = Console.ReadLine();
                                int sisi = Convert.ToInt32(angka1);
                                
                                Console.WriteLine("Luas persegi A = "+a.Luas(sisi));           //print result from method Luas
                                Console.WriteLine("Keliling persegi A = "+a.Keliling(sisi));   //print result from method Keliling
                                Console.Write("Lanjut gak nih? (y/n) ");
                                lanjut = Console.ReadLine();
                                break;
                    case "2":
                                Segitiga c = new Segitiga("---Ini ngitung segitiga ya---");        //insantiate object b from class segitiga
                                Console.WriteLine(c.text);                                         //print custructor
                                
                                Console.WriteLine("Masukkan nilai alas : ");
                                angka1 = Console.ReadLine();
                                int alas = Convert.ToInt32(angka1);
                                Console.WriteLine("Masukkan nilai tinggi : ");
                                angka2 = Console.ReadLine();
                                int tinggi = Convert.ToInt32(angka2);
                                Console.WriteLine("Masukkan nilai sisi : ");
                                angka3 = Console.ReadLine();
                                int sisi1 = Convert.ToInt32(angka3);
                                
                                Console.WriteLine("Luas segitiga C = "+c.Luas(alas, tinggi));             //print result from method Luas
                                Console.WriteLine("Keliling segitiga C = "+c.Keliling(alas, tinggi, sisi1));     //print result from method Keliling
                                Console.Write("Lanjut gak nih? (y/n) ");
                                lanjut = Console.ReadLine();
                                break;
                    case "3":
                                PersegiPanjang d = new PersegiPanjang("---Ini ngitung persegi panjang ya---");
                                Console.WriteLine(d.text);

                                Console.WriteLine("Masukkan nilai panjang : ");
                                angka1 = Console.ReadLine();
                                int panjang = Convert.ToInt32(angka1);
                                Console.WriteLine("Masukkan nilai lebar : ");
                                angka2 = Console.ReadLine();
                                int lebar = Convert.ToInt32(angka2);
                                Console.Write("Lanjut gak nih? (y/n) ");
                                lanjut = Console.ReadLine();
                                break;
                    
                }
            };

            Console.WriteLine("Bye");
            
            
            
        }
    }
}
