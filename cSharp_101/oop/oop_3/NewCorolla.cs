namespace oop_3
{
    public class NewCorolla : Otomobil
    {
        public override Marka Markasi()
        {
            return Marka.Toyota;
        }

        public override Renk Rengi() // ekledik
        { 
            return Renk.Mavi;
        }
    }
}