using System;

namespace swith_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            
            //Expression - Kontrol koşulu
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak ayi");
                    break;
                case 2:
                    Console.WriteLine("Subat ayi");
                    break;
                case 4:
                    Console.WriteLine("Nisan ayi");
                    break;                
                case 3:
                    Console.WriteLine("Mart ayi");
                    break;
                 case 5:
                    Console.WriteLine("Mayis ayi");
                    break;                
                default:
                    Console.WriteLine("Yanlis veri girisi");
                    break;
            }



            //Çoklu case 
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Kis mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Ilkbahar mevsimi");
                    break;                   
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz mevsimi");
                    break;                
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar mevsimi");
                    break;                    
                default:
                    break;
            }
        }
    }
}