using System;

namespace hesap_makinesi
{
    class Program
    {
        static void Main(string[] args)
        { 
        Basadon:
            Console.WriteLine("1.Sayıyı Giriniz");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.Sayıyı Giriniz");
            double number2 = Convert.ToDouble(Console.ReadLine());
            basadon:
            Console.WriteLine("Hangi İşlemi Yapacağınızı Seçin");
            Console.WriteLine("1-TOPLAMA");
            Console.WriteLine("2-ÇIKARMA");
            Console.WriteLine("3-ÇARPMA");
            Console.WriteLine("4-BÖLME");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                double toplam = (number1 + number2);
                Console.WriteLine("Sonuç = "+ toplam);  
                Console.WriteLine("");
                basadon1:
                Console.WriteLine("1-Yeniden İşlem Yap");
                Console.WriteLine("2-Çık");
                char secim = Convert.ToChar(Console.ReadLine());
                if(secim == '1')
                {
                    Console.Clear();
                    goto Basadon;
                }
                else if(secim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    goto basadon1;
                }
                break;
                case 2:
                toplam = (number1 -  number2);
                Console.WriteLine("Sonuç = "+ toplam);
                Console.WriteLine("");
                basadon2:
                Console.WriteLine("1-Yeniden İşlem Yap");
                Console.WriteLine("2-Çık");
                char secim1 = Convert.ToChar(Console.ReadLine());
                if(secim1== '1')
                {
                    Console.Clear();
                    goto Basadon;
                }
                else if(secim1 == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    goto basadon2;
                }
                break;
                case 3:
                toplam = (number1 * number2);
                Console.WriteLine("Sonuç = "+ toplam);
                Console.WriteLine("");
                basadon3:
                Console.WriteLine("1-Yeniden İşlem Yap");
                Console.WriteLine("2-Çık");
                char secim2 = Convert.ToChar(Console.ReadLine());
                if(secim2 == '1')
                {
                    Console.Clear();
                    goto Basadon;
                }
                else if(secim2 == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    goto basadon3;
                }
                break;
                case 4:
                toplam = (number1 / number2);
                Console.WriteLine("Sonuç = "+ toplam);
                Console.WriteLine("");
                basadon4:
                Console.WriteLine("1-Yeniden İşlem Yap");
                Console.WriteLine("2-Çık");
                char secim3 = Convert.ToChar(Console.ReadLine());
                if(secim3 == '1')
                {
                    Console.Clear();
                    goto Basadon;
                }
                else if(secim3 == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Yanlış Seçim Yaptınız");
                    goto basadon4;
                }
                break;
                default:
                Console.Clear();
                Console.WriteLine("Yanlış Seçim Yaptınız");
                goto basadon;
            }
        }
    }
}