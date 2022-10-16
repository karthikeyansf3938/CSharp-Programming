using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        string condition="yes";
        int sum=0;
        do
        {
            
            System.Console.WriteLine("Enter the number");
            int number=int.Parse(Console.ReadLine());

            
            System.Console.WriteLine("Do you want enter again:(yes/no)");
            condition=Console.ReadLine();
            
            if(number>0)
            {
            sum=number+sum;
            }
        } while (condition=="yes");
        Console.WriteLine(+sum);
    
    }
}