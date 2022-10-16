using System;
namespace Question4
{
    class Program
    {
        public static void Main(string[] args)
        {   
            int number=0;
            int flag=0;
            Console.WriteLine("Input :");
            bool valid=int.TryParse(Console.ReadLine(),out number);
            while(valid!=true)
            {
                System.Console.WriteLine("Invalid input. Enter again");

                Console.WriteLine("Enter the valid number:");
                valid = int.TryParse(Console.ReadLine(),out number);
                
            }
            if(number<=5 && number>=1)
                {
                    flag=1;
                }
            if(flag==1)
            {
                System.Console.WriteLine("Valid number");
            }
            else
            {
                System.Console.WriteLine("Invalid input");
            }
            
        }
    }
}
