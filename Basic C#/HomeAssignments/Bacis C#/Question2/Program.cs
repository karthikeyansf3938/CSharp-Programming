using System;
namespace Question2;
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input the first number:");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number:");
            int number2 = int.Parse(Console.ReadLine());

            double addition = number1 + number2;
            double substraction = number1 - number2;
            double multiplication = number1 * number2;
            double division = number1 / number2;
            double percentage = division* 100;

            Console.WriteLine($"{number1} + {number2} = "+addition);
            Console.WriteLine($"{number1} - {number2} = "+substraction);
            Console.WriteLine($"{number1} * {number2} = "+multiplication);
            Console.WriteLine($"{number1} / {number2} = "+division);
            Console.WriteLine($"{number1} % {number2} = "+percentage);


        }
    }
