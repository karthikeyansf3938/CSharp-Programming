using System;
namespace ForStatement;
    class program
    {
        public static void Main(string[] args)
        {
            for(int i=0;i<=25;i++)
            {
                if(i>0 && i%2==0)
                {
                    Console.WriteLine(" Even numbers :"+i);
                }

            }
            System.Console.WriteLine("Enter a Initaial value");
            int number1 = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter a Final value");
            int number2 = int.Parse(Console.ReadLine());

            int count=0;
            for(int i = number1;i<=number2;i++)
            {
                int sum = i*i;
                count = sum + count;
                
            }
            System.Console.WriteLine("count "+count);


    
        }
    }