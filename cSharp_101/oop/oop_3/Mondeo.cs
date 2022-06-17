namespace oop_3

{
    public class Mondeo : IOtomobil
    {
        public Marka Markasi()
        {
            return Marka.Ford;
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