using System;
namespace WhileStatement;

    class program
    {
        public static void Main(string[] args)
        {
            int i =0;
            while(i<=25)
            {
                if(i%2==0)
                {
                    Console.WriteLine(""+i);
                }
                i++;
            }
            int number=0;
            Console.WriteLine("Enter the number");
            bool valid = int.TryParse(Console.ReadLine(),out number);
            while(valid!=true)
            {
                Console.WriteLine("Invalid input format. please enter the input in number format");
                

                Console.WriteLine("Enter the valid number");
                valid=int.TryParse(Console.ReadLine(),out number);
            }System.Console.WriteLine("Valid number");
            Console.WriteLine("number");
        }
        
    }