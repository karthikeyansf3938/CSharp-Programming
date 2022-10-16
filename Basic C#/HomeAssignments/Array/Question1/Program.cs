using System;
namespace Question1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int inputs;
            System.Console.WriteLine("Enter input");
            int input=int.Parse(Console.ReadLine());

            int[] elements=new int[10];
            System.Console.WriteLine("Enter the elements :");
            for(int i=0;i<input;i++)
            {
                elements[i]=int.Parse(Console.ReadLine());
            }
            for(int j=0;j<input;j++)
            {
                Console.Write(" "+elements[j]);
            }
        
        }
    }
}
