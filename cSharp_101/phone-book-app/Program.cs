using System;
using phone_book_app;

namespace phone_bookj_app
{
    class Program
    {
static void Main(string[] args)
        {
           Console.WriteLine("Telefon Rehberi Uygulamasına Hoşgeldiniz!");

           PersonTransactions personTransactions = new PersonTransactions();
           
           string goOn="";
           
           while (goOn != "exit")
           {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)  \nProgramdan Çıkış için 'exit' giriniz");
                Console.WriteLine("*******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetmek");
                Console.WriteLine("(2) Varolan Numarayı Silmek");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listelemek");
                Console.WriteLine("(5) Rehberde Arama Yapmak");       
                goOn = Console.ReadLine();     


                switch (goOn)
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
                    case "exit":
                         break;
                    default:
                        System.Console.WriteLine("1-5 arası program seçiniz ya da exit ile çıkınız.");
                        break;
                        
                }
           } 
        }        
    }
}