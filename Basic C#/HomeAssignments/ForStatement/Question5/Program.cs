
using System;
namespace Question5;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the input the number of terms:");
        double input=double.Parse(Console.ReadLine());
        double count=0;
        System.Console.WriteLine("The odd numbers are:");
        for(int i=1;i<20;i++)
        {
            if(i%2 != 0)
            {
                System.Console.WriteLine(i);
                count=count+i;
            }
            
        }System.Console.WriteLine("The Sum of odd Natural Number upto 10 terms "+count);
    }
}