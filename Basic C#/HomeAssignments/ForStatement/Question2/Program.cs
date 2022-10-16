using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        int sum=0,count=0;
        for(int i=1;i<=10;i++)
        {
            sum=sum+i;
            count=count+1;
        }
        System.Console.WriteLine("Sum : "+sum);
        double average=sum/count;
        System.Console.WriteLine("Average :"+average);
    }
}