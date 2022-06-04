using System;

namespace  oop_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance Example

            Mondeo mondeo = new Mondeo();
            Console.WriteLine(mondeo.Markasi().ToString());
            Console.WriteLine(mondeo.Rengi().ToString());
            Console.WriteLine(mondeo.TekerSayisi().ToString());
            Console.WriteLine("******************************");


            Passat passat = new Passat();
            Console.WriteLine(passat.Markasi().ToString());
            Console.WriteLine(passat.Rengi().ToString());
            Console.WriteLine(passat.TekerSayisi().ToString());
            Console.WriteLine("******************************");


            Megane megane = new Megane();
            Console.WriteLine(megane.Markasi().ToString());
            Console.WriteLine(megane.Rengi().ToString());
            Console.WriteLine(megane.TekerSayisi().ToString());
            Console.WriteLine("******************************");

            
            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.Markasi().ToString());
            Console.WriteLine(corolla.Rengi().ToString());
            Console.WriteLine(corolla.TekerSayisi().ToString());


        }
    }
}
