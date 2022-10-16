using System;
namespace Question6
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the initaial valiue");
            int value1=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter the final value valiue");
            int value2=int.Parse(Console.ReadLine());
            while(value1<=value2)
            {
                if(value1%2==0)
                {
                    
                    System.Console.WriteLine(+value1);
                }
            }
            while(value1<=value2)
            {
                if(value1%2!=0)
                {
                    System.Console.WriteLine(+value1);
                }
            }
            while(value1<=value2)
            {
                
            }
        }
    }
}