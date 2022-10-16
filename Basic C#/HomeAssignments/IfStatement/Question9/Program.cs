using System;
namespace Question9
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a month");
            string month = Console.ReadLine();

            if(month == "december"||month == "january" ||month=="february")
            {
                Console.WriteLine("Winter");
            }
            else if(month == "march"||month == "april" ||month=="may")
             {
                Console.WriteLine("Spring");
            }
            else if(month == "june"||month == "july" ||month=="august")
             {
                Console.WriteLine("Summer");
            }
            else if(month == "september"||month == "october" ||month=="november")
             {
                Console.WriteLine("Rainfall");
            }
            else
            {
                Console.WriteLine("Invalid");
            }


        }
    }
}