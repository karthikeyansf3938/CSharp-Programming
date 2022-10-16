using System;
namespace Question15
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number:");
            double number=double.Parse(Console.ReadLine());
            int a;
            for(int i=1;i<=number;i++)
            {
                if(number%i==0)
                {
                    a++;
                }
            }
            
            if(a==2)
            {
                System.Console.WriteLine("It's Prime number");
            }
            else
            {
                System.Console.WriteLine("It's not a prime number");
            }
            
        }
    }
}