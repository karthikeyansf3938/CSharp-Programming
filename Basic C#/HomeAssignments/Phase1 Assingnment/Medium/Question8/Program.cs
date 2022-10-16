using System;
namespace Question13
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string:");
            string string1=Console.ReadLine();
            int flag=0;
            for(int i=0;i<string1.Length;i++)
            {
                if(string1[i]>='0' && string1[i]<='9')
                {
                    System.Console.Write(""+string1[i]);
                }
                 if(string1[i]%2==0)
                {
                    flag=1;          
                }
            }
            if(flag!=1)
            {
                System.Console.WriteLine("\nOdd number");
            }
           else
            {
                System.Console.WriteLine(" \nEven number");
            }
        }
    }
}