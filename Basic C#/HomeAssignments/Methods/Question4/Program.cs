using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input number of fibonacci series:");
            int input=int.Parse(Console.ReadLine());
            Fibonacci(input);
            static int[] Fibonacci(int x)
            {   
                int i;
                int[] value=new int[x];
                value[0]=0;
                value[1]=1;
                for( i=2;i<x;i++)
                {
                    value[i] = value[i-2] + value[i-1];
                    Console.Write(" "+value[i]);
                }
                return value;  
            }
        }
    }
}
