namespace Bootcamp
{
    public class Persegi : Bentuk //declare child class persegi
    {
        public string text;
        public Persegi(string pText) //cunstructor
        {
            this.text = pText;
        }
        public int Keliling(int s) //implement polymorphism abstract method Keliling
        {
            _keliling = 4*s;
            return _keliling;
        }
        public int Luas(int s) //implement polymorphism abstract method Luas
        {
            _luas = s*s;
            return _luas;
        }
    }
}