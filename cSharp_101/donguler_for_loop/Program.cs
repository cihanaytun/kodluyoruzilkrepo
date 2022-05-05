using System;

namespace donguler_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console'dan girilen sayıya kadr olan tek sayıları ekrana yazdırma.");
            //Console'dan girilen sayıya kadr olan tek sayıları ekrana yazdırma.
            Console.WriteLine("Lutfen bir sayi giriniz : ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("1 - 1000 arası tek ve çift sayıların kendi içlerinde toplamlarını consola yazdırma.");
            //1 - 1000 arası tek ve çift sayıların kendi içlerinde toplamlarını consola yazdırma.
            int tekTop = 0;
            int ciftTop = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 2 == 1)
                {
                    tekTop += i;
                }
                else
                {
                    ciftTop += i;
                }
            }
            Console.WriteLine("Tek Toplam : " + tekTop );
            Console.WriteLine("Çift Toplam : " + ciftTop );

            
            //Break , Continue
            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }


            for (int i = 1; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

        }
    }
}