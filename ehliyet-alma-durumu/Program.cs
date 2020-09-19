using System;

namespace ehliyetalmadurumu
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            basadon:
            Console.WriteLine("Yaşınızı Yazınız");
            int yas = Convert.ToInt32(Console.ReadLine());
            if(yas >= 18)
            {
                Console.WriteLine("Ehliyet Alabilirsiniz");
                basadon1:
                Console.WriteLine("1-Yeni Sorgu");
                Console.WriteLine("2.Çık");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                    goto basadon;
                else if (secim == 2)
                    Environment.Exit(0);
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanlış Seçim");
                    goto basadon1;
                }
            }
            else if(yas < 18)
            {
                Console.WriteLine("Ehliyet Alamazsınız");
                int hesap = 18 - yas;
                Console.WriteLine("Ehliyet Almak İçin Gereken Süre = " + hesap+" "+"yıl");
                basadon2:
                Console.WriteLine("1-Yeni Sorgu");
                Console.WriteLine("2.Çık");
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                    goto basadon;
                else if (secim == 2)
                    Environment.Exit(0);
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanlış Seçim");
                    goto basadon2;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Lütfen Yaşınızı Giriniz");
                goto basadon;
            }
        }
    }
}
