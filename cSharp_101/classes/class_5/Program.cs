using System;

namespace class_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct(Yapı) Kavramı  

            //class  alan hesabı
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı :{0}",dikdortgen.AlanHesapla()); 
            
            
            //class  alan hesabı
            //Dikdortgen_Struct dikdortgen_struct; Böylede tanımlanabilir
            Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct();
            dikdortgen_struct.KisaKenar = 3;
            dikdortgen_struct.UzunKenar = 4;
            Console.WriteLine("Struct Alan Hesabı :{0}",dikdortgen.AlanHesapla()); 
        }
    }



    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }


    //Struct
    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }       
    }
}