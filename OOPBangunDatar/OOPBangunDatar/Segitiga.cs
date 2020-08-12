using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBangunDatar
{
    class Segitiga : BangunDatar
    {
        public double a { get; set; }
        public double t { get; set; }
        public double s { get; set; }
        public Segitiga(double alas, double tinggi, double sisi)
        {
            NamaBD = "Segitiga";
            a = alas;
            t = tinggi;
            s = sisi;
        }
        public override double HitungLuas()
        {
            _hitung = (a * t) / 2;
            return _hitung;
        }
        public override double HitungKeliling()
        {
            _hitung = 3 * s;
            return _hitung;
        }
        public override void GetData()
        {
            base.GetData();
            Console.WriteLine($"Nilai Alas : {a}");
            Console.WriteLine($"Nilai Tinggi : {t}");
            Console.WriteLine($"Nilai Sisi : {s}");
        }
    }
}
