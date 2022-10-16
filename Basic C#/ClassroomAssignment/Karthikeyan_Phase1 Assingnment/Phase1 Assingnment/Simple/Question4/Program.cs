using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a rate");
            double rate=double.Parse(Console.ReadLine());
            double usd=rate*0.012;
            double eur=rate*0.0127;
            double cny=rate*0.879;
            System.Console.WriteLine($"USD : {+usd} \nEUR : {+eur} \nCNY : {+cny}");
        }
    }
}