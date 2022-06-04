using System;
namespace  oop_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance

            //                           Canlılar
            //                              |
            //          Bitkiler                        Hayvanlar
            //         |        |                    |             |
            //     Tohumlu    Tohumsuz          Sürüngenler     Kuslar            




            TohumluBitkiler tohumluBitki = new();
            tohumluBitki.TohumlaCogalma();
            /*
            tohumluBitki.Beslenme();
            tohumluBitki.Solunum();
            tohumluBitki.Bosaltim();
            tohumluBitki.FotosentezYapmak();
            tohumluBitki.TohumlaCogalma();
            */
            Console.WriteLine("*****************");

            Kuslar kus =new();
            kus.Ucmak();
            /*
            kus.Solunum();
            kus.Beslenme();
            kus.Bosaltim();
            kus.Adaptasyon();
            kus.Ucmak();
            */

        }
    }
}