using System;
namespace ByNumberOfArgument;
class Program
{
        static void Display(int number)
        {
            System.Console.WriteLine("Number :"+number);
        }
        static void Display(int number1, int number2)
        {
            System.Console.WriteLine($"Sum : {number1+number2}");
        }
        public static void Main(string[] args)
        {
            Display(100);
            Display(100,200);
        }
    
}