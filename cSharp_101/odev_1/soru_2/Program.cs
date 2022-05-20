/*

Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

*/


using System;

namespace soru_2
{
    class Program
    {

        static void Main(string[] args)
        {

            int sayi1,sayi2,sayac;
            Console.WriteLine("2 adet sayi giriniz  ");

            Console.Write("1. Sayi : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            sayac = sayi1;

            Console.Write("2. Sayi : ");
            sayi2 = Convert.ToInt32(Console.ReadLine());
            

            int[] sayiDizisi=new int[sayac];

            for (int i = 0; i < sayac; i++)
            {
                Console.Write("{0}.sayiyi girin : ",(i+1));
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayiDizisi[i]= sayi;
            }
            
            
            Console.WriteLine("2.sayiya eşit veya tam bülünen sayilar");
            foreach (int item in sayiDizisi)
            {
                if (item==sayi2 || item % sayi2 == 0 )
                {
                    Console.Write(item + " ");
                } 

            }
        
    

        }

    }
}
