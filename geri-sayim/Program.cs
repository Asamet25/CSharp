using System;
using System.Timers;

namespace CSharp
{
    class Program
    {
       public static void Main(string[] args)
        {
            if(comeback == true)
            {
                goto basadon;
            }
            basadon:
            Console.WriteLine("Kaç Saniyelik Geri Sayım Yapacaksınız");
            int secim = Convert.ToInt32(Console.ReadLine());
            choose = secim;
            var time = new Timer();
            time1.Enabled = true;
            time = time1;
            time1.Interval = 1000;
            time1.Start();
            time1.Elapsed += Counter;
            Console.ReadLine();

        }
        static Boolean comeback = false;
        static int choose;
        static Timer time1 = new Timer();
        public static void Counter(object sender,ElapsedEventArgs e)
        {
            if (choose <= 0)
            {
                time1.Enabled= false; 
                time1.Close();
                finish();
            }
            else
            {
                Console.Clear();
                choose--;
                Console.WriteLine("Kalan Süre : "+choose+" "+"sn");
            }
        }
        public static void finish()
        {
            time1.Enabled = false;
            time1.Stop();
            Console.WriteLine("Geri Sayım Bitti");
            var time2 = new Timer();
            time2.Interval = 1000;
            time2.Start();
            time2.Elapsed += logout;
            time3 = time2;
        }
        static int gerisayim = 5;
        static Timer time3 = new Timer();
        public static void logout(object sender,ElapsedEventArgs e)
        {
            Console.Clear();
            gerisayim--;
            Console.WriteLine("Uygulamadan " + gerisayim + " " + "sn sonra çıkılacak");
            if(gerisayim == 0)
            {
                time3.Stop();
                Environment.Exit(0);
            }
        }
    }
}