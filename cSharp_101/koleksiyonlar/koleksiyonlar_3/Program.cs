using System;

namespace koleksiyonlar_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary
            //key ve value 
            //System.Collection.Generic
            //key ler unique olamlı
            Dictionary<int,string> kullanicilar = new Dictionary<int, string>();//int --> key | string --> value
            kullanicilar.Add(10,"Cihan Aytun");
            kullanicilar.Add(12,"Aytun");
            kullanicilar.Add(19,"Cihan ");
            kullanicilar.Add(23,"Aytun Cihan ");


            //Dizi elemanlarına erişim
            Console.WriteLine("******  Elemanlara erişim ******");
            Console.WriteLine(kullanicilar[12]);//key ile eriştik
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }


            //Count
            Console.WriteLine("******  Count ******");
            Console.WriteLine(kullanicilar.Count());


            //Constains
            Console.WriteLine("******  Constains ******");        
            Console.WriteLine(kullanicilar.ContainsKey(12));//12 keyine sahip değer varmı bakar
            Console.WriteLine(kullanicilar.ContainsValue("Chn"));//chn valusuna sahip değer varmı bakar
            

            //Remove
            Console.WriteLine("******  Remove ******");        
            kullanicilar.Remove(12);//key istiyor
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
                //Console.WriteLine(item.Key);
                //Console.WriteLine(item.Value);

            }



            //Keys
            Console.WriteLine("******  Keys ******");        
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }

            
            //Values
            Console.WriteLine("******  Values ******");        
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }


        }
    }
}