namespace Bootcamp
{
    public class Segitiga : Bentuk //declare child class segitiga
    {
        public string text;
        public Segitiga(string pText) //cunstructor
        {
            this.text = pText;
        }

        public int Luas(int a, int t) //implement polymorphism abstract method Luas
        {
            _luas = 1/2 * a * t;
            return _luas;
        }
        public int Keliling(int a, int b, int c) //implement polymorphism abstract method Keliling
        {
            _keliling = a + b + c;
            return _keliling;
        }
    }
}