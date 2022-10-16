using System;
namespace Question10
{
    class Program
    {
        public static void Main(string[] args)
        {
            int i,input,temp=0;
            System.Console.WriteLine("Enter the input:");
            input=int.Parse(Console.ReadLine());
            for(i=1;i<=input;i++)
            {
                if(input%i==0)
                {
                    temp++;
                }

            }
                if(temp==2)
                {
                    System.Console.WriteLine($"{input} is prime number");
                }
                else
                {
                    System.Console.WriteLine($"{input} is not a prime number");
                }
            
        }
    }
}
