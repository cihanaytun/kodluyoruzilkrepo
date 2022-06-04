namespace oop_2_2
{
    public class Passat : IOtomobil
    {
        public Marka Markasi()
        {
            return Marka.Vokswagen;
        }

        public Renk Rengi()
        {
            return Renk.Gri;
        }

        public int TekerSayisi()
        {
            return 4;
        }
    }
}