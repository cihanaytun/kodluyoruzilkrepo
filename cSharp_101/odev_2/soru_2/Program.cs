/*

Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, 
her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
(Array sınıfını kullanarak yazınız.)

*/



using System;
namespace soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = new int[20];

            Console.WriteLine("Lütfen sayi giriniz : ");
            for (int i = 0; i < 20; i++)
            {
                Console.Write("{0}.inci sayi : ",i+1);
                inputArray[i] =int.Parse(Console.ReadLine());
            }
            Array.Sort(inputArray);

            int kucuk=(inputArray[0]+inputArray[1]+inputArray[2])/3;
            int buyuk=(inputArray[17]+inputArray[18]+inputArray[19])/3;
            int sonuc=kucuk+buyuk;
            Console.WriteLine("En kucuk 3 sayi ortalamasi : "+ kucuk);
            Console.WriteLine("En buyuk 3 sayi ortalamasi : "+ buyuk);
            Console.WriteLine("Ortalama toplamlari : "+ sonuc);




              
           
     
            



        }
    }
}