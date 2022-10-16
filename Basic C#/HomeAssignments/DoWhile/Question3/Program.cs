using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the number of terms:");
            int term=int.Parse(Console.ReadLine());
            int i=0,j=1,k=0;
            int count=0;

            do
            {
                System.Console.Write(" "+i);
                k=i+j;
                i=j;
                j=k;
                count++;
            }while(count<term);
        }
    }
}
