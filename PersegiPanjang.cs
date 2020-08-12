namespace Bootcamp
{
    public class PersegiPanjang : Bentuk
    {
        string text;
        public PersegiPanjang(string pText)
        {
            this.text = pText;
        }
        public int Keliling(int p, int l)
        {
            _keliling = 2 * (p+l);
            return _keliling;
        }
        public int Luas(int p, int l)
        {
            _luas = p * l;
            return _luas;
        }
    }
}