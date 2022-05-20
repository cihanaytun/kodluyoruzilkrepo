/*

Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

*/
using System;

namespace soru_3
{
    class Program
    {
        static void Main (string[] args)
        {
            int sayac;
            Console.Write("Kaç adet kelime gireceksiniz :");
            sayac = Convert.ToInt32(Console.ReadLine());

            string[] kelimeDizisi = new string[sayac];

            for (int i = 0; i < sayac; i++)
            {
                Console.Write("{0}.kelimeyi girin : ",(i+1));
                string kelime = Console.ReadLine();
                kelimeDizisi[i]= kelime;
            }
            
            Console.WriteLine("Kelimelerin sıralanmamış hali");
            foreach (var item in kelimeDizisi)
            {
                Console.Write(item + " ");
            }
            
            Console.WriteLine(" ");
            Console.WriteLine("Kelimelerin sıralanmış hali");
            Array.Reverse(kelimeDizisi);
            foreach (var item in kelimeDizisi)
            {
                Console.Write(item + " ");
            }


        }
    }
}
