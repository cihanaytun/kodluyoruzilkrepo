/*

SORU_1

Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

*/

using System;
namespace odev_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Kaç adet sayi gireceksiniz : ");
            int sayac = Convert.ToInt32(Console.ReadLine());
            
            int[] sayiDizisi=new int[sayac];

            for (int i = 0; i < sayac; i++)
            {
                Console.Write("{0}.sayiyi girin : ",(i+1));
                int sayi = Convert.ToInt32(Console.ReadLine());
                sayiDizisi[i]= sayi;
            }

            Console.WriteLine("****** Çift olan sayilar ******");
            foreach (int item in sayiDizisi)
            {
                if (item %2 == 0)
                {
                    Console.Write(item + " ");
                }  
            }
        }
    }
}