using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBangunDatar
{
    class Lingkaran : BangunDatar
    {
        public double Jari { get; set; }

        public Lingkaran(double r)
        {
            NamaBD = "Lingkaran";
            Jari = r;
        }
        public override double HitungLuas()
        {
            _hitung = Math.PI * (Math.Pow(Jari, 2.0));
            return _hitung;
        }
        public override double HitungKeliling()
        {
            _hitung = 2 * Math.PI * Jari;
            return _hitung;
        }
        public override void GetData()
        {
            base.GetData();
            Console.WriteLine($"Nilai Jari-Jari {Jari}");

        }
    }
}
