using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {   
        int total=0,k=0;
        System.Console.WriteLine("Enter a number:");
        int number=int.Parse(Console.ReadLine());
        k=number;
        while(k!=0)
        {
            int reminder=number%10;
            total=total+reminder;
            k=(int)k/10;
        }System.Console.WriteLine("Total:"+total);
    }
}