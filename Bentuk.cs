namespace Bootcamp
{
    public class Bentuk //declare parent class
    {
        protected int _luas = 0; //declare variable _luas
        protected int _keliling = 0; //declare variable _keliling
        public virtual int Keliling() //declare parent abstract method Keliling
        {
            return this._keliling;
        }
        public virtual int Luas() //declare parent abstract method Luas
        {
            return this._luas;
        } 
    }
}