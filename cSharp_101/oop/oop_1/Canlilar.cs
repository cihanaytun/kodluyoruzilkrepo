using System;
namespace  oop_1
{
    // public sealed class  Canlilar
    // sealed olursa kalıtım veremez
    public  class  Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Calilar beslenir");
        }

        protected void Solunum()
        {
            Console.WriteLine("Calilar solunum apar");
        }
        
        protected void Bosaltim()
        {
            Console.WriteLine("Calılar boşaltım yapar");
        }

        //Polymorphism
        //Virtual
        public virtual void UyaranlaraTepki()
        {
            Console.WriteLine("Canlılar uyaranlara tepki verir");
        }
    }
}