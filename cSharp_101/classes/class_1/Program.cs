using System;

namespace class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //söz Dizimi
            //class SinifAdi
            //{
            //  [Erişim belirleyici] [Veri tipi] OzellikAdi;
            //  [Erişim belirleyici] [Geri dönüş tipi] MetotAdi([Parametre Listesi])
            //  {
            //      Metot Komutlari
            //  }
            //}


            // Erişim Belirleyiciler
            // * Public --> heryerden erişilebilir
            // * Private --> sadece tanımlandığı sınıfiçerisinden erişilepilir 
            // * Internal --> tanımlandığı projede kullanılabilir
            // * Protected --> tanımlandığı sınıf yada kalıtımını aldığı sınıftan erişilebilir


 
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Cihan";
            calisan1.Soyad = "Aytun";
            calisan1.No = 343434;
            calisan1.Departman = "Development";
            calisan1.CalisanBilgileri();

            Console.WriteLine("******************");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Test";
            calisan2.Soyad = "Çalisan";
            calisan2.No = 123456;
            calisan2.Departman = "Tester";
            calisan2.CalisanBilgileri();


        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;




 

        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalisan Adi :{0}",Ad);
            Console.WriteLine("Çalisan Soyadi :{0}",Soyad);
            Console.WriteLine("Çalisan No :{0}",No);
            Console.WriteLine("Çalisan Departmani :{0}",Departman);
        }
    }
}