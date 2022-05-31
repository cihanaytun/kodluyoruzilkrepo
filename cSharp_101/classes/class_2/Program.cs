using System;

namespace class_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constractor
            //Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.

            Console.WriteLine("****** Çalişan 1 ******");
            Calisan calisan1 = new Calisan("Cihan","Aytun",343434,"Development");
            calisan1.CalisanBilgileri();


            Console.WriteLine("****** Çalişan 2 ******");            
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Test";
            calisan2.Soyad = "Çalisan";
            calisan2.No = 123456;
            calisan2.Departman = "Tester";
            calisan2.CalisanBilgileri();

            
            Console.WriteLine("****** Çalişan 3 ******");
            Calisan calisan3 = new Calisan("Chn","Ayt");
            calisan3.CalisanBilgileri();

        }

    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;


        //Constructor(Yapıcı Method) --> İsmi class ile aynı olmak zorunda ve public olmak zorunda 
        //Overload(aşırı yükleme) yapılabilir
        public Calisan(string ad,string soyad,int no,string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        //Overload
        public Calisan(){}

        //Overload
        public Calisan(string ad,string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }



        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalisan Adi :{0}",Ad);
            Console.WriteLine("Çalisan Soyadi :{0}",Soyad);
            Console.WriteLine("Çalisan No :{0}",No);
            Console.WriteLine("Çalisan Departmani :{0}",Departman);
        }
    }

}