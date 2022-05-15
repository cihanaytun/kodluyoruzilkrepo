using System;
namespace metotlar_1
{
    class Program
    {
        static void Main(string[] args)
        {
             //erişimBelirteci geriDonüşTipi  metotAdı(parametreler/argümanlar)
             //{
                 //komutlar
                 //return;
             //}


            int a = 2;
            int b = 3;
            Console.WriteLine(a+b);


            Console.WriteLine("***********************"); 
            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);


            Console.WriteLine("***********************");
            //Instance alma
            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));


            Console.WriteLine("***********************");
            int sonuc2 = ornek.ArttirveTopla(a,b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2)); 


            Console.WriteLine("****** Ref üstündden değer alma");
            int sonuc3 = ornek.RefArttirveTopla(ref  a,ref  b);
            ornek.EkranaYazdir(Convert.ToString(sonuc3));


        }

        
        static int Topla(int deger1,int deger2)
        {
            return (deger1 + deger2);
        }
    }


    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttirveTopla(int deger1,int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return (deger1 + deger2);
        }

        //ref anahtar sözcüğü ile bellekteki adreslere bakılıp değer ordan alınır.
        public int RefArttirveTopla(ref int deger1,ref int deger2)
        {
            deger1 += 1;
            deger2 += 1;
            return (deger1 + deger2);
        }
    }
}