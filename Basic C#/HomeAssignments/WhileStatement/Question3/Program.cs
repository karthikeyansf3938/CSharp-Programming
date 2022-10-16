using System;
namespace Question3;

class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Input number of terms to display:");
        int number=int.Parse(Console.ReadLine());
        int i=0,j=1,k=0;
        int count=0;
        while(count<number)
        {

           System.Console.Write("\t"+i);
            k=i+j;
            i=j;
            j=k;
            count++;
            
        }
    }
}