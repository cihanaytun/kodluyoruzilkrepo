/*

Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)

Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

*/



using System;
using System.Collections;

namespace soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList asalOlan = new ();
            ArrayList asalOlmayan = new ();
            double asalToplam = 0;
            double asalOlmayanToplam = 0;
            
            Console.WriteLine("****** Lütfen sayi girin ******");

            for (int i = 0; i <20; i++)
            {
                Tekrar: 
                Console.Write("{0}.sayi :",i+1);
                string sayi=Console.ReadLine();
                int sayac = 0;
                int s;
                
                if (!int.TryParse(sayi,out s))
                {                
                    Console.WriteLine("Metinsel bir ifade ya da karakter giremezsiniz. ");   
                    goto Tekrar;
                }
                else
                {  
                    int sayi2 =int.Parse(sayi);
                    if (s < 0 || s == 0)
                    {
                        Console.WriteLine("Negatif bir değer giremezsiniz.");
                        goto Tekrar;
                    }
                    else 
                    {
                        for (int j = 2; j < sayi2; j++)
                        {
                            if (sayi2 % j == 0)
                            {
                                sayac++;
                            }  
                        }
                        if (sayac != 0 || sayi2 ==1)
                        {
                            asalOlmayan.Add(sayi2);
                        }
                        else 
                        {
                            asalOlan.Add(sayi2);
                        }
                        
                    }
                }    
            }
            Console.WriteLine(" Asal olan sayi adedi : "+asalOlan.Count);
            Console.WriteLine(" Asal olmayan sayi adedi : "+asalOlmayan.Count);


            foreach (var item in asalOlan)
            {
                asalToplam += (int)item;
            }
            Console.WriteLine(" Asal olan sayilarin ortalamasi : "+asalToplam/asalOlan.Count);
            foreach (var item in asalOlmayan)
            {
                asalOlmayanToplam +=(int)item;
            }
            Console.WriteLine(" Asal olmayan sayilarin ortalamasi : "+asalOlmayanToplam/asalOlmayan.Count);

        }
    }
}