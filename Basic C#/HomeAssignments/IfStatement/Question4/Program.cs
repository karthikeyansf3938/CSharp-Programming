using System;
namespace Question4;
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number:");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Input the 2nd number:");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Input the 3rd number:");
            double number3 = double.Parse(Console.ReadLine());

            if(number1>number2 & number1>number3)
            {
                Console.WriteLine("The 1st number is the greatest among three");
            }
            else if(number2>number1 & number2>number3)
            {
                Console.WriteLine("The 2nd number is the greatest among three");
            }
            else
            {
                Console.WriteLine("The 3rd number is the greatest among three");
            }
        }
        
    }