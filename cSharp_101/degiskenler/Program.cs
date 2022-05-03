using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int deger = 6;
            string degisken = null;
            string Deegisken = null;
            Console.WriteLine(deger);
            */

            byte b = 5;             //0-255 arası 1 byte
            sbyte sb = 3;           //-127 - +127 arası 1 byte

            short s = 5;            //2 byte
            ushort us = 5;          //0-65365 arası 2 byte

            Int16 i16 = 2;          //2 byte 
            int i = 2;              //4 byte
            Int32 i32 = 2;          //4 byte
            Int64 i64 = 2;          // 8 byte  
            uint ui = 2;            // 4 byte

            long l = 4;             // 8 byte
            ulong ul = 4;           // 8 byte      

            // reel sayılar
            float f = 5;            //4 byte 
            double d = 5;           //8 byte
            decimal de = 5;         // 16 byte

            char ch = '2';          //2 byte
            string str = "Cihan";   // sınırsız

            bool bl = true;         // 1 byte
            bool bl2 = false;       // 1 byte

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);


            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.5;


            //string ifadeler tanımlama
            string str1 = string.Empty;
            str1 = "Cihan Aytun";
            string ad = "Cihan";
            string soyad = "Aytun";
            string tamIsim = ad + " " + soyad;


            //Intager ifadeler tanımlama
            int intager1 = 5;
            int intager2 = 3;
            int intager3 = intager1 * intager2;


            //Bool ifadeler tanımlama   
            bool bool1 = 10>2;//true döner
            bool bool2 = 10<2;//false döner



            //DEGISKEN DONUSUMLERI
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger);// çıktısı 2020

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);// çıktısı 40

            int int22 = int20 + int.Parse(str20);//Çıktısıs 40


            //Datetime
            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime1);
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);
            
            //saat
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);


        }
    }
}