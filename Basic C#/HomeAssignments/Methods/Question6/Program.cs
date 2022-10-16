using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a number");
            int number=int.Parse(Console.ReadLine());
            int flag=0;
            Prime(number);
            int Prime(int value)
            {
                for(int i=2;i<=value;i++)
                {
                    if(value%i==0)
                    {   
                        flag=1;
                    }
                }
                
                if(flag==1)
                {
                    System.Console.WriteLine(""+value+" is a prime number");
                }
                else
                {
                    System.Console.WriteLine(""+value+" is not a prime number");
                }
                return flag;
            }
        }
    }
}