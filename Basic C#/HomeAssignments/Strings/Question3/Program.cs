using System;
namespace Question3
{
    class program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a String");
            string input=Console.ReadLine();
            char[] input1=input.ToCharArray();
            System.Console.WriteLine("The characters of the string in reverse are : ");
            string result=" ";
            foreach(char input2 in input)
            {
                result=input2+" "+result;
            }System.Console.WriteLine(result);
        }
    }
}