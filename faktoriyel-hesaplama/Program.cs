using System;

namespace faktoriyelhesaplama
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            basadon:
            Console.WriteLine("Sayıyı Giriniz");
            int number = Convert.ToInt32(Console.ReadLine());
            int carpim=1;
            for (int i = 1; i <= number; i++)
            {
                carpim = carpim * i;
            }
            Console.WriteLine(carpim);
            basadon1:
            Console.WriteLine("1-Yeniden Faktöriyel Hesapla");
            Console.WriteLine("2-Çık");
            char secim = Convert.ToChar(Console.ReadLine());
            if (secim == '1')
            {
                Console.Clear();
                goto basadon;
            }
            else if (secim == '2')
                Environment.Exit(0);
            else
            {
                Console.Clear();
                Console.WriteLine("Hatalı Seçim");
                goto basadon1;
            }
        }
    }
}