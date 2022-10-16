using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input1:");
            double input1=double.Parse(Console.ReadLine());

            System.Console.WriteLine("Input2:");
            double input2=double.Parse(Console.ReadLine());

            Addition(input1,input2);
            Substraction(input1,input2);
            Multiplication(input1,input2);
            Division(input1,input2);

            double Addition(double x,double y)
            {
                double sum=x+y;
                System.Console.WriteLine($"Addition :{+sum}");
                return sum;
            }
            double Substraction(double x,double y)
            {
                double minus=x-y;
                System.Console.WriteLine($"substraction :{+minus}");
                return minus;
            }
            double Multiplication(double x,double y)
            {
                double multiply = x*y;
                System.Console.WriteLine($"Multiplication :{+multiply}");
                return multiply;
            }
            double Division(double x,double y)
            {
                double quotient=x/y;
                System.Console.WriteLine($"Division :{+quotient}");
                return quotient;
            }
        }
    }
}
