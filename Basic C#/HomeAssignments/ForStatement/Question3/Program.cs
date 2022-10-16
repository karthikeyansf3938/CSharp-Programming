using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of terms:");
        double number=double.Parse(Console.ReadLine());
        for(int i=1;i<=number;i++)
        {
            System.Console.WriteLine("Number is:"+i+" and cube of "+i+ "is" +i);
        }
    }
}
