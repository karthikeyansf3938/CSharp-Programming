using System;
namespace Question12
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a string:");
            string string1=Console.ReadLine();
            int[] number=new int[100];
            int a=0;
            for(int i=0;i<string1.Length;i++)
            {
                if(string1[i]!=' ')
                {
                    number[a++]=string1[i]-48;
                }
            }
            int maximum=0,minimum=999;
            for(int i=0;i<a;i++)
            {
                if(maximum<number[i])
                {
                    maximum=number[i];
                }
                if(minimum>number[i])
                {
                    minimum=number[i];
                }
            }
            System.Console.WriteLine($"Maximum value:{maximum} \n Minimum value:{minimum}");
        }
    }
}