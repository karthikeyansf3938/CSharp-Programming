using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enther the number");
        int count=int.Parse(Console.ReadLine());
        int i=0;
        int sum=0;
        while(i<=count)
        {
            System.Console.WriteLine(""+i);
            sum=sum+(i*i);
            i++;
        }
        System.Console.WriteLine("Output"+sum);
        
    }
}