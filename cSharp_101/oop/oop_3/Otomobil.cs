namespace oop_3
{
    public abstract class Otomobil  
    {
        //Abstract Class

        public int TekerSayisi()
        {
            return 4;
        }

        public virtual Renk Rengi()
        {
            return  Renk.Mavi;
        }


        public abstract Marka Markasi();
    }
}