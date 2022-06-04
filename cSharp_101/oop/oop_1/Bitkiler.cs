using System;
namespace  oop_1
{
    public class Bitkiler : Canlilar //Calılardan kalıtım aldı
    {
        protected void FotosentezYapmak()//Protected yaparsak kaltım alığı sınıftan erişilebilir
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }

        public override void UyaranlaraTepki()
        {
           // base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler güneşe tepki verir");
        }
    }

    public class TohumluBitkiler : Bitkiler //Bitkilerden kalıtım aldı
    {
        //constractor
        public TohumluBitkiler()
        {
            //base ile kalıtım aldığı sınıfın methodlarına erişebiliyoruz
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
        }

        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır");
        }
        
    }


     public class TohumsuzBitkiler :Bitkiler //Bitkilerden kalıtım aldı
    {
        //constractor
        public TohumsuzBitkiler()
        {
            //base ile kalıtım aldığı sınıfın methodlarına erişebiliyoruz
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void Sporlacogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla çoğalır");
        }
        
    }
}