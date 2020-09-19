using System;

namespace proje1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            basadon:
            Console.WriteLine("1.Sayıyı Giriniz");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Giriniz");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.Sayıyı Giriniz");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int comparison1 = Math.Min(number1, number2);
            int comparison2 = Math.Min(comparison1, number3);
            int comparison3 = Math.Max(number1, number2);
            int comparison4 = Math.Max(comparison3, number3);
            if (number1 == number2 || number2 == number3 || number1 == number3)
            {
                Console.Clear();
                Console.WriteLine("Her Sayı Farklı Olmaldır");
                goto basadon;

            }
            else
            {
                Console.WriteLine("Girdiğiniz Sayılardan En Büyüğü = " + comparison4 + "  " + "Girdiğiniz Sayıların En Küçüğü = " + comparison2);
                Console.WriteLine("Sayıları Toplamı = " + (comparison2 + comparison4));
            }
        }
    }
}