using  System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string:");
            string input=Console.ReadLine();
            int count=0;
            char[] input1=input.ToCharArray();
            foreach(char input2 in input)
            {
                count++;
            }
            System.Console.WriteLine("Length of the string is "+input+" is "+count+"");
        }
    }
}
