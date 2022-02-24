using System;

namespace String_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Now ile
            // Sadece Ay , Yıl , Gün , Saati yazdırmak için
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);

            // Now.Add ile
            // İleri bir gün yazdırmak için
            Console.WriteLine(DateTime.Now.AddDays(2));
            // İleri bir ay yazdırmak için
            Console.WriteLine(DateTime.Now.AddMonths(3));
            // İleri bir yıl yazdırmak için
            Console.WriteLine(DateTime.Now.AddYears(5));
            // İleri bir saniye yazdırmak için
            Console.WriteLine(DateTime.Now.AddSeconds(50));
            // İleri bir saat yazdırmak için
            Console.WriteLine(DateTime.Now.AddHours(50));

            // DateTime Format
            Console.WriteLine(DateTime.Now.ToString("yy"));
            Console.WriteLine(DateTime.Now.ToString("yyyy"));
            Console.WriteLine(DateTime.Now.ToString("dd"));
            Console.WriteLine(DateTime.Now.ToString("ddd"));
            Console.WriteLine(DateTime.Now.ToString("dddd"));
            Console.WriteLine(DateTime.Now.ToString("MM"));
            Console.WriteLine(DateTime.Now.ToString("MMMM"));

            // DayOf 
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            // ToLong ve ToShort // Time
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            // ToLong ve ToShort // Date
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongDateString());

            Console.WriteLine("*****************************Math Kütüphanesi**************************************");

            // Math Kütüphanesi
            Console.WriteLine(Math.Abs(-266)); // Mutlak Değerini Verir.
            Console.WriteLine(Math.Sin(10)); // Sinüsünü verir.
            Console.WriteLine(Math.Cos(66)); // Cosinüsünü verir.
            Console.WriteLine(Math.Tan(6)); // Tanjantını verir.


            Console.WriteLine(Math.Ceiling(10.2)); // 10.2 den büyük en küçük tam sayıyı yazar.
            Console.WriteLine(Math.Round(10.5)); // Hangi tam sayıya daha yakınsa onu yazar.
            Console.WriteLine(Math.Floor(10.2)); // 10.2 den küçük en büyük tam sayıyı yazar.

            Console.WriteLine(Math.Max(2,5));
            Console.WriteLine(Math.Min(2, 5));

            Console.WriteLine(Math.Pow(2,3)); // 2 üzeri 3 ün değerini verir.
            Console.WriteLine(Math.Sqrt(9)); //Karekökünü verir.
            Console.WriteLine(Math.Log(13)); //Logaritma işlemini yapar.
            Console.WriteLine(Math.Exp(4)); // e üzeri 4 ü verir.
            Console.WriteLine(Math.Log10(3)); // Logaritma 10 tabanındaki karşılığını verir.













        }
    }
}
