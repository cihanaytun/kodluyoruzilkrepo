/*

Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

*/



using System;
namespace soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char>sesliHarfler = new List<char>{'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü'};
            List<char> sesliHarfListesi=new List<char>();
            Console.Write("Metin giriniz : ");
            string metin = Console.ReadLine();

            for (int i = 0; i < sesliHarfler.Count; i++)
            {
                for (int j = 0; j < metin.Length; j++)
                {
                    if (metin[j] == sesliHarfler[i])
                    {
                        sesliHarfListesi.Add(metin[j]);
                    }
                }
            }
            
            foreach (var item in sesliHarfListesi)
            {
                Console.WriteLine(item);
            }
        }
    }
}