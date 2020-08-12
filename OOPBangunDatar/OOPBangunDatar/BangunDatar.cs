using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBangunDatar
{
    abstract class BangunDatar
    {
        public string NamaBD { get; set; }
        public double _hitung;

        public double Hitung
        {
            get { return _hitung; }
            set { _hitung = value; }
        }
        
        public virtual void GetData()
        {
            Console.WriteLine($"Berikut Bangun Datar {NamaBD}");
        }

        public abstract double HitungLuas();
        public abstract double HitungKeliling();
    }
}
