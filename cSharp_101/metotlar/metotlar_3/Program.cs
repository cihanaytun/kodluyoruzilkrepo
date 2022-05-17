using System;

namespace metotlar_3
{
    class Ptogrma
    {
        static void Main(string[] args)
        {
            //Reküsif - Öz yinelemeli  
            int result = 1;
            for (int i = 1; i < 5; i++)
            {
                result = result * 3;
            }
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine("Reküsif üs alma  : " + instance.Expo(3,4));            
            Console.WriteLine("Reküsif faktoriyel " + instance.Faktoriyel(5));


            Console.WriteLine("*************************************");
            // Extension metotlar
            string ifade = "Cihan Aytun";
            bool sonuc = ifade.Checkspaces();
            if (sonuc)
            {
                Console.WriteLine(ifade.RemoveWhiteSpace());
            }
            //Console.WriteLine(ifade.ToLower().ToUpper()); 
            Console.WriteLine(ifade.MakeUpperCase());

            //Console.WriteLine(ifade.ToLower().ToLower()); 
            Console.WriteLine(ifade.MakeLOwerCase());


            Console.WriteLine("*************************************");
            int[] dizi = {0,9,-12,25,98,102,151,3,6,-6};
            Console.WriteLine("Sıralanmaış dizi");
            dizi.EkranaYazdir();

            Console.WriteLine("Sıralanmış dizi"); 
            dizi.SortArray();
            dizi.EkranaYazdir();

            Console.WriteLine("*************************************");
            int sayi = 10;
            Console.WriteLine(sayi.IsEvenNumber());

            Console.WriteLine(ifade.GetFirstCharacter());

        }
    }

    public class Islemler
    {
        //reküsif fonksiyon üs alma
        public int Expo(int sayi , int us)
        {
            if(us<2)
            {
                return sayi;
            }
            return Expo(sayi,us-1)*sayi;
        }

        // reküsif fonksiyon faktöriyel
        public int Faktoriyel(int sayi)
        {
            if (sayi<2)
            {
                return sayi;
            }
            return Faktoriyel(sayi-1)*sayi;
        }
    }

    public static class Extension
    {
        //Ekstension olması için static ve this eklmek azım
        public static bool Checkspaces(this string param)
        {
            return param.Contains(" ");
        }


        public static string RemoveWhiteSpace(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("",dizi);
        }


        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }


         public static string MakeLOwerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("");
        }


        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }


        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,1);
        }




    }
}
