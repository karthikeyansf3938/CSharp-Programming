using System;
namespace Question3
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input1:");
            string input1=Console.ReadLine();
            System.Console.WriteLine("Input2:");
            string input2=Console.ReadLine();
            int flag=0;
            for(int i=0;i<input1.Length;i++)
            {
                if(input2.Contains(input1[i]))
                {
                    flag=1;
                }
            }
            if(flag!=1)
            {
                System.Console.WriteLine("Name one and two are not Anagrams");
            }
            else
            {
                System.Console.WriteLine("Name one and two are Anagrams");
            }
        }
    }
}