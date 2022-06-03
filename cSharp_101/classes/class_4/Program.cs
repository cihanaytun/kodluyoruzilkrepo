using System;
namespace class_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static Sınıf ve Üyeler
            //Not : static sınıf üyelereine sınıf adı ile ulaşılabilir .nesne oluşturup onun ile de ulaşılamaz
            //Not : static sınıf üyelereine sınıf adı ile ulaşılabilir .nesne oluşturup onun ile de ulaşılamaz

            Console.WriteLine("Çalişan sayisi : {0}",Calisan.Calisansayisi);

            Calisan calisan =new Calisan("Cihan","Aytun","Development");
            Console.WriteLine("Çalişan sayisi : {0}",Calisan.Calisansayisi);

            Calisan calisan1 =new Calisan("aytun","Cihan","Backend");
            Calisan calisan2 =new Calisan("Test","User","Frontend");
            Console.WriteLine("Çalişan sayisi : {0}",Calisan.Calisansayisi);


            Console.WriteLine("Toplama işlemi sonucu : {0}", Islemler.Topla(100,200));
            Console.WriteLine("Çıkarma işlemi sonucu : {0}", Islemler.Cikar(450,250));

        }
    }

    //static üyler
    class Calisan
    {
        private static int calisansayisi;

        public static int Calisansayisi { get => calisansayisi;/* set => Calisansayisi = value;*/ }
    

        private string Isim;
        private string Soyisim;
        private string Departman;

        //static constructor
        static Calisan()
        {
            calisansayisi=0;
        }



        //constructor
        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisansayisi ++;
        }

    }




    // static class(tü üyeleri static olur.olmalı)

    static class Islemler
    {
        public static long Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1,int sayi2)
        {
            return sayi1 - sayi2;
        }
    }


}