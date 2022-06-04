namespace oop_2_2
{
    public class Corolla : IOtomobil
    {
        public Marka Markasi()
        {
            return Marka.Toyota;
        }

        public Renk Rengi()
        {
            return Renk.Kırmızı;
        }

        public int TekerSayisi()
        {
            return 4;
        }
    }
}