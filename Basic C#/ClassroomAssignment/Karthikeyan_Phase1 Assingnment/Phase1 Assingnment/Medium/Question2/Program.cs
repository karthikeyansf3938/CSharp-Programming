using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input numbers of terms to display:");
            int numbers=int.Parse(Console.ReadLine());
            int i=0,j=1,k,count=0;
            while(count<numbers)
            {
                Console.Write(" "+i);

                k=i+j;
                i=j;
                j=k;
                count++;
            }
        }
    }
}