using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBangunDatar
{
    class Persegi: BangunDatar
    {
        public double s
        {
            get;
            set;
        }
        public Persegi(double sisi)
        {
            NamaBD = "Persegi";
            s = sisi;
        }
        public override double HitungLuas()
        {
            _hitung = s * s;
            return _hitung;
        }
        public override double HitungKeliling()
        {
            _hitung = 4 * s;
            return _hitung;
        }
        public override void GetData()
        {
            base.GetData();
            Console.WriteLine($"Nilai Sisi : {s}");

        }
    }
}
