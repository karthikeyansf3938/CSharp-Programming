using System;
namespace Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Tailor Series:");
            System.Console.WriteLine("Enter the terms :");
            double terms=double.Parse(Console.ReadLine());
            double fact=2;
            double sum=0;
            double output;
            for(int i=1;i<terms;i++)
            {
                for(fact=1;fact<terms;fact++)
                {
                    sum=fact*i;
                    output=sum+(fact*i);
                }
            }
            System.Console.WriteLine("Ouput:"+output);
        }
    }
}