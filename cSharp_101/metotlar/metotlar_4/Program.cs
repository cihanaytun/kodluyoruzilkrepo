using System;

namespace metotlar_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // HAZIR STRİNG METOTLAR
            
            string degisken = "Dersimiz CSharp,Hoşgeldiniz!";
            string degisken2 = "dersimiz CSharp";

 

            //Lenght -----> uzunluğu verir
            Console.WriteLine(degisken.Length);


            //ToUpper , ToLover -----> büyük,küçük
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());


            //Concat -----> birleştirir
            Console.WriteLine(string.Concat(degisken,"Merhaba"));


            //Compare , CompareTo 
            /*   
                karşılaştırma yapar uzunluk aynıysa 0 döner.
                degisken, değişken2 den uzunsa 1 döner.
                değişken,değişken2 den kısa ise -1 döner
            */
            Console.WriteLine(degisken.CompareTo(degisken2)); //0, 1, -1
            Console.WriteLine(String.Compare(degisken,degisken2,true));//ignoreCase durumu true ise büyük küçük harf duyarlı olur
            Console.WriteLine(String.Compare(degisken,degisken2,false));
           

            //Constains 
            /*
            Contains() anahtar sözcüğü koleksiyonda bulunan verilerin, belirlenen koşula göre olup olmadığını kontrol ede
            */
            Console.WriteLine(degisken.Contains(degisken2));


            //Start,EndsWith
            /*
            EndsWith-StartsWith: Bir string'in ne ile bittiğini/başladığını bulmak için kullanılır.
            */
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));


            //IndexOf 
            Console.WriteLine("CS");//ilk bulduğu harfin index numarasını verir
            Console.WriteLine("Cihan");//bulamadığında '-1' döner   
           
            //LastIndexOf
            Console.WriteLine(degisken.LastIndexOf("i"));//son index numarasını döndürür


            //Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba!")); //0 indexten başlayıp yazıyı ekeyecek


            //PadLeft ,PedRight
            Console.WriteLine(degisken + degisken2.PadLeft(30));
            Console.WriteLine(degisken + degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50) + degisken2);
            Console.WriteLine(degisken.PadRight(50,'-') + degisken2);


            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));
         

            //Replace
            Console.WriteLine(degisken.Replace("CSharp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));


            //Split
            //boşluklara göre parçalar
            Console.WriteLine(degisken.Split(' ')[1]);


            //Substring
            Console.WriteLine(degisken.Substring(4));//4 indexten başlayıp sonuna kadar getiri
            Console.WriteLine(degisken.Substring(4,6));//4 indexten başlayıp 6 karakter  getiri


        }
    }
}