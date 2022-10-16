using System;
namespace Question11
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter X:");
            double number1=double.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Y:");
            double number2=double.Parse(Console.ReadLine());
            double value,i;
            for(i=1;i<=number2;i++)
            {
                value=number1*(i*number1);
                System.Console.WriteLine("Value : "+value);  
            } 
        }
    }
}