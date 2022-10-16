using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input the upper limit:");
            int limit1=int.Parse(Console.ReadLine());
            int reminder,sum=0,j,n;
            for(int i=1;i<limit1;i++)
            {
                while(i>0)
                {
                    reminder=i%2;
                    sum=(sum*10)+reminder;
                    j=i/10;
                    n=i*j;
                }
            }System.Console.WriteLine(""+sum);
        }
    }
}