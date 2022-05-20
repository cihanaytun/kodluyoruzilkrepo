
/*

Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

*/

using System;

namespace soru_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("LÜtfen bir cümle giriniz :");
            string cumle = Console.ReadLine();     
            string[] cumleSayisi = cumle.Split(' ');    
            Console.WriteLine("Cümle Sayısı :"+ cumleSayisi.Length);                



            //-------------------------------------------------
            string harfSayisi = cumle.Replace(" ","");
            int sayac = 0;

            for (int i = 0; i < harfSayisi.Length; i++)
            {
                sayac++;
            }
            Console.WriteLine("Cümledeki Harf Sayısı :"+sayac);
           
            



        }
    }
}