using System;
namespace  oop_1
{
    public class Hayvanlar: Canlilar // Canılardan kalıtım aldı
    {
        protected void Adaptasyon() //Protected yaparsak kaltım alığı sınıftan erişilebilir 
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir");
        }

        public override void UyaranlaraTepki() //virtual olarak işaretlenmiş olanları getirir
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir");
        }
    }

    public class Surungenler:Hayvanlar //hayvanlardan kalıtım aldı
    {
        //constractor
        public Surungenler()
        {
            //base ile kalıtım aldığı sınıfın methodlarına erişebiliyoruz
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SurunerekHareketEtmek()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder");
        }
    }

    public class Kuslar:Hayvanlar //hayvanlardan kalıtım aldı 
    {
        //constractor
        public Kuslar()
        {
            //base ile kalıtım aldığı sınıfın methodlarına erişebiliyoruz
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuslar ucar");
        }
    }
}