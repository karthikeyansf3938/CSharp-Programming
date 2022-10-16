using System;
namespace String
{
    class Program
    {
        public static void Main(string[] args)
        {
            int count=0;
            System.Console.WriteLine("Main String:");
            string input=Console.ReadLine();
            System.Console.WriteLine("String to be searched:");
            string input1=Console.ReadLine();
            string input2=input.Replace(input1,"#");
            char[] output=input2.ToCharArray();
            foreach(char inputs in output)
            {
                if(inputs=='#')
                {
                    count++;
                }

            }
            System.Console.WriteLine($"String count is {+count}");

        }
    }
}