using System;
namespace Question8
{
    class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Enter a input string:");
            string string1=Console.ReadLine();
            System.Console.WriteLine("Input the position to start extraction:");
            int position=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Input the length of sub string:");
            int position1=int.Parse(Console.ReadLine());
            int length=string1.Length;

            for(int i=position;i<position+position1;i++)
            {
                System.Console.Write(string1[i]);
            }

        }
    }
}