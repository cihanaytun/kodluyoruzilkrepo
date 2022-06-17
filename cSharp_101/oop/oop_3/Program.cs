using System;

namespace oop_3
{
    class Program
    {
        static void Main(string[] args)
        {
         //abstract class   

         NewMegane megane = new NewMegane();
         Console.WriteLine(megane.Markasi().ToString());
         Console.WriteLine(megane.TekerSayisi().ToString());
         Console.WriteLine(megane.Rengi().ToString());


        Console.WriteLine("**************************");         
         NewCorolla corolla = new NewCorolla();
         Console.WriteLine(corolla.Markasi().ToString());
         Console.WriteLine(corolla.TekerSayisi().ToString());
         Console.WriteLine(corolla.Rengi().ToString());
        
        }

    }
}