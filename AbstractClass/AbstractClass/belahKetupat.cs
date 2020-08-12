//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace AbstractClass
//{
//    class belahKetupat : Bentuk
//    {
//        public double d1 { get; set; }
//        public double d2 { get; set; }

//        public belahKetupat(double diagonal1,
//            double diagonal2)
//        {
//            Nama = "Belah Ketupat";
//            d1 = diagonal1;
//            d2 = diagonal2;
//        }

//        public override double Luas()
//        {
//            return (d1 * d2) / 2;
//        }

//        // You can replace the method using override
//        public override void GetInfo()
//        {
//            // Execute the base version
//            base.GetInfo();
//            Console.WriteLine($"Mempunyai diagonal 1 = {d1} dan diagonal 2 = {d2}");
//        }
//    }
//}
