using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBangunDatar
{
    class PersegiPanjang : BangunDatar
    {
        public double p { get; set; }
        public double l { get; set; }
        public PersegiPanjang(double panjang, double lebar)
        {
            NamaBD = "Persegi Panjang";

            p = panjang;
            l = lebar;
        }

        public override double HitungLuas()
        {
            _hitung = p * l;
            return _hitung;
        }

        public override double HitungKeliling()
        {
            _hitung = (2 * p) + (2 * l);
            return _hitung;
        }

        public override void GetData()
        {
            base.GetData();
            Console.WriteLine($"Nilai Panjang : {p}");
            Console.WriteLine($"Nilai Lebar : {l}");
        }
    }
}
