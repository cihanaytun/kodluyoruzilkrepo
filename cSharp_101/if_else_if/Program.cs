using System;

namespace if_else_if
{
    class Program
    {
        public static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Gunaydin!" + " " + time);               
            }
            else if (time <= 18)
            {
                Console.WriteLine("Iyi Gunler!" + " " + time);
            }
            else
            {
                Console.WriteLine("Iyi Geceler!" + " " + time);
            }


            //Ternary If

            string sonuc = time <= 18 ? "Iyi Gunler!" : "Iyi Geceler!";
            sonuc = time >= 6 && time < 11 ? "Gunaydin!" : time <= 18 ? "Iyi Gunler!" :"Iyi Geceler!";
            Console.WriteLine(sonuc);
        }
    }
}