using System;

namespace metotlar_5
{

    class Program
    {
        static void Main(string[] args)
        {
            // Hazır Datetime ve math metotları

            //Datetime Kütüphanesi
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.Millisecond);

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString);
            Console.WriteLine(DateTime.Now.ToShortDateString);
         
            Console.WriteLine(DateTime.Now.ToLongTimeString);
            Console.WriteLine(DateTime.Now.ToShortTimeString);

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(4));
            Console.WriteLine(DateTime.Now.AddSeconds(50));
            Console.WriteLine(DateTime.Now.AddMonths(2));
            Console.WriteLine(DateTime.Now.AddYears(16));
            Console.WriteLine(DateTime.Now.AddMilliseconds(180));

            //Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//gün sayısal olarak
            Console.WriteLine(DateTime.Now.ToString("ddd"));//gün kısaltılmış olarak
            Console.WriteLine(DateTime.Now.ToString("dddd"));//gün tam ad olarak
           
            Console.WriteLine(DateTime.Now.ToString("MM"));//ay sayısal olarak
            Console.WriteLine(DateTime.Now.ToString("MMM"));//ay kısaltılmış olarak
            Console.WriteLine(DateTime.Now.ToString("MMMM"));//ay tam ad olarak

            Console.WriteLine(DateTime.Now.ToString("yy"));//yıl kısaltılmış olarak
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//yıl tam ad olarak

            //---------------------------------------------------------------------------------
            Console.WriteLine("*****************************************"); 
            // Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));//25 eksi değerleri + ya çevirir
            Console.WriteLine(Math.Sin(10));//sinüs
            Console.WriteLine(Math.Cos(10));//cosinüs
            Console.WriteLine(Math.Tan(10));//tanjant

            Console.WriteLine(Math.Ceiling(10.2));//yukarı yuvarlar  11
            Console.WriteLine(Math.Round(10.4));//yakın olana yuvarlar 10
            Console.WriteLine(Math.Round(10.6));//yakın olana yuvarlar 11
            Console.WriteLine(Math.Floor(10.9));//aşşağı yuvarlar 10


            Console.WriteLine(Math.Max(2,6));
            Console.WriteLine(Math.Min(2,6));

            Console.WriteLine(Math.Pow(3,4));// üs alır 3^4 ü verir = 81
            Console.WriteLine(Math.Sqrt(9));// karekök alır 
            Console.WriteLine(Math.Log(9));//logoritma , 9 un e tabanındaki logoritmik karşılığı
            Console.WriteLine(Math.Exp(3));//e üzeri 3 ü verir
            Console.WriteLine(Math.Log10(10));// 10 sayısının logoritma 10 tabanındaki karşılığı




            
        }
    }
}