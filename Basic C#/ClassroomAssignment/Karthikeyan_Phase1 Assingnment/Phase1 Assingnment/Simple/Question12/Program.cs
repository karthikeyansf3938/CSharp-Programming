using System;
namespace Question12
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input the number of terms:");
            double value=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Number of odd numbers:");
            double sum=0;
            for(int i=1;i<=value;i++)
            {
                Console.Write("{0} ",2*i-1);
                sum+=2*i-1;
            }System.Console.WriteLine("\nThe sum of odd number:"+sum);
        }
    }
}