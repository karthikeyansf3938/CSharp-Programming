using System;
namespace Question7
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter the string:");
            string input=Console.ReadLine();

            int count=0, count1=0;
            int length=input.Length;

            string input1=input.ToLower();
            for(int i=0;i<length;i++)
            {
                if(input1[i]=='a' || input1[i]=='e' || input1[i]=='i' || input1[i]=='o' || input1[i]=='u')
                {
                    count++;
                }
                else
                {
                    count1++;
                }
            }
            System.Console.WriteLine("Vowels:"+count);
            System.Console.WriteLine("Constants:"+count1);
        }
    }
}