using System;

namespace diziler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //SORT
            int[] sayiDizisi = {77,26,2,69,156,1482,35,18};
            Console.WriteLine(" ****** sırasız Liste ******");
            foreach (int sayi in sayiDizisi)
            {
                Console.Write(sayi +" ");
            }
            Console.WriteLine("");
            Console.WriteLine(" ****** Sıralı Liste  ******");
            Array.Sort(sayiDizisi);//küçükten büyüğe
            foreach (int sayi in sayiDizisi)
            {
                Console.Write(sayi +" ");
            }

            //Clear
            Console.WriteLine("");
            Console.WriteLine(" ****** Array Clear  ******");
            Array.Clear(sayiDizisi,2,2);//2.indis dahil 2 tane değeri alıp 0 değerini atıyor
            foreach (int sayi in sayiDizisi)
            {
                Console.Write(sayi +" ");
            } 

            //Reverse (diziyi ters çevirir)
            Console.WriteLine("");
            Console.WriteLine(" ****** Array Reverse  ******");
            Array.Reverse(sayiDizisi);
            foreach (int sayi in sayiDizisi)
            {
                Console.Write(sayi +" ");
            } 

            //IndexOf (dizi içerisinde istenilen elamanın indisini döndürür)
            Console.WriteLine("");
            Console.WriteLine(" ****** Array IndexOf  ******");
            Console.Write(Array.IndexOf(sayiDizisi,69));


            //Resize (diziyi yeniden boyutlandırır)
            Console.WriteLine("");
            Console.WriteLine(" ****** Array Resize ******");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=88;
            foreach (int sayi in sayiDizisi)
            {
                Console.Write(sayi +" ");
            } 



        }
    }
}