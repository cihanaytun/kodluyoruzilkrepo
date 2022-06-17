using System;

namespace RehberUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Telefon Rehberi Uygulamasına Hoşgeldiniz!");

           PersonTransactions personTransactions = new PersonTransactions();
           string devam="";
           
           while (devam != "exit")
           {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)  \nProgramdan Çıkış için 'exit' giriniz");
                System.Console.WriteLine("*******************************************");
                System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
                System.Console.WriteLine("(2) Varolan Numarayı Silmek");
                System.Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                System.Console.WriteLine("(4) Rehberi Listelemek");
                System.Console.WriteLine("(5) Rehberde Arama Yapmak");       
                devam = Console.ReadLine();     


                switch (devam)
                {
                    case "1":
                        personTransactions.AddPerson();
                        break;
                    case "2":
                        personTransactions.RemoveNumber();
                        break;
                    case "3":
                        personTransactions.UpdateNumber();
                        break;
                    case "4":
                        personTransactions.PersonList();
                        break;
                    case "5":
                        personTransactions.SerachPerson();
                        break;
                    case "exit": break;
                    default:
                        System.Console.WriteLine("1-5 arası program seçiniz ya da exit ile çıkınız.");
                        break;
                }
           } 
        }
    }
}