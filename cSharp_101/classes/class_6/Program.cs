using System;

namespace class_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enumlar
            Console.WriteLine(Gunler.Pazar);//string değerini veriyor
            Console.WriteLine((int)Gunler.Cumartesi);//indis değerini yada kendi vermiş olduğumuz değeri getiriyor 


            int sicaklik = 32;
            if (sicaklik <= (int)HavaDurumu.CokSicak)
            {
                Console.WriteLine("Hava çok sıcak");
            }
            else if (sicaklik >= (int)HavaDurumu.Sicak)
            {
                Console.WriteLine("Hava sıcak");
            }
            else if (sicaklik >= (int)HavaDurumu.Normal && sicaklik < (int)HavaDurumu.CokSicak)
            {
                Console.WriteLine("Hava iyi");                
            }
        }
    }

    // indis numaraları 0 dan başlar,sıralıdır
    enum Gunler
    {
        Pazartesi = 1,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }


    enum HavaDurumu
    {
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30

    }
}