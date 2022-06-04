namespace oop_2_2
{
    public class Megane : IOtomobil
    {
        public Marka Markasi()
        {
            return Marka.Renault;
        }

        public Renk Rengi()
        {
            return Renk.Beyaaz;
        }

        public int TekerSayisi()
        {
            return 4;
        }
    }
}