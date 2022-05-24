using System;
using System.Collections;

namespace koleksiyonlar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrayList
            //system.Collections namespace

            ArrayList liste = new ();
            /*liste.Add("Cihan");
            liste.Add(5);
            liste.Add(true);
            liste.Add('C');
            */
            //içerisindeki verilere erişim
           // Console.WriteLine(liste[1]);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }



            //AddRange
            //birden fazla elemanı toplu halde ekleme
            Console.WriteLine("****** AddRange ******");
            //string[] renkler = {"kırmızı","sarı","mavi"};
            List<int> sayilar = new List<int>(){5,9,50,19,1,105,3};
            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);               
            }
 

            //Sort
            Console.WriteLine("****** Sort ******");
            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);               
            }  


            // Binary Search          
            Console.WriteLine("****** Binary Search ******");
            Console.WriteLine(liste.BinarySearch(19));
        
        
        
            //Reverse
            Console.WriteLine("****** Reverse ******");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);               
            }             


            //Clear
            Console.WriteLine("****** Clear ******");
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);               
            }         
        
        
        
        
        
        
        }
    }
}