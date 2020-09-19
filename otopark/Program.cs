using System;

namespace otopark
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            basadon:
            Console.WriteLine("Araba Tipini Giriniz(taksi-minibüs-ticari)");
            string secim = Console.ReadLine();
            string a = secim.ToLower();
            if(a == "taksi")
            {
                basadon2:
                Console.WriteLine("Kalınan Saat Bilgisini Giriniz");
                double secim1 = Convert.ToDouble(Console.ReadLine());
                if(secim1 == 1)
                {
                    Console.WriteLine("Ücret 5 TL.");
                }
                else if(secim1 >= 2)
                {
                    double sayi1=1;
                    for (double i = 1; i <= secim1; i++)
                    {
                        sayi1 = (secim1-1)*6;
                    }
                    Console.WriteLine("Ödemeniz Gereken Tutar : "+(5+sayi1));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanlış Seçim");
                    goto basadon2;
                }
            }
            else if(a == "minibüs")
            {
            basadon3:
                Console.WriteLine("Kalınan Saat Bilgisini Giriniz");
                int secim1 = Convert.ToInt32(Console.ReadLine());
                if (secim1 == 1)
                {
                    Console.WriteLine("Ücret 6 TL.");
                }
                else if (secim1 >= 2)
                {
                    double sayi1 = 1;
                    for (double i = 1; i <= secim1; i++)
                    {
                        sayi1 = (secim1 - 1) * 7.29;
                    }
                    Console.WriteLine("Ödemeniz Gereken Tutar : " + (6 + sayi1));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanlış Seçim");
                    goto basadon3;
                }
            }
            else if(a == "ticari")
            {
                basadon4:
                Console.WriteLine("Kalınan Saat Bilgisini Giriniz");
                int secim1 = Convert.ToInt32(Console.ReadLine());
                if (secim1 == 1)
                {
                    Console.WriteLine("Ücret 6.5 TL.");
                }
                else if (secim1 >= 2)
                {
                    double sayi1 = 1;
                    for (double i = 1; i <= secim1; i++)
                    {
                        sayi1 = (secim1 - 1) * 8.125;
                    }
                    Console.WriteLine("Ödemeniz Gereken Tutar : " + (6.5 + sayi1));
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanlış Seçim");
                    goto basadon4;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Yanlış Seçim");
                goto basadon;
            }
        }
    }
}
