using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number:");
            double number1=double.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter the another number");
            double number2=double.Parse(Console.ReadLine());

            Swap(number1,number2);

            double Swap(double x ,double y )
            {
                double temp=x;
                x=y;
                y=temp;
                System.Console.WriteLine($"Now the 1st number is {x} ,and the 2nd number is {y}");
                return temp;
            }
        }
    }
}