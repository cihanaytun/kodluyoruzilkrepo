using System;

namespace kolseksiyon_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generic List
            //List<T> class
            //System.Collections.Generic
            //T --> object türündedir (generic olduğunu belirtir)

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(56);
            sayiListesi.Add(5);
            sayiListesi.Add(109);
            sayiListesi.Add(87);
            sayiListesi.Add(9);


            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Yeşil");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");



            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);



            Console.WriteLine("******************************");
            // Foreach ve List.Foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk  in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi)); //foreach farklı kullanımı
            renkListesi.ForEach(renk => Console.WriteLine(renk));



            // Listeden eleman çıkarma
            Console.WriteLine("******************************");
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);//indis numarası ile eleman silmek için
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));           



            // Liste içerisinde arama
            Console.WriteLine("******************************");
            if (sayiListesi.Contains(109))//aramak için constains
            {
                Console.WriteLine("10 liste içerisinde bulundu");
            }
            else
            {
                Console.WriteLine("10 liste içerisinde bulunamadı");               
            }



            //Eleman ile indis'e erişme
            Console.WriteLine("******************************");           
            Console.WriteLine(renkListesi.BinarySearch("turuncu"));



            // Diziyi List'e çevirme
            Console.WriteLine("******************************");           
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};      
            List<string> hayvanListesi = new List<string>(hayvanlar);     


            
            // Listeyi temizleme
            hayvanListesi.Clear();



            // List içerisinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Ad = "Cihan";
            kullanici1.Soyad = "Aytun";
            kullanici1.Yas = 1;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici1.Ad = "XXXX";
            kullanici1.Soyad = "XXXX";
            kullanici1.Yas = 3;


            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            //farklı şeklide ekleme yapma
            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar{
                Ad = "Cihan",
                Soyad = "Aytun",
                Yas = 1
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanici adı :" + kullanici.Ad);
                Console.WriteLine("Kullanici soyadı :" + kullanici.Soyad);
                Console.WriteLine("Kullanici yaşı :" + kullanici.Yas);  
            }

            yeniListe.Clear();


        }
    }

    public class Kullanicilar
    {
        string ad; // private olur
        string soyad;
        int yas;

        public string Ad { get => ad; set => ad = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int Yas { get => yas; set => yas = value; }
    }


}