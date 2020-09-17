using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Taban Sayıyı Giriniz");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Üsü Giriniz");
            int number2 = Convert.ToInt32(Console.ReadLine());
            double uslusayi = Math.Pow(number1,number2);
            Console.WriteLine(number1 + " üzeri " + number2 + " = "+ uslusayi);    
        }
    }
}