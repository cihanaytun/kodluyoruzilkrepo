using System;

namespace metotlar_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Out Parametreler ---> Bir işlem sonucu çıkan değeri setlemek istersek ve setlenmiş değeri kullanmak için out parametre olarak verilebilir

            string sayi = "999"; 
            int outSayi;

            // ool sonuc = int.TryParse(sayi, out int outSayi);
            bool sonuc = int.TryParse(sayi, out outSayi);
            if (sonuc == true)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }


            Console.WriteLine("***********************************");
            Metotlar instance = new Metotlar();
            instance.Topla(2,3,out int toplamsonucu);
            Console.WriteLine(toplamsonucu);




        // Metotlar Overloading(Aşırı yükeleme)
        
        int ifade = 999;
        instance.EkranaYazdir(Convert.ToString(ifade)); 

        Console.WriteLine("------ Overloading Hali ------");
        instance.EkranaYazdir(ifade);



        instance.EkranaYazdir("Cihan " + "Aytun");
        
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        // Metot imzası ------------> metot_adı + parametre_sayısı + parametre
        // Overloading metot
        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);           
        }
        

        public void EkranaYazdir(string veri1,string veri2)
        {
            Console.WriteLine(veri1 + veri2);           
        }
    }
}