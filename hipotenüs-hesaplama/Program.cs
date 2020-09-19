using System;

namespace hipotenüshesaplama
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1.Dik Kenarın Uzunluğunu Yazınız");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Dik Kenarın Uzunluğunu Yazınız");
            int number2 = Convert.ToInt32(Console.ReadLine());
            double number1kare = Math.Pow(number1, 2);
            double number2kare = Math.Pow(number2, 2);
            double hesaplama = number1kare + number2kare;
            double hipotenus = Math.Sqrt(hesaplama);
            Console.WriteLine("Hipotenüs =  " + hipotenus);
            Console.ReadLine();
        }
    }
}