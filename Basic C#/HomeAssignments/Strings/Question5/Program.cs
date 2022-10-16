using System;
namespace Question5
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Input the 1st string:");
            string input1=Console.ReadLine();
            System.Console.WriteLine("Input the 2nd string:");
            string input2=Console.ReadLine();
            string[] input3=input1.Split(" ");
            string[] input4=input2.Split(" ");
            int flag=0;
            int length1=input3.Length;
            int length2=input4.Length;
            if(length1==length2)
            {
                for(int i=0;i<length1;i++)
                {
                    if(input3[i]==input4[i])
                    {
                        flag=1;
                    }
                }
                if(flag==1)
                {
                    System.Console.WriteLine("The length of both strings are equal and also, both strings are equal");
                }
                else
                {
                    System.Console.WriteLine("The length of both strings are not equal and also, both strings are not equal");
                }
            }

        }
    }
}