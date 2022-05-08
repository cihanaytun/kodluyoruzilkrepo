using System;
namespace donguler_while_foreach
{
    class Program{
        static void Main(string[] args)
        {
            //While 
            //1 den başlayarak console dan girilen sayıya kadar ortalama hesaplayıp console yazdırma,
            Console.WriteLine(" ****** 1 den başlayarak console dan girilen sayıya kadar ortalama hesaplayıp console yazdırma ****** ");
            Console.Write("Lütfen bir sayi giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplma = 0;
            while (sayac <= sayi)
            {
                toplma += sayac;
                sayac++;
            }  
            Console.WriteLine("Ortalama :  " + toplma/sayi);

            // a dan z ye kadar tüm harfleri console yadırma
            Console.WriteLine(" ****** a dan z ye kadar tüm harfleri console yadırma ****** ");
            char character = 'a';
            while (character <= 'z')
            {
                Console.Write(character +" ");
                character++;
            }


            // Foreach
            Console.WriteLine(" ****** Foreach ****** ");
            string[] arabalar ={"BMW","Mercedes","Volkswagen","Audi"};

            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }


        }
    }
}