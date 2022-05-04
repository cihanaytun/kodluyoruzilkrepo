using System;
namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayi giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş oldugunuz sayi : " + sayi);
            }
            catch(Exception ex)
            {
                Console.WriteLine("hata : " + ex.Message.ToString());
            }
            finally // hata olsun olmasın çalışmasını istediğimiz kodalar yazılır
            {
                Console.WriteLine("İslem tamamlandi!");
            }



            
            try
            {
                //int a =int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-2000000000000");
            }
            catch (ArgumentNullException ex) // paranetre null
            {
                Console.WriteLine("Bos deger girdiniz");
                Console.WriteLine(ex);
            }
            catch(FormatException ex) //parametre tipi uygun değil
            {
                Console.WriteLine("veri tipi uygun degil !");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex) // parametre ile gelen değer çok büyük veya çok küçük
            {
                Console.WriteLine("Deger araligi hatali");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("Islem basari ile tamamlandi");
            }

        }
    }
}